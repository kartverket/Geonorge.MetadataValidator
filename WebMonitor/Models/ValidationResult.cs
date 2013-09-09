using System;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResult
    {
        public int Result { get; set; }
        public DateTime Timestamp { get; set; }
        public string Messages { get; set; }
        
/*
        public bool IsResourceTypeApplicableForInspireValidation()
        {
            // ReSharper disable ReplaceWithSingleAssignment.False
            bool result = false;
            if (ResourceType != null && (ResourceType == "dataset" || ResourceType == "service" || ResourceType == "series"))
            {
                result = true;
            }
            // ReSharper restore ReplaceWithSingleAssignment.False
            return result;
        }

        public bool IsOk()
        {
            return ValidateResult == 1;
        }

        public bool isNotValidated()
        {
            return ValidateResult == -1;
        }

        public bool IsResourceType(string incomingResourceType)
        {
            return ResourceType != null && ResourceType.Equals(incomingResourceType);
        }
 * */

        public bool IsOk()
        {
            return Result == 1;
        }

        public bool IsNotValidated()
        {
            return Result == -1;
        }
    }

}
