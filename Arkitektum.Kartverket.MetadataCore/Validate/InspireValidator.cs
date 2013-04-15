using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Arkitektum.CSW;
using www.ogc.net.csw;

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
            if (validationResult.ValidateOk)
            {
                string inspireValidationResponse = RunInspireValidation(cswRecordResponse);

                XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
                return new InspireValidationResponseParser().ParseValidationResponse(validationResult, xmlDoc);    
            } else
            {
                return validationResult;
            }
            
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

            XNamespace ows = "http://www.opengis.net/ows";

            List<string> errors = new List<string>();
            var owsExceptions = cswRecord.Descendants(ows + "Exception");
            foreach (var owsException in owsExceptions)
            {
                var exceptionText = owsException.Value;
                if (!string.IsNullOrEmpty(exceptionText))
                {
                    errors.Add(exceptionText);
                }
            }
            string errorsMessages = String.Join("\r\n", errors);
            bool validateOk = !errors.Any();
            return new ValidationResult(uuid)
                {
                    Title = title, 
                    Url = url, 
                    MetadataStandardName = metadataStandard, 
                    ErrorMessages = errorsMessages, 
                    ValidateOk = validateOk,
                    ValidateTimestamp = DateTime.Now
                };
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