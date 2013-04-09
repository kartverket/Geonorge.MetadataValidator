using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class HttpRequestExecutor
    {

        public string PostRequest(string url, string accept, string contentType, string postData)
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

            Trace.WriteLine(((HttpWebResponse)response).StatusDescription);
            
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseBody = reader.ReadToEnd();

            response.Close();
            
            return responseBody;
        }


    }
}
