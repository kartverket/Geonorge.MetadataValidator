using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace Arkitektum.Kartverket.MetadataMonitor.Services
{
    public class InspireValidator
    {
        private const string InspireServiceUrl = "http://inspire-geoportal.ec.europa.eu/GeoportalProxyWebServices/resources/INSPIREResourceTester";

        public void Validate(string urlToMetadataFile)
        {
            string responseBody = RunHttpRequest(urlToMetadataFile); 
            XDocument xmlDoc = XDocument.Parse(responseBody);

            bool isOk = IsResponseOk(xmlDoc);

        }

        private bool IsResponseOk(XDocument xmlDoc)
        {

            

            throw new NotImplementedException();
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