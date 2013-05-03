using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Arkitektum.GIS.Lib.SerializeUtil;
using Arkitektum.Kartverket.MetadataCore.Validate;
using www.isotc211.org.gmd;
using www.ogc.net.csw;

namespace MetadataDesktopUtil
{
    class MetadataFixer
    {
        private const string ContentTypeXml = "application/xml";

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string _cswEndpoint;
        private readonly HttpRequestExecutor _httpRequestExecutor;

        public MetadataFixer(string cswEndpoint) :this(cswEndpoint, new HttpRequestExecutor()) { }

        public MetadataFixer(string cswEndpoint, HttpRequestExecutor httpRequestExecutor)
        {
            _cswEndpoint = cswEndpoint;
            _httpRequestExecutor = httpRequestExecutor;
        }

        public void FixMetadataEntry(MetadataEntry entry)
        {
            Log.Info("Start fixing of " + entry);
            MD_Metadata_Type metadata = GetMetadataRecord(entry.Uuid);

            bool isDirty = false;

            MD_ScopeCode_PropertyType[] hierarchyLevel = metadata.hierarchyLevel;
            if (hierarchyLevel == null || !hierarchyLevel.Any())
            {
                Log.Info("Missing INSPIRE resource type !!");
                isDirty = AddMissingResourceType(metadata);
            }
            if (isDirty)
            {
                Log.Info("Metadata has been updated.");
                string updatedMetadata = SerializeUtil.SerializeToString(metadata);

                // TODO run CSW Transaction Update here!

                //Log.Debug(updatedMetadata);
                /*
                XDocument doc = XDocument.Parse(updatedMetadata);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(doc.CreateReader());
                
                
                TransactionType cswTransaction = new TransactionType
                    {
                        service = "CSW", version = "2.0.2",
                        Items = new[] { new UpdateType { Items = new[] {xmlDoc.FirstChild } } }
                    };

                Log.Debug(SerializeUtil.SerializeToString(cswTransaction));
                 */
            }



            
        }

        private bool AddMissingResourceType(MD_Metadata_Type metadata)
        {

            bool metadataHasBeenUpdated = false;

            bool isServiceResourceType = false;

            MD_Identification_PropertyType[] identificationInfo = metadata.identificationInfo;
            if (identificationInfo != null && identificationInfo[0] != null)
            {
                foreach (var identification in identificationInfo)
                {
                    MD_DataIdentification_Type dataIdentification = identification.AbstractMD_Identification as MD_DataIdentification_Type;
                    if (dataIdentification != null)
                    {
                        MD_Keywords_PropertyType[] descriptiveKeywords = dataIdentification.descriptiveKeywords;
                        if (descriptiveKeywords != null)
                        {
                            foreach (MD_Keywords_PropertyType descriptiveKeyword in descriptiveKeywords)
                            {
                                MD_Keywords_Type mdKeywordsType = descriptiveKeyword.MD_Keywords;
                                if (mdKeywordsType != null)
                                {
                                    CharacterString_PropertyType[] characterStringPropertyTypes = mdKeywordsType.keyword;
                                    if (characterStringPropertyTypes != null)
                                    {
                                        foreach (CharacterString_PropertyType characterStringPropertyType in characterStringPropertyTypes)
                                        {
                                            if (characterStringPropertyType.CharacterString != null)
                                            {
                                                if (characterStringPropertyType.CharacterString.Equals("ND_TJ",
                                                                                                       StringComparison
                                                                                                           .OrdinalIgnoreCase))
                                                {
                                                    isServiceResourceType = true;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (isServiceResourceType)
            {
                metadataHasBeenUpdated = true;

                metadata.hierarchyLevel = new[] { new MD_ScopeCode_PropertyType
                    {
                        MD_ScopeCode = new CodeListValue_Type
                            {
                                codeList = "http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/codelist/ML_gmxCodelists.xml#MD_ScopeCode",
                                codeListValue = "service"
                            }
                    } 
                };

            }


            return metadataHasBeenUpdated;
        }

        private MD_Metadata_Type GetMetadataRecord(string uuid)
        {
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);
            string cswRecordResponse = _httpRequestExecutor.PostRequest(_cswEndpoint, ContentTypeXml, ContentTypeXml,
                                                                        getCswRecordRequest);
            
            Log.Debug("CSW GetRecordByIdResponse: " + cswRecordResponse);
            
            GetRecordByIdResponseType response =
                SerializeUtil.DeserializeFromString<GetRecordByIdResponseType>(cswRecordResponse);

            XmlElement element = (XmlElement) response.Items[0];
            MD_Metadata_Type metadataType = SerializeUtil.DeserializeFromString<MD_Metadata_Type>(element.OuterXml);
            return metadataType;
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
