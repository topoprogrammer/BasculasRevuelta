using System;
using System.Threading;
using System.Threading.Tasks;
using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Data.EntityFramework.Sql.Repository;

namespace BasculasRevuelta.Data.EntityFramework.Sql.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Show> ShowRepository { get; }
        int SaveChanges();


        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
