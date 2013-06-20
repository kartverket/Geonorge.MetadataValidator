using System.Linq;
using System.Web.Mvc;
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
            var results = _validationResultRepository.GetValidationResults(null, null);

            var totalResultCount = results.Count();
            var totalResultNotValidated = results.Count(n => n.ValidateResult == -1);
            var totalResultOk = results.Count(n => n.ValidateResult == 1);
            var totalResultFailed = totalResultCount - totalResultNotValidated - totalResultOk;
            
            var model = new DashboardViewModel
                {
                    TotalResultCount = totalResultCount, 
                    TotalResultOk = totalResultOk, 
                    TotalResultFailed = totalResultFailed,
                    TotalNotApplicableForInspire = totalResultNotValidated
                };

            return View(model);
        }

    }
}
