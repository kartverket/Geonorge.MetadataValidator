using System.Web.Mvc;
using Arkitektum.Kartverket.MetadataCore.Validate;

namespace Arkitektum.Kartverket.MetadataMonitor.Controllers
{
    public class ValidatorController : Controller
    {
        //
        // GET: /Validator/

        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Start()
        {
            new ValidatorService().AddToValidationQueue();
            return RedirectToAction("Index", new {message = "Started!"});
        }
    }
}
