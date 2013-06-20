using System.Configuration;
using Microsoft.WindowsAzure;
using CloudStorageAccount = Microsoft.WindowsAzure.Storage.CloudStorageAccount;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    class CloudStorageUtil
    {
        public static CloudStorageAccount GetCloudStorageAccount()
        {

            string connectionString = null;
/*
            if (RoleEnvironment.IsAvailable)
                connectionString = RoleEnvironment.GetConfigurationSettingValue("StorageConnectionString");
            else
                //connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];
 * */

               // connectionString = CloudConfigurationManager.GetSetting("StorageConnectionString");
            if (ConfigurationManager.ConnectionStrings["StorageConnectionString"] != null)
                connectionString = ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString;
            else if (CloudConfigurationManager.GetSetting("StorageConnectionString") != null)
                connectionString = CloudConfigurationManager.GetSetting("StorageConnectionString");
            else if (ConfigurationManager.AppSettings["StorageConnectionString"] != null)
                connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

            return CloudStorageAccount.Parse(connectionString);
        }
    }
}
