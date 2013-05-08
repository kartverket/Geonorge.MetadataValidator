using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using Arkitektum.GIS.Lib.SerializeUtil;
using www.opengis.net;

namespace MetadataDesktopUtil
{
    public class MetadataFixerService
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string _geonetworkEndpoint;
        private readonly HttpRequestExecutor _httpRequestExecutor;
        private readonly MetadataFixer _metadataFixer;
        private readonly BackgroundWorker _worker;

        private MetadataFixerService(string geonetworkEndpoint, HttpRequestExecutor httpRequestExecutor, MetadataFixer metadataFixer, BackgroundWorker worker)
        {
            _geonetworkEndpoint = geonetworkEndpoint;
            _httpRequestExecutor = httpRequestExecutor;
            _metadataFixer = metadataFixer;
            _worker = worker;
        }

        public MetadataFixerService(string geonetworkEndpoint, BackgroundWorker worker) : this(geonetworkEndpoint, new HttpRequestExecutor(), new MetadataFixer(geonetworkEndpoint), worker) { }
        
        public void SearchForAllEntries()
        {
            Log.Info("Start CSW-search");

            GetRecordsResponseType firstSearchResponse = RunSearch();
            var searchResults = firstSearchResponse.SearchResults;

            //int numberOfRecordsMatched = int.Parse(searchResults.numberOfRecordsMatched);
            int numberOfRecordsMatched = 10;
            int next = int.Parse(searchResults.nextRecord);
            int processed = 0;
            
            List<MetadataEntry> entries = ParseSearchResults(searchResults);
            processed = ProcessMetadataEntries(entries, processed, numberOfRecordsMatched);

            while (next < numberOfRecordsMatched)
            {
                var searchResponse = RunSearch(next);
                entries = ParseSearchResults(searchResponse.SearchResults);
                processed = ProcessMetadataEntries(entries, processed, numberOfRecordsMatched);
                next = int.Parse(searchResponse.SearchResults.nextRecord);
            }
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

        private int ProcessMetadataEntries(List<MetadataEntry> entries, int processed, int numberOfRecordsMatched)
        {

            foreach (MetadataEntry metadataEntry in entries)
            {
                _metadataFixer.FixMetadataEntry(metadataEntry);
                processed++;
                float rawValue = ((float)processed / (float)numberOfRecordsMatched) * 10f;
                Log.Info("RawValue=" + rawValue);
                _worker.ReportProgress((int)rawValue);

            }
            return processed;
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
            string responseBody = _httpRequestExecutor.PostRequest(_geonetworkEndpoint + "srv/eng/csw", "application/xml", "application/xml",
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

            getRecords.resultType = ResultType1.results;
            getRecords.startPosition = startPosition.ToString(CultureInfo.InvariantCulture);

            var query = new QueryType();
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
