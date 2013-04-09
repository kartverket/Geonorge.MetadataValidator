using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Arkitektum.Kartverket.MetadataCore.Validate;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResultModel
    {

        public ValidationResultModel(ValidationResult validationResult)
        {
            Uuid = validationResult.RowKey;
            Title = validationResult.Title;
            Url = validationResult.Url;
            ValidateTimestamp = validationResult.ValidateTimestamp;
            ValidateOk = validationResult.ValidateOk;
            if (validationResult.ErrorMessages != null)
                ErrorMessages = new List<string>(validationResult.ErrorMessages.Split('\n'));
        }

        public string Uuid { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime ValidateTimestamp { get; set; }
        public bool ValidateOk { get; set; }
        public List<string> ErrorMessages { get; set; }

    }
}