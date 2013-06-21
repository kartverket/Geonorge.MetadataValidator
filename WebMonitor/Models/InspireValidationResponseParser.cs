﻿using System;
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

        public ValidationResult ParseValidationResponse(ValidationResult validationResult, XDocument xmlDoc)
        {
            validationResult.ValidateTimestamp = DateTime.Now;

            var errors = GetErrors(xmlDoc);

            validationResult.ValidateResult = !errors.Any() ? 1 : 2;

            if (!validationResult.IsOk())
                validationResult.ErrorMessages = String.Join("\r\n", errors);

            Trace.WriteLine("Validation result=" + validationResult.ValidateResult);

            return validationResult;
        }

        private IEnumerable<string> GetErrors(XDocument xmlDoc)
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
    }
}