using System;
using Arkitektum.Kartverket.MetadataCore.Validate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arkitektum.Kartverket.MetadataMonitor.Tests.Validate
{
    [TestClass]
    public class MetadataHarvesterTest
    {
        [TestMethod]
        public void RunMetadataHarvester()
        {
            new MetadataHarvester().HarvestAndAddToValidationQueue();
        }
    }
}
