using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class DashboardViewModel
    {
        public int totalResultCount { get; set; }
        public int totalResultOk { get; set; }
        public int totalResultFailed { get; set; }
        public int totalMetadata19139 { get; set; }
        public int totalMetadata19115{ get; set; }
        public int totalMetadataOther { get; set; }

    }
}