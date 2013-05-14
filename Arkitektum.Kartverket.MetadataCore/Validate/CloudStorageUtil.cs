using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    class CloudStorageUtil
    {
        public static CloudStorageAccount GetCloudStorageAccount()
        {

            string connectionString = null;

            if (RoleEnvironment.IsAvailable)
                connectionString = RoleEnvironment.GetConfigurationSettingValue("StorageConnectionString");
            else
                //connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];
                connectionString = CloudConfigurationManager.GetSetting("StorageConnectionString");
            return CloudStorageAccount.Parse(connectionString);
        }
    }
}
