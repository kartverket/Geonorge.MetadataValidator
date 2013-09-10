using System;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResult
    {
        public int Result { get; set; }
        public DateTime Timestamp { get; set; }
        public string Messages { get; set; }

        public bool IsOk()
        {
            return Result == 1;
        }

        public bool IsNotValidated()
        {
            return Result == -1;
        }

        public bool IsFailed()
        {
            return Result == 0;
        }
    }

}
