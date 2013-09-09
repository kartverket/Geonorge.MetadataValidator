using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Npgsql;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class ValidationResultRepository
    {

        public void SaveValidationResult(ValidationResult validationResult)
        {
            /*
            Trace.WriteLine(string.Format("Saving validation result for [uuid={0}] [result={1}] ", 
                validationResult.RowKey, validationResult.ValidateResult));
            
            var table = GetCloudTable();
            TableOperation insertOperation = TableOperation.InsertOrReplace(validationResult);
            try
            {
                table.Execute(insertOperation);
            }
            catch (StorageException e)
            {
                Trace.WriteLine("Exception while saving validation result: " + e.Message);   
            }*/
        }

        public IEnumerable<ValidationResult> GetValidationResults(int? status, string organization)
        {/*
            var table = GetCloudTable();
            string baseFilter = TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "GeoNorge");

            string statusFilter = null;
            string organizationFilter = null;
            
            if (status.HasValue)
            {
                statusFilter = TableQuery.GenerateFilterConditionForInt("ValidateResult", QueryComparisons.Equal, status.Value);
            }
            if (organization != null && !string.IsNullOrWhiteSpace(organization))
            {
                organizationFilter = TableQuery.GenerateFilterCondition("Organization", QueryComparisons.Equal, organization);
            }
            
            var filter = baseFilter;

            if (statusFilter != null)
            {
                filter = TableQuery.CombineFilters(filter, TableOperators.And, statusFilter);
            }
            if (organizationFilter != null)
            {
                filter = TableQuery.CombineFilters(filter, TableOperators.And, organizationFilter);
            }

            var query = new TableQuery<ValidationResult>().Where(filter);

            return table.ExecuteQuery(query).ToArray(); // ToArray() forces execution of query
          * */
            return null;
        }

        public IEnumerable<string> GetAvailableOrganizations()
        {
            /*
            var table = GetCloudTable();
            string baseFilter = TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "GeoNorge");
            
            var query = new TableQuery<ValidationResult>().Where(baseFilter);

            var results = table.ExecuteQuery(query);

            IDictionary<string, bool> organizations = new Dictionary<string, bool>();
            foreach (var element in results)
            {
                if (!organizations.ContainsKey(element.Organization))
                    organizations.Add(element.Organization, true);
            }

            var organizationsInAList = new List<string>(organizations.Keys);
            organizationsInAList.Sort();
            return organizationsInAList;
             * */
            return null;
        }
    }
}