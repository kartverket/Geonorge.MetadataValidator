using System;
using System.Diagnostics;
using System.Net;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class ValidatorService
    {
        private readonly ValidationResultRepository _validationResultRepository;

        public ValidatorService(ValidationResultRepository validationResultRepository)
        {
            _validationResultRepository = validationResultRepository;
        }

        public ValidatorService() : this(new ValidationResultRepository()) { }
        
        public void AddToValidationQueue(string uuid)
        {
            Trace.WriteLine("AddToValidationQueue: " + uuid);

            CloudQueueClient queueClient = GetCloudStorageAccount().CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("validate");
            queue.CreateIfNotExists();

            CloudQueueMessage message = new CloudQueueMessage(uuid);
            queue.AddMessage(message);
        }

        public void RunValidateOnQueueMessages()
        {
            Trace.WriteLine("RunValidateOnQueueMessages");

            CloudQueueClient queueClient = GetCloudStorageAccount().CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("validate");

            if (queue.Exists())
            {
                foreach (var message in queue.GetMessages(10, TimeSpan.FromMinutes(10)))
                {
                    Trace.WriteLine("Processing message on queue:" + message.AsString);

                    ValidateMetadata(message.AsString);    

                    queue.DeleteMessage(message);


                }
            }
            
        }

        public void ValidateMetadata(string uuid)
        {
            try
            {
                //            var validationResult = new InspireValidator().Validate(uuid);
                var validationResult = new InspireValidator().RetrieveAndValidate(uuid);

                _validationResultRepository.SaveValidationResult(validationResult);
            }
            catch (WebException e)
            {
                Trace.WriteLine("Exception duing validation of metadata: " + e.Message);
            }
        }

        private static
            CloudStorageAccount GetCloudStorageAccount()
        {
            return CloudStorageUtil.GetCloudStorageAccount();
        }
    }
}