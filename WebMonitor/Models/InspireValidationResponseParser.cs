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

        public ValidationResult ParseValidationResponse(bool allowSpatialDataThemeError, bool allowConformityError)
        {
            var errors = GetErrors(_inspireValidationResponse);

            var validationResult = new ValidationResult();
            validationResult.Result = ComputeValidationResult(errors, allowSpatialDataThemeError, allowConformityError);


            if (!validationResult.IsOk())
                validationResult.Messages = String.Join("\r\n", errors);

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
        
        private int ComputeValidationResult(List<string> errors, bool allowSpatialDataThemeError, bool allowConformityError)
        {
            if (errors.Any() && (allowSpatialDataThemeError || allowConformityError))
            {
                for (var i = errors.Count - 1; i >= 0; i--) // loop backwards to allow removal of items while iterating
                {
                    if (allowSpatialDataThemeError && errors[i].Contains("Inspire Spatial Data Theme\" is missing"))
                    {
                        errors.RemoveAt(i);
                    } else if (allowConformityError && errors[i].Contains("Conformity\" is missing")) {
                        errors.RemoveAt(i);
                    }
                }
            }
            return !errors.Any() ? 1 : 0;
        }

    }
}
