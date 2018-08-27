using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Configuration;
using System.Xml.Linq;

namespace Kartverket.MetadataMonitor.Models
{
    public class InspireValidationResponseParser
    {
        private const string XmlCompletenessIndicator = "CompletenessIndicator";
        private const string XmlInteroperabilityIndicator = "InteroperabilityIndicator";
        private const string XmlMetadataLocator = "GeoportalMetadataLocator";
        private const string XmlReportUrl = "URL";

        private static readonly string InspireResourceUrl = $"{WebConfigurationManager.AppSettings["InspireUrl"]}{WebConfigurationManager.AppSettings["InsprireValidationStatusEndpoint"]}";

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static readonly XNamespace NsCommon = "http://inspire.ec.europa.eu/schemas/common/1.0";
        public static readonly XNamespace NsGeo = "http://inspire.ec.europa.eu/schemas/geoportal/1.0";
        public static readonly XNamespace NsRdsi = "http://inspire.ec.europa.eu/schemas/rdsi/1.0";

        private readonly XDocument _inspireValidationResponse;

        public InspireValidationResponseParser(XDocument inspireValidationResponse)
        {
            _inspireValidationResponse = inspireValidationResponse;
        }

        internal ValidationResult ParseValidationResponseWithCompletenessIndicator()
        {
            var errors = GetErrors(_inspireValidationResponse);
            var validationResult = new ValidationResult();
            validationResult.InspireResource = true;
            validationResult.InteroperabilityIndicator = GetIndicator(XmlInteroperabilityIndicator);
            validationResult.CompletenessIndicator = GetIndicator(XmlCompletenessIndicator);
            validationResult.Status = ComputeValidationResultFromCompletenessIndicator(validationResult.CompletenessIndicator);
            validationResult.Messages = String.Join("\r\n", errors);
            validationResult.ReportUrl = GetReportUrl();

            return validationResult;
        }

        private string GetReportUrl()
        {
            string url = "";

            XElement element = _inspireValidationResponse.Descendants(NsGeo + XmlMetadataLocator).FirstOrDefault().Descendants(NsCommon + XmlReportUrl).FirstOrDefault();
            
            if (element != null)
            {
                url = $"{InspireResourceUrl}{element.Value}";
            }
            return url;
        }

        private double GetIndicator(string indicatorName)
        {
            double indicator = ValidationResult.UndefinedIndicator;

            XElement element = _inspireValidationResponse.Descendants(NsGeo + indicatorName).FirstOrDefault();

            if (element != null)
            {
                double.TryParse(element.Value, NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"), out indicator);
                Log.Debug($"{indicatorName}: " + indicator);
            }

            return indicator;
        }

        private ValidationStatus ComputeValidationResultFromCompletenessIndicator(double completenessIndicator)
        {
            ValidationStatus result = ValidationStatus.Invalid;

            if ((int)completenessIndicator == 100)
            {
                result = ValidationStatus.Valid;
            }

            return result;
        }

        public ValidationResult ParseValidationResponse(bool allowSpatialDataThemeError, bool allowConformityError)
        {
            var errors = GetErrors(_inspireValidationResponse);

            var validationResult = new ValidationResult();
            validationResult.Status = ComputeValidationResult(errors, allowSpatialDataThemeError, allowConformityError);


            if (validationResult.Status != ValidationStatus.Valid)
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

        private ValidationStatus ComputeValidationResult(List<string> errors, bool allowSpatialDataThemeError, bool allowConformityError)
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
            return !errors.Any() ? ValidationStatus.Valid : ValidationStatus.Invalid;
        }
    }
}
