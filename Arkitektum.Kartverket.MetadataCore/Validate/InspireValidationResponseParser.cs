using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class InspireValidationResponseParser
    {
        public static XNamespace NsCommon = "http://inspire.ec.europa.eu/schemas/common/1.0";
        public static XNamespace NsGeo = "http://inspire.ec.europa.eu/schemas/geoportal/1.0";
        public static XNamespace NsRdsi = "http://inspire.ec.europa.eu/schemas/rdsi/1.0";

        public ValidationResult ParseValidationResponse(string url, XDocument xmlDoc)
        {
            var result = new ValidationResult(url);
            result.ValidateOk = true;
            return result;
        }
    }
}
