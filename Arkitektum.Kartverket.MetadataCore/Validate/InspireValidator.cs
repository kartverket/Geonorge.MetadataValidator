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

        private const string ContentTypeXml = "application/xml";

        private HttpRequestExecutor httpRequestExecutor;

        public InspireValidator(HttpRequestExecutor httpRequestExecutor)
        {
            this.httpRequestExecutor = httpRequestExecutor;
        }

        public InspireValidator() : this(new HttpRequestExecutor()) { }


        public ValidationResult RetrieveAndValidate(string uuid)
        {
            var getCswRecordRequest = CreateGetCswRecordRequest(uuid);

            string cswRecordResponse = httpRequestExecutor.PostRequest(Constants.EndpointUrlGeoNorgeCsw, ContentTypeXml, ContentTypeXml, getCswRecordRequest);
            
            string inspireValidationResponse = RunInspireValidation(cswRecordResponse);

            XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
            return new InspireValidationResponseParser().ParseValidationResponse(uuid, "", xmlDoc);
        }

        private static string CreateGetCswRecordRequest(string uuid)
        {
            /*
            GetRecordByIdType getRecordById = new GetRecordByIdType("GetRecordById");
            getRecordById.Service = "CSW";
            getRecordById.Version = "2.0.2";
            getRecordById.OutputSchema = "csw:IsoRecord";
            getRecordById.IdCol.Add(uuid);
            getRecordById.ElementSetName = new ElementSetName();
            getRecordById.ElementSetName.PrimitiveValue = "full";

            string getCswRecordRequest = getRecordById.ToXml();
            */

            return "";
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

            string responseBody = httpRequestExecutor.PostRequest(Constants.EndpointUrlInspire, "application/xml", contentType, postData);

            return responseBody;
        }


    }
}