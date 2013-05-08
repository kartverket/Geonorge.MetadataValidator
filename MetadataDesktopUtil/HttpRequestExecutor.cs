using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace MetadataDesktopUtil
{
    public class HttpRequestExecutor
    {

        public string PostRequest(string url, string accept, string contentType, string postData, Cookie cookie = null) 
        {
            HttpWebResponse response = FullPostRequest(url, accept, contentType, postData, cookie);
            
            Trace.WriteLine("Response code:" + ((HttpWebResponse)response).StatusDescription);
            
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseBody = reader.ReadToEnd();

            response.Close();
            
 //           Trace.WriteLine("Data:");
 //           Trace.WriteLine(responseBody);

            return responseBody;
        }
        
        public HttpWebResponse FullPostRequest(string url, string accept, string contentType, string postData, Cookie cookie = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = accept;
            request.ContentType = contentType;
            
            //SetBasicAuthHeader(request, "admin", "admin");
            request.CookieContainer = new CookieContainer();
            if (cookie != null)
            {
                Cookie sessionCookie = new Cookie("JSESSIONID", cookie.Value, "/geonetwork", "localhost");
                request.CookieContainer.Add(sessionCookie);
                Trace.WriteLine("Adding cookie: " + sessionCookie);
            }

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

           

            

         

            Trace.WriteLine("HTTP request:");
            Trace.WriteLine(url);
            Trace.WriteLine("Method: " + request.Method);
            Trace.WriteLine("Accept: " + request.Accept);
            Trace.WriteLine("Content-Type: " + request.ContentType);
            if (request.CookieContainer != null)
                Trace.WriteLine("Cookie: " + request.CookieContainer);
//            Trace.WriteLine("Data:");
//            Trace.WriteLine(postData);

            var response = (HttpWebResponse)request.GetResponse();
            Trace.WriteLine(response.StatusCode + " - " + response.StatusDescription);
            return (HttpWebResponse)request.GetResponse();
        }

        public HttpWebResponse FullGetRequest(string url, string accept, string contentType)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = accept;
            request.ContentType = contentType;
            return (HttpWebResponse)request.GetResponse();
        }

    }
}
