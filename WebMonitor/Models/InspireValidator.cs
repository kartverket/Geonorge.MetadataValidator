using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Arkitektum.GIS.Lib.SerializeUtil;
using www.opengis.net;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class InspireValidator
    {

        private const string ContentTypeXml = "application/xml";
        private const string EndpointUrlGeoNorgeCsw = "http://beta.geonorge.no/geonetwork/srv/eng/csw";
        private readonly HttpRequestExecutor _httpRequestExecutor;

        private InspireValidator(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }

        public InspireValidator() : this(new HttpRequestExecutor()) { }


        public ValidationResult RetrieveAndValidate(string uuid)
        {
            
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);
            string cswRecordResponse = _httpRequestExecutor.PostRequest(EndpointUrlGeoNorgeCsw,
                                                                        ContentTypeXml, ContentTypeXml,
                                                                        getCswRecordRequest);

            /* Quick and dirty hacks to fix exceptions in serialization due to invalid xml */

            Regex fixWrongDecimalInRealElements = new Regex("<gco:Real>([0-9]+),([0-9]+)</gco:Real>");

            var fixedResponse = cswRecordResponse.Replace("<gco:Boolean />", "<gco:Boolean>false</gco:Boolean>")
                .Replace("<gco:Real />", "<gco:Real>0.0</gco:Real>")
                .Replace("<gco:DateTime />", "")
                .Replace("<gmd:MD_TopicCategoryCode />", "");

            var fixedResponse2 = fixWrongDecimalInRealElements.Replace(fixedResponse, "<gco:Real>$1.$2</gco:Real>");


            ValidationResult validationResult = ParseCswRecordResponse(uuid, fixedResponse2);
            if (validationResult.IsResourceTypeApplicableForValidation())
            {
                string inspireValidationResponse = RunInspireValidation(fixedResponse2);

                XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
                return new InspireValidationResponseParser().ParseValidationResponse(validationResult, xmlDoc);    
            } 
            return validationResult;           
        }

        private ValidationResult ParseCswRecordResponse(string uuid, string cswRecordResponse)
        {
    
            GetRecordByIdResponseType getRecordResponse = SerializeUtil.DeserializeFromString<GetRecordByIdResponseType>(cswRecordResponse);

            var title = "unknown";
            var resourceType = "unknown";
            var validateOk = false;
            var organization = "unknown";

            MD_Metadata_Type metadata = getRecordResponse.Items[0] as MD_Metadata_Type;
            if (metadata != null)
            {
                var dataIdentification = metadata.identificationInfo[0].AbstractMD_Identification;
                if (dataIdentification != null)
                {
                    title = dataIdentification.citation.CI_Citation.title.CharacterString;

                    if (dataIdentification.pointOfContact != null
                        && dataIdentification.pointOfContact[0] != null
                        && dataIdentification.pointOfContact[0].CI_ResponsibleParty != null
                        && dataIdentification.pointOfContact[0].CI_ResponsibleParty.organisationName != null
                        && dataIdentification.pointOfContact[0].CI_ResponsibleParty.organisationName.CharacterString != null)
                    {
                        organization = dataIdentification.pointOfContact[0].CI_ResponsibleParty.organisationName.CharacterString;
                    }
                }
    
                if (metadata.hierarchyLevel != null && metadata.hierarchyLevel[0] != null)
                {
                    resourceType = metadata.hierarchyLevel[0].MD_ScopeCode.codeListValue;
                }
            }

            return new ValidationResult(uuid)
                {
                    Title = title, 
                    ErrorMessages = null, 
                    ResourceType = resourceType,
                    ValidateResult = -1,
                    ValidateTimestamp = DateTime.Now,
                    Organization = organization
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