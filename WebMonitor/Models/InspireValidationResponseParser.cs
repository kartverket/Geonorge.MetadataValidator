using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class InspireValidationResponseParser
    {
        
        public static readonly XNamespace NsCommon = "http://inspire.ec.europa.eu/schemas/common/1.0";
        public static readonly XNamespace NsGeo = "http://inspire.ec.europa.eu/schemas/geoportal/1.0";
        public static readonly XNamespace NsRdsi = "http://inspire.ec.europa.eu/schemas/rdsi/1.0";

        private readonly XDocument _inspireValidationResponse;

        public InspireValidationResponseParser(XDocument inspireValidationResponse)
        {
            _inspireValidationResponse = inspireValidationResponse;
        }

        public ValidationResult ParseValidationResponse(bool allowSpatialDataThemeError)
        {
            var errors = GetErrors(_inspireValidationResponse);

            var validationResult = new ValidationResult();
            validationResult.Result = ComputeValidationResult(errors, allowSpatialDataThemeError);


            if (!validationResult.IsOk())
                validationResult.Messages = String.Join("\r\n", errors);

            Trace.WriteLine("Validation result=" + validationResult.Result);

            return validationResult;
        }

        private List<string> GetErrors(XDocument xmlDoc)
        {
            List<string> errors = new List<string>();
            var geoPortalExceptions = xmlDoc.Descendants(NsGeo + "ValidationError").Descendants(NsGeo + "GeoportalExceptionMessage");
            foreach (var element in geoPortalExceptions)
            {
                var messageElement = element.Element(NsGeo + "Message");
                if (messageElement != null)
                {
                    var messageValue = messageElement.Value;
                    if (!String.IsNullOrEmpty(messageValue))
                    {
                        errors.Add(messageValue);
                    }
                }
            }
            return errors;
        }
        
        private int ComputeValidationResult(List<string> errors, bool allowSpatialDataThemeError)
        {
            if (errors.Any() && allowSpatialDataThemeError)
            {
                var removeIndex = -1;
                for (var i = 0; i < errors.Count(); i++)
                {
                    var error = errors[i];
                    if (error.Contains("Inspire Spatial Data Theme\" is missing"))
                    {
                        removeIndex = i;
                        break;
                    }
                }
                if (removeIndex != -1)
                {
                    errors.RemoveAt(removeIndex);
                    
                }
                    
            }
            
            return !errors.Any() ? 1 : 0;
        }

    }
}
