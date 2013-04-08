using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using csw;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class InspireValidator
    {
        private const string InspireServiceUrl = "http://inspire-geoportal.ec.europa.eu/GeoportalProxyWebServices/resources/INSPIREResourceTester";

        private const string GeoNorgeCswEndpoint = "http://www.geonorge.no/geonetwork/srv/en/csw";

        public ValidationResult RetrieveAndValidate(string uuid)
        {
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);

            string cswRecordResponse = ExecuteHttpPostRequest(GeoNorgeCswEndpoint, "application/xml", "application/xml",
                                                         getCswRecordRequest);
            
            string inspireValidationResponse = RunInspireValidation(cswRecordResponse);

            XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
            return new InspireValidationResponseParser().ParseValidationResponse(uuid, "", xmlDoc);
        }

        private static string CreateGetCswRecordRequest(string uuid)
        {
            GetRecordByIdType getRecordById = new GetRecordByIdType("GetRecordById");
            getRecordById.Service = "CSW";
            getRecordById.Version = "2.0.2";
            getRecordById.OutputSchema = "csw:IsoRecord";
            getRecordById.IdCol.Add(uuid);
            getRecordById.ElementSetName = new ElementSetName();
            getRecordById.ElementSetName.PrimitiveValue = "full";

            string getCswRecordRequest = getRecordById.ToXml();
            return getCswRecordRequest;
        }

        // deprecated
        public ValidationResult Validate(string uuid)
        {
            string urlToMetadataFile = "http://www.geonorge.no/geonetwork/srv/no/iso19139.xml?uuid=" + uuid;
            Trace.WriteLine("Running INSPIRE Validation on url: " + urlToMetadataFile);

            ValidationResult result = null;

            try
            {
                string responseBody = RunInspireValidation(urlToMetadataFile);
                Trace.WriteLine("INSPIRE Validator response:");
                Trace.WriteLine(responseBody);
                XDocument xmlDoc = XDocument.Parse(responseBody);

                result = new InspireValidationResponseParser().ParseValidationResponse(uuid, urlToMetadataFile, xmlDoc);

            }
            catch (Exception e)
            {
                result = new ValidationResult(uuid);
                result.Url = urlToMetadataFile;
                result.ValidateTimestamp = DateTime.Now;
            }
            return result;
        }

        public string RunInspireValidation(string data)
        {
            string boundary = "----MetadataMonitor";
            StringBuilder builder = new StringBuilder();
            builder.Append("--");
            builder.Append(boundary);
            builder.Append("\r\n");
            builder.Append("Content-Disposition: form-data; name=\"resourceRepresentation\"\r\n\r\n");
            builder.Append(data);
            builder.Append("\r\n");
            builder.Append("--");
            builder.Append(boundary);

            string postData = builder.ToString();
            
            string contentType = "multipart/form-data; boundary=" + boundary;

            string responseBody = ExecuteHttpPostRequest(InspireServiceUrl, "application/xml", contentType, postData);

            return responseBody;
        }


        private string ExecuteHttpPostRequest(string url, string accept, string contentType, string postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = accept;
            request.ContentType = contentType;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseBody = reader.ReadToEnd();

            response.Close();
            return responseBody;
        }


    }
}