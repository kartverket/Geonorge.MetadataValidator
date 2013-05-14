﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Arkitektum.GIS.Lib.SerializeUtil;
using www.opengis.net;

namespace MetadataDesktopUtil
{
    class MetadataFixer
    {
        private const string ContentTypeXml = "application/xml";

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string _geonetworkEndpoint;
        private readonly HttpRequestExecutor _httpRequestExecutor;
        private Cookie _sessionCookie;

        public MetadataFixer(string geonetworkEndpoint) :this(geonetworkEndpoint, new HttpRequestExecutor()) { }

        public MetadataFixer(string geonetworkEndpoint, HttpRequestExecutor httpRequestExecutor)
        {
            _geonetworkEndpoint = geonetworkEndpoint;
            _httpRequestExecutor = httpRequestExecutor;
        }

        public void FixMetadataEntry(MetadataEntry entry)
        {
            try
            {
                Log.Info("Start fixing of " + entry);
                MD_Metadata_Type metadata = GetMetadataRecord(entry.Uuid);
                if (metadata != null)
                {
                    bool isDirty = AddMissingResourceType(metadata);
                    isDirty |= AddMissingLanguage(metadata);
                    isDirty |= AddMissingConformity(metadata);

                    if (isDirty)
                    {


                        Log.Info("Metadata is dirty, running CSW update transaction now.");

                        TransactionType cswTransaction = new TransactionType
                            {
                                service = "CSW",
                                version = "2.0.2",
                                Items = new object[] {new UpdateType {Items = new object[] {metadata}}}
                            };


                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                        ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                        ns.Add("gmd", "http://www.isotc211.org/2005/gmd");
                        ns.Add("gco", "http://www.isotc211.org/2005/gco");
                        ns.Add("gml", "http://www.opengis.net/gml");
                        ns.Add("gts", "http://www.isotc211.org/2005/gts");

                        string serializedUpdateTransaction = SerializeUtil.SerializeToString(cswTransaction, ns);

                        GeoNetworkAuthenticate();
                        
                        Log.Info("CSW Update Transaction");
                        Log.Debug(serializedUpdateTransaction);

                        string cswUpdateResponse =
                            _httpRequestExecutor.PostRequest(_geonetworkEndpoint + "srv/eng/csw-publication",
                                                             ContentTypeXml,
                                                             ContentTypeXml,
                                                             serializedUpdateTransaction, _sessionCookie);
                        Log.Debug(cswUpdateResponse);

                        Log.Info("Metadata has been updated.");

                    }
                    else
                    {
                        Log.Info("Metadata remains untouched.");
                    }
                }
                else
                {
                    Log.Error("Unable to fetch metadata record for " + entry);
                }
            }
            catch (Exception e)
            {
                Log.Error("Exception while fixing metadata for " + entry, e);
            }
            Log.Info("Finished fixing of " + entry);
        }

        private bool IsDataset(MD_Metadata_Type metadata)
        {
            bool isDataset = false;
            if (metadata.hierarchyLevel != null && metadata.hierarchyLevel.Any())
            {
                var firstElement = metadata.hierarchyLevel[0];
                if (firstElement != null)
                {
                    if (firstElement.MD_ScopeCode != null)
                    {
                        var scopeCode = firstElement.MD_ScopeCode;
                        if (scopeCode.codeListValue == "dataset")
                        {
                            isDataset = true;
                        }
                    }
                }
            }
            return isDataset;
        }

