using Arkitektum.GIS.Lib.SerializeUtil;
using System.Web.Configuration;
using www.opengis.net;
using Kartverket.MetadataMonitor.Models.External.MetadataEditor;
using System;

namespace Kartverket.MetadataMonitor.Models
{
    public class NorgeDigitaltValidator
    {
        private const string ContentTypeXml = "application/xml";
        private const string ResourceTypeSoftware = "software";

        private static readonly string EndpointValidatorInMetadataEditor = WebConfigurationManager.AppSettings["EndpointValidatorInMetadataEditor"];
        private readonly HttpRequestExecutor _httpRequestExecutor = new HttpRequestExecutor();

        public ValidationResult Validate(MetadataEntry metadataEntry, MD_Metadata_Type metadata, string rawXmlProcessed)
        {
            ValidationResult validationResult = new ValidationResult();
            
            if (metadataEntry.HasResourceType(ResourceTypeSoftware))
            {
                CheckDistributionUrl(metadata, validationResult);
            }
            else
            {
                string response = _httpRequestExecutor.GetRequest(EndpointValidatorInMetadataEditor + metadataEntry.Uuid, ContentTypeXml, ContentTypeXml);

                if (!string.IsNullOrWhiteSpace(response))
                {
                    External.MetadataEditor.MetadataEntry externalMetadataEntry = SerializeUtil.DeserializeFromString<External.MetadataEditor.MetadataEntry>(response);

                    validationResult.Initialize(externalMetadataEntry);
                    validationResult.Timestamp = DateTime.Now;
                }
            }
            return validationResult;
        }

        private static void CheckDistributionUrl(MD_Metadata_Type metadata, ValidationResult validationResult)
        {
            if (metadata.distributionInfo != null
                && metadata.distributionInfo.MD_Distribution != null
                && metadata.distributionInfo.MD_Distribution.transferOptions != null
                && metadata.distributionInfo.MD_Distribution.transferOptions[0] != null
                && metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions != null
                && metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions.onLine != null
                && metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions.onLine[0] != null
                &&
                metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions.onLine[0]
                    .CI_OnlineResource != null
                &&
                metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions.onLine[0]
                    .CI_OnlineResource.linkage != null
                &&
                metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions.onLine[0]
                    .CI_OnlineResource.linkage.URL != null)
            {
                string url =
                    metadata.distributionInfo.MD_Distribution.transferOptions[0].MD_DigitalTransferOptions.onLine[0]
                        .CI_OnlineResource.linkage.URL;
                if (url.Trim().Length > 1)
                {
                    validationResult.Status = ValidationStatus.Valid;
                }
                else
                {
                    validationResult.Status = ValidationStatus.Invalid;
                    validationResult.Messages = "Empty URL in distributionInfo.";
                }
            }
            else
            {
                validationResult.Status = ValidationStatus.Invalid;
                validationResult.Messages = "Missing URL in distributionInfo.";
            }
            validationResult.Timestamp = DateTime.Now;
        }
    }
}