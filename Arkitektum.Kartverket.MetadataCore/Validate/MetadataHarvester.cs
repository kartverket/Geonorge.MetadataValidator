using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using csw;
using ogc;
using Enumerations = csw.Enumerations;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class MetadataHarvester
    {
        public const string GeoNorgeCswEndpoint = "http://www.geonorge.no/geonetwork/srv/en/csw";

        private HttpRequestExecutor httpRequestExecutor;

        public MetadataHarvester(HttpRequestExecutor httpRequestExecutor)
        {
            this.httpRequestExecutor = httpRequestExecutor;
        }
        public MetadataHarvester() : this(new HttpRequestExecutor()) { }

        public void HarvestAndAddToValidationQueue()
        {
            Trace.WriteLine("Starting harvesting");
            GetRecordsResponse firstSearchResponse = RunSearch();

            var searchResults = firstSearchResponse.SearchResults;

            SendSearchResultsToValidation(searchResults);
            
            int counter = 0;
            int max = searchResults.NumberOfRecordsMatched.IntValue();
            int next = searchResults.NextRecord.IntValue();
            while (next < max)
            {
                Trace.WriteLine("----------Counter=" + counter);

                max = searchResults.NumberOfRecordsMatched.IntValue();
                next = searchResults.NextRecord.IntValue();

                var response = RunSearch(next);
                searchResults = response.SearchResults;
                SendSearchResultsToValidation(searchResults);

                counter += searchResults.NumberOfRecordsReturned.IntValue();
            }
        }


        private static void SendSearchResultsToValidation(SearchResultsType searchResults)
        {
            Trace.WriteLine("------------LOOPING SEARCH RESULT--------------------");

            foreach (var item in searchResults.SearchResultsType_Choice.AbstractRecordCol)
            {
                SummaryRecord summary = item.SummaryRecord;
                
                var title = summary.TitleCol[0].Title.PrimitiveValue;
                var identifier = summary.IdentifierCol[0].Identifier.PrimitiveValue;

                Trace.WriteLine("[Identifier=" + identifier + "], [Title=" + title + "]");
                
                new ValidatorService().AddToValidationQueue(identifier);
            }
        }


        private GetRecordsResponse RunSearch(int startPosition)
        {
            Trace.WriteLine("Running search with start position: " + startPosition);
            string responseBody = httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw, "application/xml", "application/xml",
                                            CreateRequestBody(startPosition));


            return ParseResponseBody(responseBody);
        }

        private GetRecordsResponse RunSearch()
        {
            return RunSearch(1);
        }

        private string CreateRequestBody(int startPosition)
        {
            var getRecords = new GetRecords();
            getRecords.ResultType = Enumerations.ResultType.Results;
            getRecords.StartPosition = startPosition;
            var typeChoice = new GetRecordsType_Type_Choice();
            typeChoice.AbstractQuery = new SubGrpAbstractQuery();
            typeChoice.AbstractQuery.Query = new Query();
            typeChoice.AbstractQuery.Query.TypeNames = "csw:Record";
            typeChoice.AbstractQuery.Query.Constraint = new Constraint();
            typeChoice.AbstractQuery.Query.Constraint.Version = "1.1.0";
            typeChoice.AbstractQuery.Query.Constraint.Filter = new Filter();

            getRecords.GetRecordsType_Type_Choice = typeChoice;

            return getRecords.ToXml();
        }

        private GetRecordsResponse ParseResponseBody(string responseBody)
        {
            try
            {
                var getRecordsResponse = new GetRecordsResponse();
                getRecordsResponse.FromXml(responseBody);
                return getRecordsResponse;
            }
            catch (LiquidTechnologies.Runtime.Net45.LtValidationException e)
            {
                Trace.WriteLine("Exception when parsing XML");
                Trace.WriteLine(responseBody);

                string errText = "Error - \n";
                // Note : exceptions are likely to contain inner exceptions
                // that provide further detail about the error.
                Exception ex = e;
                while (ex != null)
                {
                    errText += ex.Message + "\n";
                    ex = ex.InnerException;
                }
                Trace.WriteLine(errText);

                throw e;
            }
        }

/*
        private string createRequestBody()
        {
            var getRecords = new GetRecordsType();
            
            getRecords.resultType = ResultType.results;

            var query = new QueryType();
            query.typeNames = new XmlQualifiedName[] { new XmlQualifiedName("Record", "csw") };
            
            var queryConstraint = new QueryConstraintType();
            queryConstraint.version = "1.1.0";
            queryConstraint.Item = new FilterType(); // using empty filter to get all records
            query.Constraint = queryConstraint;
         
            getRecords.Item = query;

            var serializer = new XmlSerializer(typeof(GetRecordsType));

            string output = null;
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, getRecords);
                output = writer.ToString();
            }
            return output;
        }
  
        private GetRecordsResponseType ParseResponseBody(string xmlSource)
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(GetRecordsResponseType));
            GetRecordsResponseType output;

            using (StringReader reader = new StringReader(xmlSource))
            {
                output = (GetRecordsResponseType)serializer.Deserialize(reader);
            }
            return output;
        }
        
        */
    }
}
