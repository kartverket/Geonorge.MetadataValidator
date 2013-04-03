using System;
using System.Diagnostics;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class ValidatorService
    {
        readonly CloudStorageAccount _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

        public void AddToValidationQueue()
        {
            Trace.WriteLine("AddToValidationQueue");

            CloudQueueClient queueClient = _storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("validate");
            queue.CreateIfNotExists();

            CloudQueueMessage message = new CloudQueueMessage("http://www.geonorge.no/geonetwork/srv/no/iso19139.xml?id=21523");
            queue.AddMessage(message);
        }

        public void RunValidateOnQueueMessages()
        {
            Trace.WriteLine("RunValidateOnQueueMessages");

            CloudQueueClient queueClient = _storageAccount.CreateCloudQueueClient();
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

        private void ValidateMetadata(string message)
        {
            throw new NotImplementedException();
        }

    }
}