        private bool AddMissingConformity(MD_Metadata_Type metadata)
        {
            bool metadataHasBeenUpdated = false;

            if (IsDataset(metadata) && metadata.dataQualityInfo == null)
            {
                metadata.dataQualityInfo = new[] {
                    new DQ_DataQuality_PropertyType {
                        DQ_DataQuality = new DQ_DataQuality_Type
                        {
                            scope = new DQ_Scope_PropertyType
                                {
                                    DQ_Scope = new DQ_Scope_Type
                                        {
                                            level = new MD_ScopeCode_PropertyType
                                                {
                                                    MD_ScopeCode = new CodeListValue_Type
                                                        {
                                                            codeListValue = "dataset",
                                                            codeList = "http://schemas.opengis.net/iso/19139/20070417/resources/Codelist/gmxCodelists.xml#MD_ScopeCode"
                                                        }
                                                }
                                        }
                                } ,
                            lineage = new LI_Lineage_PropertyType
                            {
                                LI_Lineage = new LI_Lineage_Type
                                    {
                                        statement = new CharacterString_PropertyType { CharacterString = "Ingen prosseshistorie tilgjenglig." }
                                    }
                            },
                            report = new DQ_Element_PropertyType[]
                                { new DQ_Element_PropertyType
                                    {
                                        AbstractDQ_Element = new DQ_DomainConsistency_Type
                                            {
                                                result = new DQ_Result_PropertyType[]{ new DQ_Result_PropertyType
                                                    {
                                                        AbstractDQ_Result = new DQ_ConformanceResult_Type
                                                            {
                                                                explanation = new CharacterString_PropertyType
                                                                    {
                                                                        CharacterString = "See the referenced specification"
                                                                    },
                                                                pass = new Boolean_PropertyType { Boolean = true},
                                                                specification = new CI_Citation_PropertyType
                                                                    {
                                                                        CI_Citation = new CI_Citation_Type
                                                                            {
                                                                                title = new CharacterString_PropertyType
                                                                                    {
                                                                                        CharacterString = "COMMISSION REGULATION (EU) No 1089/2010 of 23 November 2010 implementing Directive 2007/2/EC of the European Parliament and of the Council as regards interoperability of spatial data sets and services"
                                                                                    },
                                                                                    date = new CI_Date_PropertyType[]
                                                                                        {
                                                                                            new CI_Date_PropertyType
                                                                                                {
                                                                                                    CI_Date = new CI_Date_Type
                                                                                                        {
                                                                                                            date = new Date_PropertyType
                                                                                                                {
                                                                                                                    Item = "2010-12-08"
                                                                                                                },
                                                                                                            dateType = new CI_DateTypeCode_PropertyType
                                                                                                                {
                                                                                                                    CI_DateTypeCode = new CodeListValue_Type { codeList = "http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/Codelist/ML_gmxCodelists.xml#CI_DateTypeCode", codeListValue = "publication"}
                                                                                                                }
                                                                                                        }
                                                                                                }
                                                                                        }
                                                                            }
                                                                    }
                                                            }
                                                    } }
                                            }
                                    }
                            }
                        }
                    }
                };

                metadataHasBeenUpdated = true;
            }

            return metadataHasBeenUpdated;
        }

        private void GeoNetworkAuthenticate()
        {
            if (_sessionCookie == null)
            {
                HttpWebResponse logoutResponse =
                    _httpRequestExecutor.FullGetRequest(_geonetworkEndpoint + "srv/eng/xml.user.logout",
                                                        "application/xml", "text/plain");
                Log.Debug("logoutResponse: " + logoutResponse.StatusDescription);

                HttpWebResponse response =
                    _httpRequestExecutor.FullPostRequest(_geonetworkEndpoint + "srv/eng/xml.user.login",
                                                         "application/xml", "application/x-www-form-urlencoded",
                                                         "username=arkitektum&password=geoportal3800");

                Cookie sessionCookie = response.Cookies["JSESSIONID"];
                if (sessionCookie == null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string responseBody = reader.ReadToEnd();

                    response.Close();
                    throw new Exception("Authentication failed - no session cookie available!");
                }

                _sessionCookie = sessionCookie;

                Log.Debug("Authenticated, session cookie: " + _sessionCookie);
            }
            else
            {
                Log.Info("Already authenticated, using existing session cookie: " + _sessionCookie);
            }
        }

        private bool AddMissingLanguage(MD_Metadata_Type metadata)
        {
            bool metadataHasBeenUpdated = false;

            if (metadata.language == null || string.IsNullOrEmpty(metadata.language.CharacterString))
            {
                metadata.language = new CharacterString_PropertyType { CharacterString = "nob"};
                metadataHasBeenUpdated = true;
            } 

            return metadataHasBeenUpdated;
        }

