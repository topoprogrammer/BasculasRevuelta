    using BasculasRevuelta.Common.Data.Models;

namespace BasculasRevuelta.Data.EntityFramework.Sql.Configuration
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class ManagerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Manager>
    {
        public ManagerConfiguration()
            : this("dbo")
        {
        }

        public ManagerConfiguration(string schema)
        {
            ToTable("Managers", schema);
            HasKey(x => x.ManagerId);

            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ManagerId).HasColumnName(@"ManagerId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}