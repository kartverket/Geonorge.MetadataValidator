using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kartverket.MetadataMonitor.Models.External.MetadataEditor
{
    // Defined in MetadataEditor
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