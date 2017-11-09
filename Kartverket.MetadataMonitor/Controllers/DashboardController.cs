using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kartverket.MetadataMonitor.Helpers;
using Kartverket.MetadataMonitor.Models;

namespace Kartverket.MetadataMonitor.Controllers
{
    [HandleError]
    public class DashboardController : Controller
    {
        private readonly MetadataRepository _metadataRepository;

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private DashboardController(MetadataRepository metadataRepository)
        {
            _metadataRepository = metadataRepository;
        }

        public DashboardController() : this(new MetadataRepository()) { }

        public ActionResult Index()
        {
            var results = _metadataRepository.GetMetadataListWithLatestValidationResult(null, null, null,null, null);

            var totalResultCount = results.Count();
            var totalResultNotValidated = results.Count(n => n.isNotValidated());
            var totalResultOk = results.Count(n => n.IsOk());
            var totalResultFailed = totalResultCount - totalResultNotValidated - totalResultOk;

            var inspireResults = results.Where(n => n.InspireResource);
            var norgeDigitaltResults = results.Where(n => n.InspireResource == false);

            var model = new DashboardViewModel
                {
                    TotalResultCount = totalResultCount,
                    TotalResultOk = totalResultOk,
                    TotalResultFailed = totalResultFailed,
                    TotalNotValidated = totalResultNotValidated,
                    
                    InspireService = GetResultsForResourceType(inspireResults, "service"),
                    InspireDataset = GetResultsForResourceType(inspireResults, "dataset"),
                    InspireSeries = GetResultsForResourceType(inspireResults, "series"),
                    NdService = GetResultsForResourceType(norgeDigitaltResults, "service"),
                    NdDataset = GetResultsForResourceType(norgeDigitaltResults, "dataset"),
                    NdSeries = GetResultsForResourceType(norgeDigitaltResults, "series"),
                    NdSoftware = GetResultsForResourceType(norgeDigitaltResults, "software"),
                };
            return View(model);
        }

        [Route("setculture/{culture}")]
        public ActionResult SetCulture(string culture, string returnUrl)
        {
            // Validate input
            culture = CultureHelper.GetImplementedCulture(culture);
            // Save culture in a cookie
            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;   // update cookie value
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);

            if (!string.IsNullOrEmpty(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction("Index");
        }

        private static Result GetResultsForResourceType(IEnumerable<MetadataEntry> results, string resourceType)
        {
            var allResourceResults = results.Where(n => n.ResourceType == resourceType);
            var resourceResults = new Result()
                {
                    Failed = allResourceResults.Count(n => !n.IsOk()),
                    Ok = allResourceResults.Count(n => n.IsOk()),
                    Unknown = allResourceResults.Count(n => n.isNotValidated())
                };
            return resourceResults;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Log.Error("Error", filterContext.Exception);
        }
    }
}
