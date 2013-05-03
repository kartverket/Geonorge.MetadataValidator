using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Arkitektum.GIS.Lib.SerializeUtil;
using Arkitektum.Kartverket.MetadataCore.Validate;
using www.ogc.net.csw;

namespace MetadataDesktopUtil
{
    public class MetadataFixerService
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string _cswEndpoint;
        private readonly HttpRequestExecutor _httpRequestExecutor;
        private readonly MetadataFixer _metadataFixer;

        private MetadataFixerService(string cswEndpoint, HttpRequestExecutor httpRequestExecutor, MetadataFixer metadataFixer)
        {
            _cswEndpoint = cswEndpoint;
            _httpRequestExecutor = httpRequestExecutor;
            _metadataFixer = metadataFixer;
        }

        public MetadataFixerService(string cswEndpoint) : this(cswEndpoint, new HttpRequestExecutor(), new MetadataFixer(cswEndpoint)) { }
        
        public void SearchForAllEntries()
        {
            Log.Info("Start CSW-search");

            GetRecordsResponseType firstSearchResponse = RunSearch();

            var searchResults = firstSearchResponse.SearchResults;

            List<MetadataEntry> entries = ParseSearchResults(searchResults);

            _metadataFixer.FixMetadataEntry(entries[0]);
           // entries.ForEach(_metadataFixer.FixMetadataEntry);
            



           /* 
            int counter = 0;
            int max = int.Parse(searchResults.numberOfRecordsMatched);
            int next = int.Parse(searchResults.nextRecord);
            while (next < max)
            {
                Trace.WriteLine("----------Counter=" + counter);

                max = int.Parse(searchResults.numberOfRecordsMatched);
                next = int.Parse(searchResults.nextRecord);
                int numberOfRecordsReturned = int.Parse(searchResults.numberOfRecordsReturned);
                counter += numberOfRecordsReturned;
                
                if (numberOfRecordsReturned < 0) break;
             
                var response = RunSearch(next);
                searchResults = response.SearchResults;
                ParseSearchResults(searchResults);
            }
            * */
        }


        private static List<MetadataEntry> ParseSearchResults(SearchResultsType searchResults)
        {
            List<MetadataEntry> results = new List<MetadataEntry>();

            Log.Debug("-------Looping search results-----");
            foreach (var item in searchResults.Items)
            {
                SummaryRecordType summary = (SummaryRecordType) item;

                var title = summary.title[0].Text[0];
                var uuid = summary.identifier[0].Text[0];

                Log.Debug("[UUID=" + uuid + "], [Title=" + title + "]");

                results.Add(new MetadataEntry {Title = title, Uuid = uuid});
            }
            Log.Info("Search returned " + results.Count + " entries.");
            return results;
        }
        

        private GetRecordsResponseType RunSearch(int startPosition)
        {
            Trace.WriteLine("Running search with start position: " + startPosition);
            string responseBody = _httpRequestExecutor.PostRequest(_cswEndpoint, "application/xml", "application/xml",
                                            CreateRequestBody(startPosition));


            return SerializeUtil.DeserializeFromString<GetRecordsResponseType>(responseBody);
        }

        private GetRecordsResponseType RunSearch()
        {
            return RunSearch(1);
        }

        private string CreateRequestBody(int startPosition)
        {

            var getRecords = new GetRecordsType();

            getRecords.resultType = ResultType.results;
            getRecords.startPosition = startPosition.ToString(CultureInfo.InvariantCulture);

            var query = new QueryType();
         /*   query.typeNames = new[]
                {
                    //new XmlQualifiedName("csw:Record", "http://www.opengis.net/cat/csw/2.0.2")
                    new XmlQualifiedName("csw:Record")
                };
           */ 
            var queryConstraint = new QueryConstraintType();
            queryConstraint.version = "1.1.0";
            queryConstraint.Item = new FilterType(); // using empty filter to get all records
            query.Constraint = queryConstraint;

            getRecords.Item = query;

            return SerializeUtil.SerializeToString(getRecords);
        }

    }
}

public class MetadataEntry
{
    public string Title { get; set; }
    public string Uuid { get; set; }

    public override string ToString()
    {
        return "MetadataEntry[Title=" + Title + ", Uuid=" + Uuid + "]";
    }
}
