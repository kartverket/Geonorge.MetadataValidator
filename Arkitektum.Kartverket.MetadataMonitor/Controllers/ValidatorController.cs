using System.Collections.Generic;
using System.Web.Mvc;
using Arkitektum.Kartverket.MetadataCore.Validate;
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

        public ActionResult Index(string message)
        {
            ViewBag.Message = message;

            var results = _validationResultRepository.GetValidationResults();

            List<ValidationResultModel> model = new List<ValidationResultModel>();
            foreach (var result in results)
            {
                model.Add(new ValidationResultModel(result));
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Start(string uuid)
        {
            if (string.IsNullOrEmpty(uuid))
                uuid = "9d118d31-182c-495b-b7be-d819cc7444b1";


            _validatorService.AddToValidationQueue(uuid);
            
            return RedirectToAction("Index", new {message = "Started!"});
        }
    }
}
