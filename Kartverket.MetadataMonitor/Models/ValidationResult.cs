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
        public const double UndefinedIndicator = -1.0;

        public ValidationStatus Status { get; set; }
        public double CompletenessIndicator { get; set; } = UndefinedIndicator;
        public double InteroperabilityIndicator { get; set; } = UndefinedIndicator;
        public DateTime Timestamp { get; set; }
        public string Messages { get; set; }
        public string ReportUrl { get; set; }

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
