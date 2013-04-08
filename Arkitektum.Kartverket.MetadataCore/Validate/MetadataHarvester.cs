using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using csw;
using ogc;
using Enumerations = csw.Enumerations;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class MetadataHarvester
    {
        public const string GeoNorgeCswEndpoint = "http://www.geonorge.no/geonetwork/srv/en/csw";

        public void HarvestAndAddToValidationQueue()
        {
            var firstSearchResponse = RunSearch(GeoNorgeCswEndpoint);

            var searchResults = firstSearchResponse.SearchResults;

            SendSearchResultsToValidation(searchResults);

            int counter = 0;
            while (counter < 50 && searchResults.NumberOfRecordsMatched.IntValue() > searchResults.NumberOfRecordsReturned.IntValue())
            {
                Trace.WriteLine("----------Counter=" + counter);

                var response = RunSearch(GeoNorgeCswEndpoint, searchResults.NextRecord.IntValue());
                searchResults = response.SearchResults;
                SendSearchResultsToValidation(searchResults);

                counter += searchResults.NumberOfRecordsReturned.IntValue();
            }
        }


        private static void SendSearchResultsToValidation(SearchResultsType searchResults)
        {
            var enumerator = searchResults.SearchResultsType_Choice.AbstractRecordCol;

            Trace.WriteLine("------------LOOPING SEARCH RESULT--------------------");

            foreach (var subGrpAbstractRecord in enumerator)
            {
                var summary = subGrpAbstractRecord.SummaryRecord;
                var title = summary.TitleCol[0].Title.PrimitiveValue;
                var identifier = summary.IdentifierCol[0].Identifier.PrimitiveValue;
                Trace.WriteLine(title);
                Trace.WriteLine(identifier);

                ValidationResult result = new ValidationResult(identifier) {Title = title, ValidateTimestamp = DateTime.Now};
                new ValidationResultRepository().SaveValidationResult(result);

                new ValidatorService().AddToValidationQueue(identifier);
            }
        }


        private GetRecordsResponse RunSearch(string cswEndpoint, int intValue)
        {
            throw new NotImplementedException();
        }

        private GetRecordsResponse RunSearch(string cswEndpoint)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(cswEndpoint);
            request.Method = "POST";
            request.ContentType = "application/xml";
            string requestBody = CreateRequestBody();
            Console.WriteLine(requestBody);
            byte[] byteArray = Encoding.UTF8.GetBytes(requestBody);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseBody = reader.ReadToEnd();
            response.Close();

            Console.WriteLine("Response:");
            Console.WriteLine(responseBody);

            return ParseResponseBody(responseBody);
        }

        private string CreateRequestBody()
        {
            var getRecords = new GetRecords();
            getRecords.ResultType = Enumerations.ResultType.Results;

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
            var getRecordsResponse = new GetRecordsResponse();
            getRecordsResponse.FromXml(responseBody);
            return getRecordsResponse;
        }

/*        private string createRequestBody()
        {
            var getRecords = new GetRecordsType();
            
            getRecords.resultType = ResultType.results;

            var query = new QueryType();
            query.typeNames = new XmlQualifiedName[] { new XmlQualifiedName("Record", "csw") };
            
            var queryConstraint = new QueryConstraintType();
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
