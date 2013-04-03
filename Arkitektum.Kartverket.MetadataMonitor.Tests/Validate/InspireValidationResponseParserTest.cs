using System;
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
            XNamespace common = InspireValidationResponseParser.NsCommon;
            XNamespace geo = InspireValidationResponseParser.NsGeo;
            XNamespace rdsi = InspireValidationResponseParser.NsRdsi;

            XDocument doc = new XDocument(
                new XElement(geo + "Resource",
                    new XAttribute("xmlns", common),
                    new XAttribute(XNamespace.Xmlns + "ns2", geo),
                    new XAttribute(XNamespace.Xmlns + "ns3", rdsi))
                );

            ValidationResult result = new InspireValidationResponseParser().ParseValidationResponse("", doc);

            Assert.IsTrue(result.ValidateOk);

        }
    }
}
