using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Data.EntityFramework.Sql.Configuration;
using BasculasRevuelta.Data.EntityFramework.Sql.Repository;

namespace BasculasRevuelta.Data.EntityFramework.Sql
{
    public class BasculasRevueltaDbContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Band> Bands { get; set; } // Bands
        public System.Data.Entity.DbSet<Manager> Managers { get; set; } // Managers
        public System.Data.Entity.DbSet<Show> Shows { get; set; } // Shows
        public System.Data.Entity.DbSet<Tour> Tours { get; set; } // Tours

        public int Commit()
        {
            return this.SaveChanges();
        }


        static BasculasRevueltaDbContext()
        {
            System.Data.Entity.Database.SetInitializer<BasculasRevueltaDbContext>(null);
        }

        public BasculasRevueltaDbContext()
            : base("Name=BascualasEjemplo")
        {
        }

        public BasculasRevueltaDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public BasculasRevueltaDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public BasculasRevueltaDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public BasculasRevueltaDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public BasculasRevueltaDbContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BandConfiguration());

            modelBuilder.Configurations.Add(new ManagerConfiguration());
            modelBuilder.Configurations.Add(new ShowConfiguration());
            modelBuilder.Configurations.Add(new TourConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BandConfiguration(schema));
            modelBuilder.Configurations.Add(new ManagerConfiguration(schema));
            modelBuilder.Configurations.Add(new ShowConfiguration(schema));
            modelBuilder.Configurations.Add(new TourConfiguration(schema));
            return modelBuilder;
        }
    }
}
