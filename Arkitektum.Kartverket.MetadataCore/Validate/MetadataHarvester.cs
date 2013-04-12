using System.Diagnostics;
using System.Globalization;
using System.Xml;
using Arkitektum.CSW;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class MetadataHarvester
    {
        private readonly HttpRequestExecutor _httpRequestExecutor;

        private MetadataHarvester(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }
        public MetadataHarvester() : this(new HttpRequestExecutor()) { }

        public void HarvestAndAddToValidationQueue()
        {
            Trace.WriteLine("Starting harvesting");

            GetRecordsResponseType firstSearchResponse = RunSearch();

            var searchResults = firstSearchResponse.SearchResults;

            SendSearchResultsToValidation(searchResults);
            
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
                SendSearchResultsToValidation(searchResults);
            }
        }


        private static void SendSearchResultsToValidation(SearchResultsType searchResults)
        {
            Trace.WriteLine("------------LOOPING SEARCH RESULT--------------------");
            foreach (var item in searchResults.Items)
            {
                SummaryRecordType summary = (SummaryRecordType) item;

                var title = summary.title[0].Text[0];
                var identifier = summary.identifier[0].Text[0];

                Trace.WriteLine("[Identifier=" + identifier + "], [Title=" + title + "]");
                
                new ValidatorService().AddToValidationQueue(identifier);
            }
        }
        

        private GetRecordsResponseType RunSearch(int startPosition)
        {
            Trace.WriteLine("Running search with start position: " + startPosition);
            string responseBody = _httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw, "application/xml", "application/xml",
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
            query.typeNames = new[] { new XmlQualifiedName("Record", "csw") };
            
            var queryConstraint = new QueryConstraintType();
            queryConstraint.version = "1.1.0";
            queryConstraint.Item = new FilterType(); // using empty filter to get all records
            query.Constraint = queryConstraint;

            getRecords.Item = query;

            return SerializeUtil.SerializeToString(getRecords);
        }

    }
}
