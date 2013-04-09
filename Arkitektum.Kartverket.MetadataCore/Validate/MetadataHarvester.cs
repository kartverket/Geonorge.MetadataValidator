using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
//using csw;
//using ogc;
//using Enumerations = csw.Enumerations;
using System.Xml.Serialization;
using System.Xml;
using www.opengis.net.cat.csw._2._01._22;
using www.opengis.net.ogc;

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
            var getRecords = new GetRecordsType();

            getRecords.Nodes.
                //.resultType = ResultType.results;

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
            Trace.WriteLine(output);
        }

        /*
            
            var firstSearchResponse = RunSearch(GeoNorgeCswEndpoint);

            var searchResults = firstSearchResponse.SearchResults;

            SendSearchResultsToValidation(searchResults);
            int counter = 0;
            int max = int.Parse(searchResults.numberOfRecordsMatched);
            int next = int.Parse(searchResults.nextRecord);
            while (counter < 50 && next < max)
            {
                Trace.WriteLine("----------Counter=" + counter);
                
                max = int.Parse(searchResults.numberOfRecordsMatched);
                next = int.Parse(searchResults.nextRecord);

                var response = RunSearch(GeoNorgeCswEndpoint, next);
//                searchResults = response.;
//                SendSearchResultsToValidation(searchResults);


                counter += int.Parse(searchResults.numberOfRecordsReturned);
            }
        }


        private static void SendSearchResultsToValidation(SearchResultsType searchResults)
        {
            var enumerator = searchResults.Items;

            Trace.WriteLine("------------LOOPING SEARCH RESULT--------------------");

            foreach (var item in searchResults.Items)
            {
                SummaryRecordType summary = (SummaryRecordType) item;

                var title = summary.title[0].Text[0];
                var identifier = summary.identifier[0].Text[0];
                Trace.WriteLine(title);
                Trace.WriteLine(identifier);

                ValidationResult result = new ValidationResult(identifier) {Title = title, ValidateTimestamp = DateTime.Now};
                new ValidationResultRepository().SaveValidationResult(result);

                new ValidatorService().AddToValidationQueue(identifier);
            }
        }


        private GetRecordsResponseType RunSearch(string cswEndpoint, int intValue)
        {
            throw new NotImplementedException();
        }
    
        private GetRecordsResponseType RunSearch(string cswEndpoint)
        {
            string responseBody = httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw, "application/xml", "application/xml",
                                            createRequestBody());

            return ParseResponseBody(responseBody);
        }

        //private string CreateRequestBody()
        //{
        //    var getRecords = new GetRecords();
        //    getRecords.ResultType = Enumerations.ResultType.Results;

        //    var typeChoice = new GetRecordsType_Type_Choice();
        //    typeChoice.AbstractQuery = new SubGrpAbstractQuery();
        //    typeChoice.AbstractQuery.Query = new Query();
        //    typeChoice.AbstractQuery.Query.TypeNames = "csw:Record";
        //    typeChoice.AbstractQuery.Query.Constraint = new Constraint();
        //    typeChoice.AbstractQuery.Query.Constraint.Version = "1.1.0";
        //    typeChoice.AbstractQuery.Query.Constraint.Filter = new Filter();

        //    getRecords.GetRecordsType_Type_Choice = typeChoice;

        //    return getRecords.ToXml();
        //}

        //private GetRecordsResponse ParseResponseBody(string responseBody)
        //{
        //    var getRecordsResponse = new GetRecordsResponse();
        //    getRecordsResponse.FromXml(responseBody);
        //    return getRecordsResponse;
        //}


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
