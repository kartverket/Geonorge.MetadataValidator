using System;
using System.Collections.Generic;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResultModel : IComparable<ValidationResultModel>
    {

        public ValidationResultModel(TimeZoneInfo myTimeZone, ValidationResult validationResult)
        {
            Uuid = validationResult.RowKey;
            Title = validationResult.Title;
            ValidateTimestamp = TimeZoneInfo.ConvertTimeFromUtc(validationResult.ValidateTimestamp, myTimeZone); 
            ValidateResult = validationResult.ValidateResult;
            ResourceType = validationResult.ResourceType;
            if (validationResult.ErrorMessages != null)
                ErrorMessages = new List<string>(validationResult.ErrorMessages.Split('\n'));
            Organization = validationResult.Organization;
        }

        public string Uuid { get; set; }
        public string Title { get; set; }
        public DateTime ValidateTimestamp { get; set; }
        public int ValidateResult { get; set; }
        public List<string> ErrorMessages { get; set; }
        public string ResourceType { get; set; }
        public string Organization { get; set; }

        public int CompareTo(ValidationResultModel other)
        {
            return ValidateTimestamp.CompareTo(other.ValidateTimestamp);
        }
    }
}