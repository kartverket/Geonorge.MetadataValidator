using System.Linq;
using System.Web.Mvc;
using Arkitektum.Kartverket.MetadataCore.Validate;
using Arkitektum.Kartverket.MetadataMonitor.Models;

namespace Arkitektum.Kartverket.MetadataMonitor.Controllers
{
    public class DashboardController : Controller
    {

        private readonly ValidationResultRepository _validationResultRepository;

        private DashboardController(ValidationResultRepository validationResultRepository)
        {
            _validationResultRepository = validationResultRepository;
        }

        public DashboardController() : this(new ValidationResultRepository()) { }

        public ActionResult Index()
        {
            var results = _validationResultRepository.GetValidationResults();

            var totalResultCount = results.Count();
            var totalResultOk = results.Count(n => n.ValidateOk);
            var totalResultFailed = totalResultCount - totalResultOk;

            var totalMetadata19139 = results.Count(n => n.MetadataStandardName.Equals("ISO 19139"));
            var totalMetadata19115 = results.Count(n => n.MetadataStandardName.Equals("ISO 19115:2003/19139"));
            var totalMetadataOther = totalResultCount - totalMetadata19115 - totalMetadata19139;

            var model = new DashboardViewModel
                {
                    totalResultCount = totalResultCount, 
                    totalResultOk = totalResultOk, 
                    totalResultFailed = totalResultFailed,
                    totalMetadata19139 = totalMetadata19139,
                    totalMetadata19115 = totalMetadata19115,
                    totalMetadataOther = totalMetadataOther
                };

            return View(model);
        }

    }
}
