using BasculasRevuelta.Common.Data.Models;

namespace BasculasRevuelta.Data.EntityFramework.Sql.Configuration
{
    public class TourConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tour>
    {
        public TourConfiguration()
            : this("dbo")
        {
        }

        public TourConfiguration(string schema)
        {
            ToTable("Tours", schema);
            HasKey(x => x.TourId);

            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.TourId).HasColumnName(@"TourId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(2000);
            Property(x => x.EstimatedProfits).HasColumnName(@"EstimatedProfits").HasColumnType("decimal").IsRequired().HasPrecision(18, 2);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetimeoffset").IsRequired();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetimeoffset").IsRequired();
            Property(x => x.BandId).HasColumnName(@"BandId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ManagerId).HasColumnName(@"ManagerId").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            HasRequired(a => a.Band).WithMany(b => b.Tours).HasForeignKey(c => c.BandId); // FK_Tours_Bands_BandId
            HasRequired(a => a.Manager).WithMany(b => b.Tours).HasForeignKey(c => c.ManagerId); // FK_Tours_Managers_ManagerId
        }
    }
}