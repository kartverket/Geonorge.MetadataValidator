using System;
using System.IO;
using System.Net;
using System.Text;
using csw;
using ogc;
using Enumerations = csw.Enumerations;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class MetadataHarvester
    {

        public void HarvestAndAddToValidationQueue()
        {
            var getRecordsResponse = RunSearch("http://www.geonorge.no/geonetwork/srv/en/csw");

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

/*
        private string createRequestBody()
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
