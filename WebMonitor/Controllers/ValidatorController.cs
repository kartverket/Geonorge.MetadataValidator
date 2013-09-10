using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using Arkitektum.Kartverket.MetadataMonitor.Models;

namespace Arkitektum.Kartverket.MetadataMonitor.Controllers
{
    public class ValidatorController : Controller
    {
        private readonly MetadataRepository _metadataRepository;
        private readonly ValidatorService _validatorService;

        private ValidatorController(MetadataRepository metadataRepository, ValidatorService validatorService)
        {
            _metadataRepository = metadataRepository;
            _validatorService = validatorService;
        }

        public ValidatorController() : this(new MetadataRepository(), new ValidatorService()) { }

        public ActionResult Index(string message, int? status, string organization, string resourceType)
        {
            ViewBag.Message = message;
            
            List<MetadataEntry> metadataEntries = _metadataRepository.GetMetadataListWithLatestValidationResult(status, organization, resourceType);

            var myTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            

            var model = new ValidatorResultPageModel()
                {
                    Organization = organization,
                    Status = status,
                    MetadataEntries = metadataEntries,
                };

            ViewBag.Organizations = new SelectList(_metadataRepository.GetAvailableOrganizations(), organization);
            IDictionary<int, string> statusOptions = new Dictionary<int, string>
                {
                    {1, "OK"},
                    {0, "Feil"},
                    {-1, "Ikke validert"}

                };
            ViewBag.StatusOptions = new SelectList(statusOptions, "Key", "Value", status);

            List<string> resourceTypes = new List<string>()
                {
                    "service", "dataset", "series", "software"
                };
            ViewBag.ResourceTypes = new SelectList(resourceTypes, resourceType);

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public ActionResult RunValidate(string uuid, string organization, int? status)
        {
            if (string.IsNullOrEmpty(uuid))
                uuid = "9d118d31-182c-495b-b7be-d819cc7444b1";

            _validatorService.ValidateMetadata(uuid);
            
            return RedirectToAction("Index", new {message = "Validering gjennomført!", organization = organization, status = status});
        }

        [HttpGet]
        [Authorize]
        public ActionResult ValidateAll()
        {
           new Thread(() => {
               new ValidatorService().RunValidateWithRegularSearch();
            }).Start();
                    
                
            return RedirectToAction("Index", new {message = "Full validering startet!"});
        }
       
    }
}
