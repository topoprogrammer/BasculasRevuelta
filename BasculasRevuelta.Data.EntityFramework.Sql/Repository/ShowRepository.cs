using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Data.EntityFramework.Sql.Core;

namespace BasculasRevuelta.Data.EntityFramework.Sql.Repository
{
    internal class ShowRepository : GeneralRepository<Show>
    {
        private BasculasRevueltaDbContext _context;

        public ShowRepository(BasculasRevueltaDbContext context) : base(context)
        {
            _context = context;
        }

        public void ConsultaCompleja()
        {
            var showsFromCanada = _context.Shows.Where(x => x.City == "Canada");
        }
    }
}
