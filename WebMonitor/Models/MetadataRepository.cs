using System;
using System.Collections;
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

        public List<MetadataEntry> GetMetadataListWithLatestValidationResult(int? status, string organization, string resourceType)
        {
            var metadataEntries = new List<MetadataEntry>();

            NpgsqlConnection connection = GetConnection();
            connection.Open();
            try
            {
                var sql = SelectWhichSqlToUse(status, organization, resourceType);


                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("status", NpgsqlDbType.Integer) {Value = status});
                    command.Parameters.Add(new NpgsqlParameter("responsible_organization", NpgsqlDbType.Varchar) { Value = organization });
                    command.Parameters.Add(new NpgsqlParameter("resourcetype", NpgsqlDbType.Varchar) { Value = resourceType });

                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var metadataEntry = new MetadataEntry()
                                {
                                    InspireResource = dr.GetBoolean(4),
                                    ResourceType = dr.GetString(3),
                                    ResponsibleOrganization = dr.GetString(2),
                                    Title = dr.GetString(1),
                                    Uuid = dr.GetString(0),
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

        private string SelectWhichSqlToUse(int? status, string organization, string resourceType)
        {
            const string sqlBase = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "INNER JOIN " +
                    "(SELECT res.uuid, res.result, res.messages, res.timestamp " +
                    "FROM validation_results res " +
                    "WHERE (res.uuid, res.timestamp) IN " +
                        "(SELECT v.uuid, MAX(timestamp) as timestamp " +
                        "FROM validation_results v " +
                        "GROUP BY v.uuid) " +
                    " __RESULT_CONDITIONS__ " +
                    ") AS subQuery " +
                "ON subQuery.uuid = m.uuid " +
                " __META_CONDITIONS__ " +
                "ORDER BY subQuery.timestamp desc";
            /*

            const string sqlNoConditions = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " + 
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "INNER JOIN " +
                    "(SELECT res.uuid, res.result, res.messages, res.timestamp " +
                    "FROM validation_results res " +
                    "WHERE (res.uuid, res.timestamp) IN " +
                        "(SELECT v.uuid, MAX(timestamp) as timestamp " +
                        "FROM validation_results v " +
                        "GROUP BY v.uuid) " +
                    ") AS subQuery " +
                "ON subQuery.uuid = m.uuid " +
                "ORDER BY subQuery.timestamp desc";


            const string sqlWithStatus = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " + 
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "INNER JOIN " +
                    "(SELECT res.uuid, res.result, res.messages, res.timestamp " +
                    "FROM validation_results res " +
                    "WHERE (res.uuid, res.timestamp) IN " +
                        "(SELECT v.uuid, MAX(timestamp) as timestamp " +
                        "FROM validation_results v " +
                        "GROUP BY v.uuid) " +
                    "AND res.result = :status "+ 
                    ") AS subQuery " +
                "ON subQuery.uuid = m.uuid " +
                "ORDER BY subQuery.timestamp desc";

            const string sqlWithOrganization = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "INNER JOIN " +
                    "(SELECT res.uuid, res.result, res.messages, res.timestamp " +
                    "FROM validation_results res " +
                    "WHERE (res.uuid, res.timestamp) IN " +
                        "(SELECT v.uuid, MAX(timestamp) as timestamp " +
                        "FROM validation_results v " +
                        "GROUP BY v.uuid) " +
                    ") AS subQuery " +
                "ON subQuery.uuid = m.uuid " +
                "WHERE m.responsible_organization like :responsible_organization "+
                "ORDER BY subQuery.timestamp desc";

            const string sqlWithStatusAndOrganization = "SELECT m.uuid, m.title, m.responsible_organization, m.resourcetype, m.inspire_resource, " +
                "subQuery.result, subQuery.messages, subQuery.timestamp FROM metadata m " +
                "INNER JOIN " +
                    "(SELECT res.uuid, res.result, res.messages, res.timestamp " +
                    "FROM validation_results res " +
                    "WHERE (res.uuid, res.timestamp) IN " +
                        "(SELECT v.uuid, MAX(timestamp) as timestamp " +
                        "FROM validation_results v " +
                        "GROUP BY v.uuid) " +
                    "AND res.result = :status " + 
                    ") AS subQuery " +
                "ON subQuery.uuid = m.uuid " +
                "WHERE m.responsible_organization like :responsible_organization " +
                "ORDER BY subQuery.timestamp desc";
            */
            var sql = sqlBase;
            if (status.HasValue)
            {
                sql = sql.Replace("__RESULT_CONDITIONS__", "AND res.result = :status");
            }
            else
            {
                sql = sql.Replace("__RESULT_CONDITIONS__", "");
            }
            
            if (!string.IsNullOrWhiteSpace(organization))
            {
                if (!string.IsNullOrWhiteSpace(resourceType))
                {
                    sql = sql.Replace("__META_CONDITIONS__",
                                      "WHERE m.responsible_organization like :responsible_organization " +
                                      "AND m.resourcetype = :resourcetype");
                }
                else
                {
                    sql = sql.Replace("__META_CONDITIONS__",
                                      "WHERE m.responsible_organization like :responsible_organization ");
                }
            } 
            else if (!string.IsNullOrWhiteSpace(resourceType))
            {
                sql = sql.Replace("__META_CONDITIONS__", "WHERE m.resourcetype = :resourcetype");
            }
            else
            {
                sql = sql.Replace("__META_CONDITIONS__", "");
            }
            return sql;
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

            const string sql =
                "INSERT INTO validation_results (uuid, result, messages) VALUES (:uuid, :result, :messages)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.Add(new NpgsqlParameter("uuid", NpgsqlDbType.Varchar) {Value = metadata.Uuid});
                command.Parameters.Add(new NpgsqlParameter("result", NpgsqlDbType.Integer)
                    {
                        Value = validationResult.Result
                    });
                command.Parameters.Add(new NpgsqlParameter("messages", NpgsqlDbType.Varchar)
                    {
                        Value = validationResult.Messages
                    });
                command.ExecuteNonQuery();
            }
        }

        private void UpdateMetadataInformation(MetadataEntry metadata, NpgsqlConnection connection)
        {
            const string sql = "UPDATE metadata SET " +
                               "title = :title, " +
                               "responsible_organization = :responsible_organization, " +
                               "resourcetype = :resourcetype, " +
                               "inspire_resource = :inspire_resource " +
                               "WHERE uuid = :uuid";
            RunInsertUpdateMetadataCommand(metadata, sql, connection);
        }

        private void InsertMetadataInformation(MetadataEntry metadata, NpgsqlConnection connection)
        {
            const string sql =
                "INSERT INTO metadata (uuid, title, responsible_organization, resourcetype, inspire_resource) VALUES " +
                "(:uuid, :title, :responsible_organization, :resourcetype, :inspire_resource)";
            RunInsertUpdateMetadataCommand(metadata, sql, connection);
        }

        private static void RunInsertUpdateMetadataCommand(MetadataEntry metadata, string sql,
                                                           NpgsqlConnection connection)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.Add(new NpgsqlParameter("uuid", NpgsqlDbType.Varchar) {Value = metadata.Uuid});
                command.Parameters.Add(new NpgsqlParameter("title", NpgsqlDbType.Varchar) {Value = metadata.Title});
                command.Parameters.Add(new NpgsqlParameter("responsible_organization", NpgsqlDbType.Varchar)
                    {
                        Value = metadata.ResponsibleOrganization
                    });
                command.Parameters.Add(new NpgsqlParameter("resourcetype", NpgsqlDbType.Varchar)
                    {
                        Value = metadata.ResourceType
                    });
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
            using (
                NpgsqlCommand command = new NpgsqlCommand("SELECT count(uuid) FROM metadata WHERE uuid = :uuid",
                                                          connection))
            {
                command.Parameters.Add(new NpgsqlParameter("uuid", NpgsqlDbType.Varchar) {Value = uuid});
                var count = (System.Int64) command.ExecuteScalar();
                result = count != 0;
            }
            return result;
        }

        public IEnumerable<string> GetAvailableOrganizations()
        {
            const string sql = "SELECT DISTINCT responsible_organization FROM metadata";

            List<string> organizations = new List<string>();

            NpgsqlConnection connection = GetConnection();
            connection.Open();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            organizations.Add(dr.GetString(0));
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return organizations;
        }
    }
}