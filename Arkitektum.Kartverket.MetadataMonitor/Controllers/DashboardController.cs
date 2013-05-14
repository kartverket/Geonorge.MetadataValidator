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

            var errorUnknownResourceType =
                results.Count(n => n.ErrorMessages.Contains("It was not possible to determine the resource type"));
            var errorNotSupportedResourceType =
                results.Count(n => n.ErrorMessages.Contains("The resource type code \"software\" is not supported"));
            var errorMissingSpatialDataTheme =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Inspire Spatial Data Theme\" is missing"));
            var errorMissingConditionsForAccess =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Conditions For Access And Use\" is missing"));
            var errorMissingResponsibleOrganisation =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Responsible Organisation\" is missing"));
            var errorMissingLanguage =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Metadata Language\" is missing"));
            var errorMissingResourceIdentifier =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Unique Resource Identifier\" is missing"));
            var errorMissingLineage =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Lineage\" is missing"));
            var errorMissingConformity =
                results.Count(n => n.ErrorMessages.Contains("The metadata element \"Conformity\" is missing"));


            var model = new DashboardViewModel
                {
                    TotalResultCount = totalResultCount, 
                    TotalResultOk = totalResultOk, 
                    TotalResultFailed = totalResultFailed,
                    TotalMetadata19139 = totalMetadata19139,
                    TotalMetadata19115 = totalMetadata19115,
                    TotalMetadataOther = totalMetadataOther,
                    ErrorUnknownResourceType = errorUnknownResourceType,
                    ErrorNotSupportedResourceType = errorNotSupportedResourceType,
                    ErrorMissingSpatialDataTheme = errorMissingSpatialDataTheme,
                    ErrorMissingConditionsForAccess = errorMissingConditionsForAccess,
                    ErrorMissingResponsibleOrganisation = errorMissingResponsibleOrganisation,
                    ErrorMissingLanguage = errorMissingLanguage,
                    ErrorMissingResourceIdentifier = errorMissingResourceIdentifier,
                    ErrorMissingLineage = errorMissingLineage,
                    ErrorMissingConformity = errorMissingConformity
                };

            return View(model);
        }

    }
}
