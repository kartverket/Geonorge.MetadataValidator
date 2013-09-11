using System;
using System.Collections.Generic;
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
        private readonly HttpRequestExecutor _httpRequestExecutor;

        private InspireValidator(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }

        public InspireValidator() : this(new HttpRequestExecutor()) { }


        public MetadataEntry RetrieveAndValidate(string uuid)
        {
            
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);
            string cswRecordResponse = _httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw,
                                                                        ContentTypeXml, ContentTypeXml,
                                                                        getCswRecordRequest);

            /* Quick and dirty hacks to fix exceptions in serialization due to invalid xml */

            Regex fixWrongDecimalInRealElements = new Regex("<gco:Real>([0-9]+),([0-9]+)</gco:Real>");

            var fixedResponse = cswRecordResponse.Replace("<gco:Boolean />", "<gco:Boolean>false</gco:Boolean>")
                .Replace("<gco:Real />", "<gco:Real>0.0</gco:Real>")
                .Replace("<gco:DateTime />", "")
                .Replace("<gmd:MD_TopicCategoryCode />", "");

            var fixedResponse2 = fixWrongDecimalInRealElements.Replace(fixedResponse, "<gco:Real>$1.$2</gco:Real>");


            GetRecordByIdResponseType getRecordResponse = SerializeUtil.DeserializeFromString<GetRecordByIdResponseType>(fixedResponse2);
            MD_Metadata_Type metadata = getRecordResponse.Items[0] as MD_Metadata_Type;

            MetadataEntry metadataEntry = ParseCswRecordResponse(uuid, metadata);
            ValidationResult validationResult;
            if (metadataEntry.InspireResource)
            {
                string inspireValidationResponse = RunInspireValidation(fixedResponse2);
                XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
                validationResult = new InspireValidationResponseParser(xmlDoc).ParseValidationResponse();
            }
            else
            {
                validationResult = new NorgeDigitaltValidator().Validate(metadataEntry, metadata);
            }
            metadataEntry.ValidationResults.Add(validationResult);

            return metadataEntry;
        }

        private MetadataEntry ParseCswRecordResponse(string uuid, MD_Metadata_Type metadata)
        {
            var title = "unknown";
            var resourceType = "unknown";
            var organization = "unknown";
            var inspireResource = true;
            
            if (metadata != null)
            {
                if (metadata.hierarchyLevel != null && metadata.hierarchyLevel[0] != null)
                {
                    resourceType = metadata.hierarchyLevel[0].MD_ScopeCode.codeListValue;
                }

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
                        var tmpOrganization = dataIdentification.pointOfContact[0].CI_ResponsibleParty.organisationName.CharacterString;
                        if (!string.IsNullOrWhiteSpace(tmpOrganization))
                        {
                            organization = tmpOrganization;
                        }
                    }

                    if (dataIdentification.descriptiveKeywords != null)
                    {
                        foreach (var descriptiveKeyword in dataIdentification.descriptiveKeywords)
                        {
                            if (descriptiveKeyword.MD_Keywords != null && descriptiveKeyword.MD_Keywords.keyword != null)
                            {
                                foreach (var singleKeyword in descriptiveKeyword.MD_Keywords.keyword)
                                {
                                    if (singleKeyword.CharacterString != null)
                                    {
                                        if (singleKeyword.CharacterString.Equals("annet", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            inspireResource = false;
                                            break;
                                        }
                                    }
                                }
                                if (!inspireResource) 
                                    break;
                            }
                        }
                    }
                        
                }
    
                
            }

            if (inspireResource)
            {
                inspireResource = IsApplicableForInspireValidation(resourceType);
            }

            return new MetadataEntry()
                {
                    Uuid = uuid,
                    Title = title, 
                    ResourceType = resourceType,
                    ResponsibleOrganization = organization,
                    InspireResource = inspireResource,
                    ValidationResults = new List<ValidationResult>()
                };
        }

        private bool IsApplicableForInspireValidation(string resourceType)
        {
            // ReSharper disable ReplaceWithSingleAssignment.False
            bool result = false;
            if (resourceType != null && (resourceType == "dataset" || resourceType == "service" || resourceType == "series"))
            {
                result = true;
            }
            // ReSharper restore ReplaceWithSingleAssignment.False
            return result;
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