        private bool AddMissingResourceType(MD_Metadata_Type metadata)
        {

            bool metadataHasBeenUpdated = false;

            MD_ScopeCode_PropertyType[] hierarchyLevel = metadata.hierarchyLevel;
            if (hierarchyLevel == null || !hierarchyLevel.Any())
            {
                Log.Info("Missing INSPIRE resource type !!");
                bool isServiceResourceType = false;
                bool isDatasetResourceType = false;
                bool isApplicationResourceType = false;

                MD_Identification_PropertyType[] identificationInfo = metadata.identificationInfo;
                if (identificationInfo != null && identificationInfo[0] != null)
                {
                    foreach (var identification in identificationInfo)
                    {
                        MD_DataIdentification_Type dataIdentification =
                            identification.AbstractMD_Identification as MD_DataIdentification_Type;
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
                                        CharacterString_PropertyType[] characterStringPropertyTypes =
                                            mdKeywordsType.keyword;
                                        if (characterStringPropertyTypes != null)
                                        {
                                            foreach (
                                                CharacterString_PropertyType characterStringPropertyType in
                                                    characterStringPropertyTypes)
                                            {
                                                if (characterStringPropertyType.CharacterString != null)
                                                {
                                                    var currentKeywordValue = characterStringPropertyType.CharacterString.Trim();
                                                    if (currentKeywordValue.Equals("ND_TJ", StringComparison.OrdinalIgnoreCase)
                                                        || currentKeywordValue.Equals("ND_WCS", StringComparison.OrdinalIgnoreCase)
                                                        || currentKeywordValue.Equals("ND_CA", StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        isServiceResourceType = true;
                                                        break;
                                                    }

                                                    if (currentKeywordValue.Equals("ND_AP", StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        isApplicationResourceType = true;
                                                        break;
                                                    }

                                                    if (currentKeywordValue.Equals("ND_DS",
                                                                                   StringComparison.OrdinalIgnoreCase)
                                                        ||
                                                        currentKeywordValue.Equals("ND_DS (theme)",
                                                                                   StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        isDatasetResourceType = true;
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

                if (isServiceResourceType || isDatasetResourceType || isApplicationResourceType)
                {
                    metadataHasBeenUpdated = true;

                    var codeListValue = "service";
                    if (isDatasetResourceType) codeListValue = "dataset";
                    if (isApplicationResourceType) codeListValue = "software";

                    Log.Info("Adding resource type " + codeListValue + " to metadata entry.");

                    metadata.hierarchyLevel = new[]
                        {
                            new MD_ScopeCode_PropertyType
                                {
                                    MD_ScopeCode = new CodeListValue_Type
                                        {
                                            codeList =
                                                "http://schemas.opengis.net/iso/19139/20070417/resources/Codelist/gmxCodelists.xml#MD_ScopeCode",
                                            codeListValue = codeListValue
                                        }
                                }
                        };

                    if (!isDatasetResourceType)
                    {
                        // geonetwork validation want this field when hierarchyLevel is not 'dataset'
                        metadata.hierarchyLevelName = new[]
                            {new CharacterString_PropertyType {CharacterString = codeListValue}};
                    }
                }
                else
                {
                    Log.Info("Unable to determine resource type.");
                }
            }

            return metadataHasBeenUpdated;
        }


        private MD_Metadata_Type GetMetadataRecord(string uuid)
        {
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);
            string cswRecordResponse = _httpRequestExecutor.PostRequest(_geonetworkEndpoint + "srv/eng/csw",
                                                                        ContentTypeXml, ContentTypeXml,
                                                                        getCswRecordRequest);

            //Log.Debug("CSW GetRecordByIdResponse: " + cswRecordResponse);
            try
            {
                /* Quick and dirty hacks to fix exceptions in serialization due to invalid xml */

                Regex fixWrongDecimalInRealElements = new Regex("<gco:Real>([0-9]+),([0-9]+)</gco:Real>");

                var fixedResponse = cswRecordResponse.Replace("<gco:Boolean />", "<gco:Boolean>false</gco:Boolean>")
                    .Replace("<gco:Real />", "<gco:Real>0.0</gco:Real>")
                    .Replace("<gco:DateTime />", "");

                var fixedResponse2 = fixWrongDecimalInRealElements.Replace(fixedResponse, "<gco:Real>$1.$2</gco:Real>");

                GetRecordByIdResponseType response =
                SerializeUtil.DeserializeFromString<GetRecordByIdResponseType>(fixedResponse2);
                
                return (MD_Metadata_Type)response.Items[0];
            }
            catch (Exception e)
            {
                Log.Error("Exception while serializing xml: " + e.Message, e);
            }
            return null;
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
