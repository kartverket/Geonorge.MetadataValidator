using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    class CloudStorageUtil
    {
        public static CloudStorageAccount GetCloudStorageAccount()
        {
            return CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
        }
    }
}
