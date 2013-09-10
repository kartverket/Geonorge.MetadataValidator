using System.Collections.Generic;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class MetadataEntry
    {
        public string Uuid { get; set; }
        public string Title { get; set; }
        public string ResponsibleOrganization { get; set; }
        public string ResourceType { get; set; }
        public bool InspireResource { get; set; }
        public List<ValidationResult> ValidationResults { get; set; }

        public bool IsOk()
        {
            bool result = false;

            if (ValidationResults != null && ValidationResults[0] != null)
            {
                var validationResult = ValidationResults[0];
                result = validationResult.IsOk();
            }
            return result;
        }

        public bool isNotValidated()
        {
            bool result = true;

            if (ValidationResults != null && ValidationResults[0] != null)
            {
                var validationResult = ValidationResults[0];
                result = validationResult.IsNotValidated();
            }
            return result;
        }

        public bool IsFailed()
        {
            bool result = false;

            if (ValidationResults != null && ValidationResults[0] != null)
            {
                var validationResult = ValidationResults[0];
                result = validationResult.IsFailed();
            }
            return result;
        }
    }
}