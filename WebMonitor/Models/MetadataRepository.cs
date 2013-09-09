using System;
using System.Collections.Generic;
using System.Configuration;
using Npgsql;
using NpgsqlTypes;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class MetadataRepository
    {
        private readonly string _connectionString;

        public MetadataRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MonitorDatabaseContext"].ConnectionString;
        }

        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public List<MetadataEntry> GetMetadataListWithLatestValidationResult(int? status, string organization)
        {
            var metadataEntries = new List<MetadataEntry>();

            NpgsqlConnection connection = GetConnection();
            connection.Open();
            try
            {
                var sql = SelectWhichSqlToUse(status, organization);


                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var metadataEntry = new MetadataEntry()
                                {
                                    InspireResource = (bool) dr["inspire_resource"],
                                    ResourceType = (string) dr["resourcetype"],
                                    ResponsibleOrganization = (string) dr["responsible_organization"],
                                    Title = (string) dr["title"],
                                    Uuid = (string) dr["uuid"],
                                    ValidationResults = new List<ValidationResult>()
                                        {
                                            new ValidationResult()
                                                {
                                                    Messages = dr.IsDBNull(6) ? null : dr.GetString(6),
                                                    Result = dr.GetInt32(5),
                                                    Timestamp = dr.GetTimeStamp(7)
                                                }
                                        }
                                };
                            metadataEntries.Add(metadataEntry);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return metadataEntries;
        }

        private string SelectWhichSqlToUse(int? status, string organization)
        {
            const string sqlNoConditions = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                   "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                   "LEFT OUTER JOIN " +
                   "(SELECT v.uuid, v.result, v.messages, MAX(timestamp) as timestamp " +
                   "FROM validation_results v " +
                   "GROUP BY v.uuid, v.result, v.messages) AS subQuery " +
                   "ON subQuery.uuid = m.uuid";

            // TODO - ADD FILTERING TO SQL STATEMENTS!!

            const string withStatus = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "LEFT OUTER JOIN " +
                "(SELECT v.uuid, v.result, v.messages, MAX(timestamp) as timestamp " +
                "FROM validation_results v " +
                "GROUP BY v.uuid, v.result, v.messages) AS subQuery " +
                "ON subQuery.uuid = m.uuid";

            const string sqlWithOrganization = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "LEFT OUTER JOIN " +
                "(SELECT v.uuid, v.result, v.messages, MAX(timestamp) as timestamp " +
                "FROM validation_results v " +
                "GROUP BY v.uuid, v.result, v.messages) AS subQuery " +
                "ON subQuery.uuid = m.uuid";

            const string sqlWithStatusAndOrganization = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "LEFT OUTER JOIN " +
                "(SELECT v.uuid, v.result, v.messages, MAX(timestamp) as timestamp " +
                "FROM validation_results v " +
                "GROUP BY v.uuid, v.result, v.messages) AS subQuery " +
                "ON subQuery.uuid = m.uuid";


            if (status.HasValue)
            {
                if (string.IsNullOrWhiteSpace(organization))
                {
                    return withStatus;
                }
                else
                {
                    return sqlWithStatusAndOrganization;
                }
            } else if (!string.IsNullOrWhiteSpace(organization))
            {
                return sqlWithOrganization;
            }
            else
            {
                return sqlNoConditions;
            }



        }

        public void SaveMetadata(MetadataEntry metadata)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();
            NpgsqlTransaction transaction = connection.BeginTransaction();
            try
            {
                if (MetadataExists(metadata.Uuid, connection))
                {
                    UpdateMetadataInformation(metadata, connection);
                }
                else
                {
                    InsertMetadataInformation(metadata, connection);
                }

                InsertMetadataValidationResult(metadata, connection);
                
                transaction.Commit();
            }
            finally
            {
                connection.Close();
            }
        }

        private void InsertMetadataValidationResult(MetadataEntry metadata, NpgsqlConnection connection)
        {
            var validationResult = metadata.ValidationResults[0];

            const string sql = "INSERT INTO validation_results (uuid, result, messages) VALUES (:uuid, :result, :messages)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.Add(new NpgsqlParameter("uuid", NpgsqlDbType.Varchar) {Value = metadata.Uuid});
                command.Parameters.Add(new NpgsqlParameter("result", NpgsqlDbType.Integer) { Value = validationResult.Result });
                command.Parameters.Add(new NpgsqlParameter("messages", NpgsqlDbType.Varchar) { Value = validationResult.Messages });
                command.ExecuteNonQuery();
            }
        }

        private void UpdateMetadataInformation(MetadataEntry metadata, NpgsqlConnection connection)
        {
            const string sql = "UPDATE metadata SET " +
                               "title = :title, " +
                               "responsible_organization = responsible_organization, " +
                               "resourcetype = :resourcetype, " +
                               "inspire_resource = inspire_resource " +
                               "WHERE uuid = :uuid";
            RunInsertUpdateMetadataCommand(metadata, sql, connection);
        }

        private void InsertMetadataInformation(MetadataEntry metadata, NpgsqlConnection connection)
        {
            const string sql = "INSERT INTO metadata (uuid, title, responsible_organization, resourcetype, inspire_resource) VALUES " +
                               "(:uuid, :title, :responsible_organization, :resourcetype, :inspire_resource)";
            RunInsertUpdateMetadataCommand(metadata, sql, connection);
        }

        private static void RunInsertUpdateMetadataCommand(MetadataEntry metadata, string sql, NpgsqlConnection connection)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.Add(new NpgsqlParameter("uuid", NpgsqlDbType.Varchar) {Value = metadata.Uuid});
                command.Parameters.Add(new NpgsqlParameter("title", NpgsqlDbType.Varchar) {Value = metadata.Title});
                command.Parameters.Add(new NpgsqlParameter("responsible_organization", NpgsqlDbType.Varchar)
                    {
                        Value = metadata.ResponsibleOrganization
                    });
                command.Parameters.Add(new NpgsqlParameter("resourcetype", NpgsqlDbType.Varchar) {Value = metadata.ResourceType});
                command.Parameters.Add(new NpgsqlParameter("inspire_resource", NpgsqlDbType.Boolean)
                    {
                        Value = metadata.InspireResource
                    });
                command.ExecuteNonQuery();
            }
        }

        private bool MetadataExists(string uuid, NpgsqlConnection connection)
        {
            bool result;
            using(NpgsqlCommand command = new NpgsqlCommand("SELECT count(uuid) FROM metadata WHERE uuid = :uuid", connection))
            {
                command.Parameters.Add(new NpgsqlParameter("uuid", NpgsqlDbType.Varchar) { Value = uuid });
                var count = (System.Int64) command.ExecuteScalar();
                result = count != 0;
            }
            return result;
        }

    }
}