namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class DashboardViewModel
    {
        public int TotalResultCount { get; set; }
        public int TotalResultOk { get; set; }
        public int TotalResultFailed { get; set; }
        public int TotalMetadata19139 { get; set; }
        public int TotalMetadata19115{ get; set; }
        public int TotalMetadataOther { get; set; }

        public int ErrorUnknownResourceType { get; set; }
        public int ErrorNotSupportedResourceType { get; set; }
        public int ErrorMissingSpatialDataTheme { get; set; }
        public int ErrorMissingConditionsForAccess { get; set; }
        public int ErrorMissingResponsibleOrganisation { get; set; }
        public int ErrorMissingLanguage { get; set; }
        public int ErrorMissingResourceIdentifier { get; set; }
        public int ErrorMissingLineage { get; set; }
        public int ErrorMissingConformity { get; set; }
    }
}