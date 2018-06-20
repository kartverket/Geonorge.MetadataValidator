using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kartverket.MetadataMonitor.Models.External.Inspire
{
    public class SearchResult
    {
        public class ResponseType
        {
            public class Document
            {
                [JsonProperty("id")]
                public string Id { get; set; }
            }

            [JsonProperty("docs")]
            public List<Document> Documents { get; set; }
        }

        [JsonProperty("response")]
        public ResponseType Response { get; set; }
    }
}