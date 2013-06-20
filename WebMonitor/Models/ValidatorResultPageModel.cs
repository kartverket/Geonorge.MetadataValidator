using System.Collections.Generic;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidatorResultPageModel
    {
        public string Organization { get; set; }
        public int? Status { get; set; }
        public List<ValidationResultModel> ValidationResults { get; set; }

        public IEnumerable<string> Organizations { get; set; }
    }
}