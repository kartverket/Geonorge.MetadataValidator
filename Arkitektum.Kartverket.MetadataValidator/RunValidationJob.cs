using System.Diagnostics;
using Arkitektum.Kartverket.MetadataCore.Validate;
using Quartz;

namespace Arkitektum.Kartverket.MetadataValidator
{
    internal class RunValidationJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Trace.WriteLine("Running execute inside RunValidationJob!");
            new ValidatorService().RunValidateOnQueueMessages();
        }
    }
}