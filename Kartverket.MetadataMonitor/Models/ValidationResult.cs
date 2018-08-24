using System;

namespace Kartverket.MetadataMonitor.Models
{
    public enum ValidationStatus
    {
        Valid = 1,
        Invalid = 0,
        NotValidated = -1
    }
    public class ValidationResult
    {
        public ValidationStatus Status { get; set; }
        public DateTime Timestamp { get; set; }
        public string Messages { get; set; }
        public bool InspireResource { get; set; }

        public string GetResultAsText()
        {
            switch (Status)
            {
                case ValidationStatus.Valid:
                    return "OK";
                case ValidationStatus.Invalid:
                    return "Failed";
                default:
                    return "Not validated";
            }
        }
    }

}
