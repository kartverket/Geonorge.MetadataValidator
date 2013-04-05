using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class InspireValidator
    {
        private const string InspireServiceUrl = "http://inspire-geoportal.ec.europa.eu/GeoportalProxyWebServices/resources/INSPIREResourceTester";

        public ValidationResult Validate(string uuid)
        {
            string urlToMetadataFile = "http://www.geonorge.no/geonetwork/srv/no/iso19139.xml?uuid=" + uuid;
            Trace.WriteLine("Running INSPIRE Validation on url: " + urlToMetadataFile);

            ValidationResult result = null;

            try
            {
                string responseBody = RunHttpRequest(urlToMetadataFile);

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
        
        public string RunHttpRequest(string urlToMetadataFile)
        {
            string boundary = "----MetadataMonitor";
            StringBuilder builder = new StringBuilder();
            builder.Append("--");
            builder.Append(boundary);
            builder.Append("\r\n");
            builder.Append("Content-Disposition: form-data; name=\"resourceRepresentation\"\r\n\r\n");
            builder.Append(urlToMetadataFile);
            builder.Append("\r\n");
            builder.Append("--");
            builder.Append(boundary);

            string postData = builder.ToString();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(InspireServiceUrl);
            request.Method = "POST";
            request.Accept = "application/xml";
            request.ContentType = "multipart/form-data; boundary=" + boundary;
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