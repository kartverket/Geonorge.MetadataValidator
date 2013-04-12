using System.Linq;
using System.Text;
using System.Xml.Linq;
using Arkitektum.CSW;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class InspireValidator
    {

        private const string ContentTypeXml = "application/xml";

        private readonly HttpRequestExecutor _httpRequestExecutor;

        private InspireValidator(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }

        public InspireValidator() : this(new HttpRequestExecutor()) { }


        public ValidationResult RetrieveAndValidate(string uuid)
        {
            
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);
            string cswRecordResponse = _httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw,
                                                                        ContentTypeXml, ContentTypeXml,
                                                                        getCswRecordRequest);

            ValidationResult validationResult = ParseCswRecordResponse(uuid, cswRecordResponse);
            string inspireValidationResponse = RunInspireValidation(cswRecordResponse);

            XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
            return new InspireValidationResponseParser().ParseValidationResponse(validationResult, xmlDoc);
        }

        private ValidationResult ParseCswRecordResponse(string uuid, string cswRecordResponse)
        {
            XDocument cswRecord = XDocument.Parse(cswRecordResponse);

            XNamespace gmd = "http://www.isotc211.org/2005/gmd";
            XNamespace gco = "http://www.isotc211.org/2005/gco";

            var metadataStandard = "ISO 19139";
            var title = "unknown";
            var url = "";

            var metadataStandardElement = cswRecord.Descendants(gmd + "metadataStandardName");
            if (metadataStandardElement.Any())
            {
                var metadataFirstElement = cswRecord.Descendants(gmd + "metadataStandardName").First();
                if (metadataFirstElement != null)
                {
                    var content = metadataFirstElement.Element(gco + "CharacterString");
                    if (content != null) { metadataStandard = content.Value; }
                }
    
            }
            var titleElement = cswRecord.Descendants(gmd + "title");
            if (titleElement.Any())
            {
                var titleFirstElement = titleElement.First();
                if (titleFirstElement != null)
                {
                    var content = titleFirstElement.Element(gco + "CharacterString");
                    if (content != null)
                    {
                        title = content.Value;
                    }
                }
            }
            var urlElement = cswRecord.Descendants(gmd + "URL");
            if (urlElement.Any())
            {
                var urlFirstElement = urlElement.First();
                if (urlFirstElement != null)
                {
                    url = urlFirstElement.Value;
                }
            }

            return new ValidationResult(uuid) { Title = title, Url = url, MetadataStandardName = metadataStandard };
        }

        private static string CreateGetCswRecordRequest(string uuid)
        {
            GetRecordByIdType getRecordbyId = new GetRecordByIdType();
            getRecordbyId.service = "CSW";
            getRecordbyId.version = "2.0.2";
            getRecordbyId.outputSchema = "csw:IsoRecord";
            getRecordbyId.Id = new[] { uuid };
            getRecordbyId.ElementSetName = new ElementSetNameType { Value = ElementSetType.full };

            return SerializeUtil.SerializeToString(getRecordbyId);
        }
        
        private string RunInspireValidation(string data)
        {
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