using System.Web.Mvc;
using Arkitektum.Kartverket.MetadataCore.Validate;

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

            ViewBag.Results = _validationResultRepository.GetValidationResults();

            return View();
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
