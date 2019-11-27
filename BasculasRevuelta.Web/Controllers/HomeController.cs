using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasculasRevuelta.Data.EntityFramework.Sql;
using BasculasRevuelta.Data.EntityFramework.Sql.Core;

namespace BasculasRevuelta.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController()
        {
            //_dbContext = dbContext;
            _unitOfWork= new UnitOfWork();
            //_dbContext = new BasculasRevueltaDbContext();
        }

        public ActionResult Index()
        {
            //var list = _dbContext.Tours.ToList();
            var list = _unitOfWork.ShowRepository.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}