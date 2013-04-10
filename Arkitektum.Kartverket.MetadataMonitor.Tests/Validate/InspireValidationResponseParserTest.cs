using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arkitektum.Kartverket.MetadataCore.Validate;

namespace Arkitektum.Kartverket.MetadataMonitor.Tests.Validate
{
    [TestClass]
    public class InspireValidationResponseParserTest
    {
        [TestMethod]
        public void ShouldReturnOkResponseWhenNoErrorsFound()
        {
            var doc = CreateDocument(false);

            Trace.WriteLine(doc.ToString());
            ValidationResult result = new InspireValidationResponseParser().ParseValidationResponse(new ValidationResult(), doc);

            Assert.IsTrue(result.ValidateOk);
        }
        
        [TestMethod]
        public void ShouldReturnFailedResponseWhenErrorsInResponse()
        {
            var doc = CreateDocument(true);

            Trace.WriteLine(doc.ToString());

            ValidationResult result = new InspireValidationResponseParser().ParseValidationResponse(new ValidationResult(), doc);

            Assert.IsFalse(result.ValidateOk);
        }

        [TestMethod]
        public void ShouldReturnErrorMessageWhenResourceTypeIsUnknown()
        {
            var stream = GetType().Assembly.GetManifestResourceStream("Arkitektum.Kartverket.MetadataMonitor.Tests.Validate.inspire-unknown-resource-type.xml");
            var doc = XDocument.Load(stream);
            Trace.WriteLine(doc.ToString());

            ValidationResult result = new InspireValidationResponseParser().ParseValidationResponse(new ValidationResult(), doc);

            Assert.IsFalse(result.ValidateOk);

            Trace.WriteLine(result.ErrorMessages);
            Assert.IsTrue(result.ErrorMessages.Contains("It was not possible to determine the resource type"));
        }

        private static XDocument CreateDocument(bool withError)
        {
            XNamespace common = InspireValidationResponseParser.NsCommon;
            XNamespace geo = InspireValidationResponseParser.NsGeo;
            XNamespace rdsi = InspireValidationResponseParser.NsRdsi;

            XElement inspireValidationErrors = new XElement(geo + "InspireValidationErrors");

            if (withError)
            {
                inspireValidationErrors.Add(
                    new XElement(geo + "ValidationError",
                        new XElement(geo + "GeoportalExceptionMessage",
                            new XElement(geo + "Message", "The metadata element &quot;Conditions For Access And Use&quot; is missing, empty or incomplete but it is required")
                        )
                    )
                );
            }

            XDocument doc = new XDocument(
                new XElement(geo + "Resource",
                             new XAttribute("xmlns", common),
                             new XAttribute(XNamespace.Xmlns + "ns2", geo),
                             new XAttribute(XNamespace.Xmlns + "ns3", rdsi),
                             new XElement(geo + "ResourceReportResource",
                                          inspireValidationErrors
                                 )
                    )
                );
            return doc;
        }
    }
}
