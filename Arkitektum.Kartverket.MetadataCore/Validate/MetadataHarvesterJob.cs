using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class MetadataHarvesterJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Trace.WriteLine("***************************** Starting MetdataHarvesterJob **********************************", "Information");
            try
            {
                new MetadataHarvester().HarvestAndAddToValidationQueue();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Exception while running job: " + e.Message);
            }
            
            
            Trace.WriteLine("***************************** Stopping MetdataHarvesterJob **********************************", "Information");
        }
    }
}
