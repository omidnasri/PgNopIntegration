using System;
using Septa.PgNopIntegration.Plugin.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Septa.PgNopIntegration.Plugin.Data
{
    public partial class PgProductMetaDataMap : EntityTypeConfiguration<PgProductMetaData>
    {
        public PgProductMetaDataMap()
        {
            // Table & Collumn Mappings
            this.ToTable("PgProductMetaData");
            this.Property(p => p.NopProductId).HasColumnName("NopProductId");
            this.Property(p => p.PgProductCode).HasColumnName("PgProductCode");
            this.Property(p => p.LastSyncDate).HasColumnName("LastSyncDate");

            // Primary Key
            this.HasKey(p => p.Id);
        }
    }
}
