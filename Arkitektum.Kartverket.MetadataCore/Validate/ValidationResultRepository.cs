using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace Arkitektum.Kartverket.MetadataCore.Validate
{
    public class ValidationResultRepository
    {
        public void SaveValidationResult(ValidationResult validationResult)
        {
            Trace.WriteLine(string.Format("Saving validation result for [uuid={0}] [result={1}] ", 
                validationResult.RowKey, validationResult.ValidateOk));
            
            var table = GetCloudTable();
            TableOperation insertOperation = TableOperation.InsertOrMerge(validationResult);
            try
            {
                table.Execute(insertOperation);
            }
            catch (StorageException e)
            {
                Trace.WriteLine("Exception while saving validation result: " + e.Message);   
            }
        }

        public IEnumerable<ValidationResult> GetValidationResults()
        {
            var table = GetCloudTable();
            var query = new TableQuery<ValidationResult>()
                .Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "GeoNorge"));

            return table.ExecuteQuery(query);
        }

        private CloudTable GetCloudTable()
        {
            CloudTableClient tableClient = CloudStorageUtil.GetCloudStorageAccount().CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference("validations");
            table.CreateIfNotExists();
            return table;
        }
    }
}