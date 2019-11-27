using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Data.EntityFramework.Sql.Core;
using BasculasRevuelta.Data.EntityFramework.Sql.Repository;

namespace BasculasRevuelta.Data.EntityFramework.Sql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BasculasRevueltaDbContext _context;
        // Del tipo de la base de datos legada
        private readonly BasculasRevueltaDbContext _contextViejo;

        private IRepository<Show> _showRepository;

        public IRepository<Show> ShowRepository =>
            _showRepository ?? (_showRepository =
                new GeneralRepository<Show>(_context));



        public UnitOfWork()
        {
            _context = new BasculasRevueltaDbContext();
            // Del tipo de la base de datos legada
            _contextViejo = new BasculasRevueltaDbContext();
        }

        public void Dispose()
        {
            _showRepository = null;
        }



        public int SaveChanges()
        {
            //Transaccional
            int registrosAfectados = 0;

            try
            {
                //Empieza Transaccion
                registrosAfectados = _context.SaveChanges();
                _contextViejo.SaveChanges();
                //Finaliza Transaccion
            }
            catch (Exception e)
            {
                //Rollback
                Console.WriteLine(e);
                //throw;
            }


            return registrosAfectados;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
