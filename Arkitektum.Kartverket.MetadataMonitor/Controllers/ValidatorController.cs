using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Arkitektum.Kartverket.MetadataCore.Validate;
using Arkitektum.Kartverket.MetadataMonitor.Models;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;

namespace Arkitektum.Kartverket.MetadataMonitor.Controllers
{
    public class ValidatorController : Controller
    {
        private readonly ValidationResultRepository _validationResultRepository;
        private ValidatorService _validatorService;

        private ValidatorController(ValidationResultRepository validationResultRepository, ValidatorService validatorService)
        {
            _validationResultRepository = validationResultRepository;
            _validatorService = validatorService;
        }

        public ValidatorController() : this(new ValidationResultRepository(), new ValidatorService()) { }

        public ActionResult Index(string message)
        {
            ViewBag.Message = message;

            var results = _validationResultRepository.GetValidationResults();

            List<ValidationResultModel> resultModels = new List<ValidationResultModel>();
            foreach (var result in results)
            {
                resultModels.Add(new ValidationResultModel(result));
            }

            resultModels.Sort();
            resultModels.Reverse();

            return View(resultModels);
        }

        [HttpPost]
        public ActionResult Start(string uuid)
        {
            if (string.IsNullOrEmpty(uuid))
                uuid = "9d118d31-182c-495b-b7be-d819cc7444b1";


            _validatorService.ValidateMetadata(uuid);
            
            return RedirectToAction("Index", new {message = "Started!"});
        }

        public ActionResult Harvest()
        {

            var schedFact = new StdSchedulerFactory();

            IScheduler sched = schedFact.GetScheduler();

            var job = new JobDetailImpl("HarvestingJob", null, typeof(MetadataHarvesterJob));
            
            
//            var trigger = new SimpleTriggerImpl("myTrigger", null, DateTime.UtcNow.AddSeconds(10), null, 0, TimeSpan.Zero);
            var trigger = TriggerBuilder.Create().StartNow().WithIdentity("myTrigger").Build();
            sched.ScheduleJob(job, trigger);
            sched.Start();

            /*
            var schedFact = new StdSchedulerFactory();

            IScheduler sched = schedFact.GetScheduler();


            

            var job = new JobDetailImpl("DailyJob", null, typeof(MetadataHarvesterJob));
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var cronScheduleBuilder = CronScheduleBuilder.DailyAtHourAndMinute(14, 00)
                                                          .InTimeZone(timeZoneInfo);
            var trigger = TriggerBuilder.Create()
                                        .StartNow()
                                        .WithSchedule(cronScheduleBuilder)
                                        .Build();

            TriggerBuilder.Create().ForJob(job).StartNow();
            ISimpleTrigger a = new SimpleTriggerImpl();

            SimpleScheduleBuilder.Create().WithRepeatCount(1);
            sched.ScheduleJob(job, trigger);
            sched.Start();
            */
            return RedirectToAction("Index", new {message = "Harvesting started"});
        }
    }
}
