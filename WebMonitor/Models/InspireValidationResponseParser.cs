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

        private readonly ValidationResult _validationResult;
        private readonly XDocument _inspireValidationResponse;
        private List<string> _errors; 

        public InspireValidationResponseParser(ValidationResult validationResult, XDocument inspireValidationResponse)
        {
            _validationResult = validationResult;
            _inspireValidationResponse = inspireValidationResponse;
        }

        public ValidationResult ParseValidationResponse()
        {
            _validationResult.ValidateTimestamp = DateTime.Now;

            _errors = GetErrors(_inspireValidationResponse);

            _validationResult.ValidateResult = ComputeValidationResult();

            if (!_validationResult.IsOk())
                _validationResult.ErrorMessages = String.Join("\r\n", _errors);

            Trace.WriteLine("Validation result=" + _validationResult.ValidateResult);

            return _validationResult;
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
        
        private int ComputeValidationResult()
        {
            if (_validationResult.InspireExemption)
            {
                if (_errors.Any())
                {
                    var removeIndex = -1;
                    for (var i = 0; i < _errors.Count(); i++)
                    {
                        var error = _errors[i];
                        if (error.Contains("Inspire Spatial Data Theme\" is missing"))
                        {
                            removeIndex = i;
                        }
                    }
                    if (removeIndex != -1)
                        _errors.RemoveAt(removeIndex);
                }
            }
            return !_errors.Any() ? 1 : 2;
        }

    }
}
