using System.Diagnostics;
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

            ValidationResult result = new InspireValidationResponseParser().ParseValidationResponse("21344-2424","http://", doc);

            Assert.IsTrue(result.ValidateOk);
        }
        
        [TestMethod]
        public void ShouldReturnFailedResponseWhenErrorsInResponse()
        {
            var doc = CreateDocument(true);

            Trace.WriteLine(doc.ToString());

            ValidationResult result = new InspireValidationResponseParser().ParseValidationResponse("21344-2424", "http://", doc);

            Assert.IsFalse(result.ValidateOk);
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
