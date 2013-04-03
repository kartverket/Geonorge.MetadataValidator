using Arkitektum.Kartverket.MetadataCore.Validate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arkitektum.Kartverket.MetadataMonitor.Tests.Services
{
    [TestClass]
    public class InspireValidatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            new InspireValidator().Validate("http://www.geonorge.no/geonetwork/srv/no/iso19139.xml?id=21523");
        }
    }
}
