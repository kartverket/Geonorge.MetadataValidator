using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Arkitektum.GIS.Lib.SerializeUtil;
using www.opengis.net;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class MetadataValidator
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private const string ContentTypeXml = "application/xml";
        private readonly HttpRequestExecutor _httpRequestExecutor;

        private MetadataValidator(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }

        public MetadataValidator() : this(new HttpRequestExecutor()) { }


        public MetadataEntry RetrieveAndValidate(string uuid)
        {
            MetadataEntry metadataEntry = null;
            try
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

                var rawXmlProcessed = fixWrongDecimalInRealElements.Replace(fixedResponse, "<gco:Real>$1.$2</gco:Real>");

                GetRecordByIdResponseType getRecordResponse = SerializeUtil.DeserializeFromString<GetRecordByIdResponseType>(rawXmlProcessed);
                MD_Metadata_Type metadata = getRecordResponse.Items[0] as MD_Metadata_Type;

                metadataEntry = ParseCswRecordResponse(uuid, metadata);
                ValidationResult validationResult;
                if (metadataEntry.ResourceType == "unknown")
                {
                    validationResult = new ValidationResult
                        {
                            Messages = "Unknown resource type, please check value of hierarchyLevel element.",
                            Result = -1,
                            Timestamp = DateTime.Now
                        };
                }
                else
                {
                    if (metadataEntry.InspireResource)
                    {
                        validationResult = new InspireValidator(_httpRequestExecutor).Validate(rawXmlProcessed);
                    }
                    else
                    {
                        validationResult = new NorgeDigitaltValidator().Validate(metadataEntry, metadata, rawXmlProcessed);
                    }
                }
                metadataEntry.ValidationResults.Add(validationResult);
            }
            catch (Exception e)
            {
                metadataEntry = ParseCswRecordResponse(uuid, null);

                string message = e.Message;
                if (e.InnerException != null)
                    message += e.InnerException.Message;

                metadataEntry.ValidationResults.Add(new ValidationResult { Messages="Exception during validation: " + message, Result = -1, Timestamp = DateTime.Now });
                Log.Error("Exception occured for uuid=" + uuid + ", not validated. " + message);
            }
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
        
        


    }
}