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
        private readonly ValidationResultRepository _validationResultRepository;
        private ValidatorService _validatorService;

        private ValidatorController(ValidationResultRepository validationResultRepository, ValidatorService validatorService)
        {
            _validationResultRepository = validationResultRepository;
            _validatorService = validatorService;
        }

        public ValidatorController() : this(new ValidationResultRepository(), new ValidatorService()) { }

        public ActionResult Index(string message, int? status, string organization)
        {
            ViewBag.Message = message;
            
            var results = _validationResultRepository.GetValidationResults(status, organization);

            var myTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");

            List<ValidationResultModel> resultModels = new List<ValidationResultModel>();
            foreach (var result in results)
            {
                resultModels.Add(new ValidationResultModel(myTimeZone, result));
            }

            resultModels.Sort();
            resultModels.Reverse();

            var model = new ValidatorResultPageModel()
                {
                    Organization = organization,
                    Status = status,
                    ValidationResults = resultModels,
                };
            ViewBag.Organizations = new SelectList(_validationResultRepository.GetAvailableOrganizations(), organization);
            IDictionary<int, string> statusOptions = new Dictionary<int, string>
                {
                    {1, "OK"},
                    {2, "Feil"},
                    {-1, "Ikke validert"}

                };
            ViewBag.StatusOptions = new SelectList(statusOptions, "Key", "Value", status);
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public ActionResult RunValidate(string uuid)
        {
            if (string.IsNullOrEmpty(uuid))
                uuid = "9d118d31-182c-495b-b7be-d819cc7444b1";

            _validatorService.ValidateMetadata(uuid);
            
            return RedirectToAction("Index", new {message = "Validering gjennomført!"});
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
