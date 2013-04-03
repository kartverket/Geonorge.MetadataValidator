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
        public ValidationResult(string url)
        {
            this.RowKey = url;
        }

        public ValidationResult() {}

        public DateTime ValidateTimestamp { get; set; }
        public bool ValidateOk { get; set; }
        public string ErrorMessages { get; set; }
    }
}
