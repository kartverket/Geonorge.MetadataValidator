using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Kartverket.MetadataMonitor.Models.External.MetadataEditor
{
    // Defined in MetadataEditor
    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/Kartverket.MetadataEditor.Models", ElementName = "MetaDataEntry")]
    public class MetadataEntry
    {
        public string Uuid { get; set; }
        public string Title { get; set; }
        public string OrganizationName { get; set; }
        public string ContactEmail { get; set; }
        public string Status { get; set; }
        public List<Error> Errors { get; set; }
    }
}