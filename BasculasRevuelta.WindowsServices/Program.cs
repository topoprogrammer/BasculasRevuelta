using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Common.Data.ViewModel;
using BasculasRevuelta.Data.EntityFramework.Sql;
using BasculasRevuelta.Data.EntityFramework.Sql.Core;

namespace BasculasRevuelta.WindowsServices
{
    class Program
    {

        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork= new UnitOfWork();
            //Show show = Show.GetCreateShow();
            //show.ShowId = Guid.NewGuid();

            /*
            Tour tour= Tour.GetCreateShow(new List<Show>()
            {
                Show.GetCreateShow(new ShowForCreation
                {
                    
                })
            })

            unitOfWork.ShowRepository.Add(show);
            unitOfWork.SaveChanges();

            */

            Console.ReadLine();
        }
    }
}
