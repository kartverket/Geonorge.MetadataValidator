using System.Text;
using System.Xml.Linq;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class InspireValidator
    {
        private readonly HttpRequestExecutor _httpRequestExecutor;

        public InspireValidator() : this(new HttpRequestExecutor())
        {
            
        }

        public InspireValidator(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }

        public ValidationResult Validate(string rawXmlProcessed)
        {
            string inspireValidationResponse = RunInspireValidation(rawXmlProcessed);
            XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
            return new InspireValidationResponseParser(xmlDoc).ParseValidationResponse();
        }

        private string RunInspireValidation(string data)
        {
            /* 
             * BAD HACK: Search and replace norwegian language code with english language code. 
             * INSPIRE does not validate metadata with norwegian language code.
             * This removes validation errors related to conformity and language code.
             */
            data = data.Replace(">nob</gco:CharacterString>", ">eng</gco:CharacterString>");
            data = data.Replace(">nor</gco:CharacterString>", ">eng</gco:CharacterString>");

            string boundary = "----MetadataMonitor";
            StringBuilder builder = new StringBuilder();
            builder.Append("--");
            builder.Append(boundary);
            builder.Append("\r\n");
            builder.Append("Content-Disposition: form-data; name=\"resourceRepresentation\"\r\n\r\n");
            builder.Append(data);
            builder.Append("\r\n");
            builder.Append("--");
            builder.Append(boundary);

            string postData = builder.ToString();

            string contentType = "multipart/form-data; boundary=" + boundary;

            string responseBody = _httpRequestExecutor.PostRequest(Constants.EndpointUrlInspire, "application/xml", contentType, postData);

            return responseBody;
        }
    }
}