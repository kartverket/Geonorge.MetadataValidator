using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class InspireValidationResponseParser
    {
        public static readonly XNamespace NsCommon = "http://inspire.ec.europa.eu/schemas/common/1.0";
        public static readonly XNamespace NsGeo = "http://inspire.ec.europa.eu/schemas/geoportal/1.0";
        public static readonly XNamespace NsRdsi = "http://inspire.ec.europa.eu/schemas/rdsi/1.0";

        public ValidationResult ParseValidationResponse(string uuid, string url, XDocument xmlDoc)
        {
            var result = new ValidationResult(uuid);
            result.Url = url;
            result.ValidateTimestamp = DateTime.Now;

            var errors = GetErrors(xmlDoc);

            result.ValidateOk = !errors.Any();

            if (!result.ValidateOk)
                result.ErrorMessages = String.Join("\r\n", errors);
            
            Trace.WriteLine("Validation result=" + result.ValidateOk);

            return result;
        }

        private IEnumerable<string> GetErrors(XDocument xmlDoc)
        {
            List<string> errors = new List<string>();
            var elements = xmlDoc.Descendants(NsGeo + "ValidationError").Descendants(NsGeo + "GeoportalExceptionMessage");
            foreach (var element in elements)
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
