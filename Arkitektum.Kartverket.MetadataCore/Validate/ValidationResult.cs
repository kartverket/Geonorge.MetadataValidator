using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class ValidationResult : TableEntity
    {
        public ValidationResult(string uuid)
        {
            this.PartitionKey = "GeoNorge";
            this.RowKey = uuid;
        }

        public ValidationResult() {}

        public string Url { get; set; }
        public DateTime ValidateTimestamp { get; set; }
        public bool ValidateOk { get; set; }
        public string ErrorMessages { get; set; }
    }
}
