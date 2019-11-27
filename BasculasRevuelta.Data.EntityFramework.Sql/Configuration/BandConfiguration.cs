using BasculasRevuelta.Common.Data.Models;

namespace BasculasRevuelta.Data.EntityFramework.Sql.Configuration
{
    // Bands
    public class BandConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Band>
    {
        public BandConfiguration()
            : this("dbo")
        {
        }

        public BandConfiguration(string schema)
        {
            ToTable("Bands", schema);
            HasKey(x => x.BandId);

            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.BandId).HasColumnName(@"BandId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
        }
    }

}
