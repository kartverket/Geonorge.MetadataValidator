using System.Data.Entity;

namespace Arkitektum.Kartverket.MetadataMonitor.Models
{
    public class MonitorDatabaseContext : DbContext
    {
        public DbSet<MetadataEntry> MetadataEntries { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


    }
}