using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using Arkitektum.Kartverket.MetadataCore.Validate;
using Microsoft.WindowsAzure.ServiceRuntime;
using Quartz;
using Quartz.Impl;

namespace Arkitektum.Kartverket.MetadataValidator
{
    public class WorkerRole : RoleEntryPoint
    {
        public override void Run()
        {
            // This is a sample worker implementation. Replace with your logic.
            Trace.WriteLine("WorkerRole1 entry point called", "Information");

            while (true)
            {
                Thread.Sleep(3600000);
                Trace.WriteLine("Working", "Information");

                //new MetadataHarvester().HarvestAndAddToValidationQueue();
                //new ValidatorService().RunValidateOnQueueMessages();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections 
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            ConfigureScheduler();


            return base.OnStart();
        }

        IScheduler sched;
        private void ConfigureScheduler()
        {
            var schedFact = new StdSchedulerFactory();

            sched = schedFact.GetScheduler();
            var job = new JobDetailImpl("DailyJob", null, typeof(RunValidationJob));
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var cronScheduleBuilder = CronScheduleBuilder.DailyAtHourAndMinute(14, 00)
                                                          .InTimeZone(timeZoneInfo);
            var trigger = TriggerBuilder.Create()
                                        .StartNow()
                                        .WithSchedule(cronScheduleBuilder)
                                        .Build();

            sched.ScheduleJob(job, trigger);
            sched.Start();
        }
    }
}
