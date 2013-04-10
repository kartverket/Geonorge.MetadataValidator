using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Arkitektum.Kartverket.MetadataCore.Validate;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResultModel : IComparable<ValidationResultModel>
    {

        public ValidationResultModel(ValidationResult validationResult)
        {
            Uuid = validationResult.RowKey;
            Title = validationResult.Title;
            Url = validationResult.Url;
            ValidateTimestamp = validationResult.ValidateTimestamp;
            ValidateOk = validationResult.ValidateOk;
            MetadataStandardName = validationResult.MetadataStandardName;
            if (validationResult.ErrorMessages != null)
                ErrorMessages = new List<string>(validationResult.ErrorMessages.Split('\n'));
        }

        public string Uuid { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime ValidateTimestamp { get; set; }
        public bool ValidateOk { get; set; }
        public List<string> ErrorMessages { get; set; }
        public string MetadataStandardName { get; set; }

        public int CompareTo(ValidationResultModel other)
        {
            return ValidateTimestamp.CompareTo(other.ValidateTimestamp);
        }
    }
}