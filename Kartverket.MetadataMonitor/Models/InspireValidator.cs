using System.Text;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Web.Configuration;
using System;
using Newtonsoft.Json;
using Kartverket.MetadataMonitor.Models.External.Inspire;

namespace Kartverket.MetadataMonitor.Models
{
    public class InspireValidator
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly HttpRequestExecutor _httpRequestExecutor;

        private readonly string _inspireUrl = WebConfigurationManager.AppSettings["InspireUrl"];
        private readonly string _validationEndpoint = WebConfigurationManager.AppSettings["InsprireValidationEndpoint"];
        private readonly string _metadataSelectorEndpoint = WebConfigurationManager.AppSettings["InsprireMetadataSelectorEndpoint"];
        private readonly string _validationStatusEndpoint = WebConfigurationManager.AppSettings["InsprireValidationStatusEndpoint"];

        public InspireValidator() : this(new HttpRequestExecutor())
        {
            
        }

        public InspireValidator(HttpRequestExecutor httpRequestExecutor)
        {
            _httpRequestExecutor = httpRequestExecutor;
        }

        // @TODO: Check if this method is obsolete.
        public ValidationResult Validate(string rawXmlProcessed)
        {
            return Validate(rawXmlProcessed, false);
        }

        // @TODO: Check if this method is obsolete.
        public ValidationResult Validate(string rawXmlProcessed, bool allowSpatialDataThemeError, bool allowConformityError = false)
        {
            string inspireValidationResponse = RunInspireValidation(rawXmlProcessed);
            
            Log.Debug(inspireValidationResponse);

            XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
            InspireValidationResponseParser parser = new InspireValidationResponseParser(xmlDoc);

            return parser.ParseValidationResponseWithCompletenessIndicator();
        }

        public ValidationResult CheckValidationState(string uuid)
        {
            if (!string.IsNullOrWhiteSpace(uuid))
            {
                string inspireId = GetInspireId(uuid);

                if (!string.IsNullOrWhiteSpace(inspireId))
                {
                    Log.Info($"Check validation state for metadata. Inspire id: {inspireId}");
                    string inspireValidationResponse = _httpRequestExecutor.GetRequest(_inspireUrl + _validationStatusEndpoint + inspireId, "application/xml", "");
                    XDocument xmlDoc = XDocument.Parse(inspireValidationResponse);
                    InspireValidationResponseParser parser = new InspireValidationResponseParser(xmlDoc);

                    return parser.ParseValidationResponseWithCompletenessIndicator();
                }
                else
                {
                    throw new Exception($"Cannot retrieve inspire id for {uuid}");
                }
            }
            else
            {
                throw new Exception("Metadata id missing.");
            }
        }

        private string GetInspireId(string uuid)
        {
            string inspireId = "";
            Log.Info($"Get inspire id from geonorge id: {uuid}.");

            string response = _httpRequestExecutor.GetRequest(_inspireUrl + _metadataSelectorEndpoint + uuid, "", "");

            SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(response);

            if (searchResult.Response != null && searchResult.Response.Documents != null && searchResult.Response.Documents.Count == 1)
            {
                inspireId = searchResult.Response.Documents[0].Id;
            }
            return inspireId;
        }

        // @TODO: Check if this method is obsolete.
        private string RunInspireValidation(string data)
        {
            /* 
             * BAD HACK: Search and replace norwegian language code with english language code. 
             * INSPIRE does not validate metadata with norwegian language code.
             * This removes validation errors related to conformity and language code.
             */
            data = data.Replace(">nob</gco:CharacterString>", ">eng</gco:CharacterString>");
            data = data.Replace(">nor</gco:CharacterString>", ">eng</gco:CharacterString>");

            // formating request according to 
            // http://inspire-geoportal.ec.europa.eu/validator2/html/usingaswebservice.html

            string boundary = createHash(DateTime.Now.Ticks.ToString());

            string eol = "\r\n";
            StringBuilder builder = new StringBuilder();
            builder.Append("--").Append(boundary).Append(eol);
            builder.Append("Content-Disposition: form-data; name=\"resourceRepresentation\"").Append(eol).Append(eol);
            builder.Append(data);
            builder.Append(eol);
            builder.Append("--").Append(boundary).Append("--").Append(eol).Append(eol);

            string postData = builder.ToString();

            string contentType = "multipart/form-data; boundary=" + boundary;

            Log.Info("Sending metadata to INSPIRE validator.");
            string responseBody = _httpRequestExecutor.PostRequest(_inspireUrl + _validationEndpoint, "application/xml", contentType, postData);

            return responseBody;
        }

        private string createHash(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}