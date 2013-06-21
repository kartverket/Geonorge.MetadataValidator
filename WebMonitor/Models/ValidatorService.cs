using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;
using Arkitektum.GIS.Lib.SerializeUtil;
using Microsoft.WindowsAzure.Storage;
using www.opengis.net;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidatorService
    {
        private readonly ValidationResultRepository _validationResultRepository;
        private readonly HttpRequestExecutor _httpRequestExecutor;

        public ValidatorService(ValidationResultRepository validationResultRepository, HttpRequestExecutor httpRequestExecutor)
        {
            _validationResultRepository = validationResultRepository;
            _httpRequestExecutor = httpRequestExecutor;
        }

        public ValidatorService() : this(new ValidationResultRepository(), new HttpRequestExecutor()) { }
        
        public void ValidateMetadata(string uuid)
        {
            try
            {
                var validationResult = new InspireValidator().RetrieveAndValidate(uuid);

                _validationResultRepository.SaveValidationResult(validationResult);
            }
            catch (WebException e)
            {
                Trace.WriteLine("Exception during validation of metadata: " + e.Message);
            }
        }

        public void RunValidateWithRegularSearch()
        {
            GetRecordsResponseType firstSearchResponse = RunSearch();
            var searchResults = firstSearchResponse.SearchResults;

            int numberOfRecordsMatched = int.Parse(searchResults.numberOfRecordsMatched);
            //int numberOfRecordsMatched = 50;
            int next = int.Parse(searchResults.nextRecord);

            List<MetadataEntry> entries = ParseSearchResults(searchResults);
            ProcessMetadataEntries(entries);

            try
            {
                while (next < numberOfRecordsMatched)
                {
                    var searchResponse = RunSearch(next);
                    entries = ParseSearchResults(searchResponse.SearchResults);
                    ProcessMetadataEntries(entries);
                    next = int.Parse(searchResponse.SearchResults.nextRecord);
                }
            }
            catch (Exception e)
            {

            }
        }

        private void ProcessMetadataEntries(List<MetadataEntry> entries)
        {
            foreach (var metadataEntry in entries)
            {
                ValidateMetadata(metadataEntry.Uuid);
            }
        }


        public List<MetadataEntry> ParseSearchResults(SearchResultsType searchResults)
        {
            List<MetadataEntry> results = new List<MetadataEntry>();

            foreach (var item in searchResults.Items)
            {
                SummaryRecordType summary = (SummaryRecordType)item;

                var title = "unknown";
                if (summary.title != null && summary.title.Length > 0 && summary.title[0] != null && summary.title[0].Text != null && summary.title[0].Text.Length > 0)
                    title = summary.title[0].Text[0];

                var uuid = summary.identifier[0].Text[0];


                results.Add(new MetadataEntry { Title = title, Uuid = uuid });
            }
            return results;
        }

        public GetRecordsResponseType RunSearch(int startPosition)
        {
            Trace.WriteLine("Running search with start position: " + startPosition);
            string responseBody = _httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw, "application/xml", "application/xml",
                                            CreateRequestBody(startPosition));


            return SerializeUtil.DeserializeFromString<GetRecordsResponseType>(responseBody);
        }

        public GetRecordsResponseType RunSearch()
        {
            return RunSearch(1);
        }


        private static
            CloudStorageAccount GetCloudStorageAccount()
        {
            return CloudStorageUtil.GetCloudStorageAccount();
        }

        public string CreateRequestBody(int startPosition)
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

    public class MetadataEntry
    {
        public string Title { get; set; }
        public string Uuid { get; set; }

        public override string ToString()
        {
            return "MetadataEntry[Title=" + Title + ", Uuid=" + Uuid + "]";
        }
    }
}