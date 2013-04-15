using System;
using System.IO;
using System.Xml.Serialization;
using Arkitektum.CSW;
using Arkitektum.Kartverket.MetadataCore.Validate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using www.ogc.net.csw;

namespace Arkitektum.Kartverket.MetadataMonitor.Tests.Services
{
    [TestClass]
    public class InspireValidatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {



            new InspireValidator().RetrieveAndValidate("202cf0db-8055-438c-a00a-e7cf40a8b1bc");
        }
    }
}
