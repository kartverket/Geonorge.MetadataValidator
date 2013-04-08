﻿using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
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

        public void HarvestMetadataAndAddToValidationQueue()
        {

        }

        private void ValidateMetadata(string uuid)
        {
//            var validationResult = new InspireValidator().Validate(uuid);
            var validationResult = new InspireValidator().RetrieveAndValidate(uuid);

            _validationResultRepository.SaveValidationResult(validationResult);   
        }

        private static CloudStorageAccount GetCloudStorageAccount()
        {
            return CloudStorageUtil.GetCloudStorageAccount();
        }
    }
}