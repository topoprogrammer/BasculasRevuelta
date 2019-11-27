using BasculasRevuelta.Common.Data.Models;

namespace BasculasRevuelta.Data.EntityFramework.Sql.Configuration
{
    public class ShowConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Show>
    {
        public ShowConfiguration()
            : this("dbo")
        {
        }

        public ShowConfiguration(string schema)
        {
            ToTable("Shows", schema);
            HasKey(x => x.ShowId);

            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ShowId).HasColumnName(@"ShowId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetimeoffset").IsRequired();
            Property(x => x.Venue).HasColumnName(@"Venue").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.TourId).HasColumnName(@"TourId").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            HasRequired(a => a.Tour).WithMany(b => b.Shows).HasForeignKey(c => c.TourId); // FK_Shows_Tours_TourId
        }
    }
}