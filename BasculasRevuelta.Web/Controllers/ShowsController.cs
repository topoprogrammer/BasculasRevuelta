using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Data.EntityFramework.Sql;

namespace BasculasRevuelta.Web.Controllers
{
    public class ShowsController : Controller
    {
        private BasculasRevueltaDbContext db = new BasculasRevueltaDbContext();

        // GET: Shows
        public ActionResult Index()
        {
            var shows = db.Shows.Include(s => s.Tour);
            return View(shows.ToList());
        }

        // GET: Shows/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = db.Shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // GET: Shows/Create
        public ActionResult Create()
        {
            ViewBag.TourId = new SelectList(db.Tours, "TourId", "CreatedBy");
            return View();
        }

        // POST: Shows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowId,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,Date,Venue,City,Country,TourId")] Show show)
        {
            if (ModelState.IsValid)
            {
                show.ShowId = Guid.NewGuid();
                db.Shows.Add(show);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TourId = new SelectList(db.Tours, "TourId", "CreatedBy", show.TourId);
            return View(show);
        }

        // GET: Shows/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = db.Shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            ViewBag.TourId = new SelectList(db.Tours, "TourId", "CreatedBy", show.TourId);
            return View(show);
        }

        // POST: Shows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowId,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,Date,Venue,City,Country,TourId")] Show show)
        {
            if (ModelState.IsValid)
            {
                db.Entry(show).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TourId = new SelectList(db.Tours, "TourId", "CreatedBy", show.TourId);
            return View(show);
        }

        // GET: Shows/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = db.Shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // POST: Shows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Show show = db.Shows.Find(id);
            db.Shows.Remove(show);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
