using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResult : TableEntity
    {
        public ValidationResult(string uuid)
        {
            PartitionKey = "GeoNorge";
            RowKey = uuid;
        }

        public ValidationResult() { }

        public string Title { get; set; }
        public DateTime ValidateTimestamp { get; set; }
        public string ErrorMessages { get; set; }
        public int ValidateResult { get; set; }
        public string ResourceType { get; set; }
        public string Organization { get; set; }


        public bool IsResourceTypeApplicableForValidation()
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
    }

}
