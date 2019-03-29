using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Areas.Manage.Controllers
{
    public class EventhoursController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/Eventhours
        public ActionResult Index()
        {
            var eventhours = db.Eventhours.Include(e => e.Department);
            return View(eventhours.ToList());
        }

        // GET: Manage/Eventhours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventhour eventhour = db.Eventhours.Find(id);
            if (eventhour == null)
            {
                return HttpNotFound();
            }
            return View(eventhour);
        }

        // GET: Manage/Eventhours/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title");
            return View();
        }

        // POST: Manage/Eventhours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Thepersonincharge,DayTime,DepartmentId")] Eventhour eventhour)
        {
            if (ModelState.IsValid)
            {
                db.Eventhours.Add(eventhour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", eventhour.DepartmentId);
            return View(eventhour);
        }

        // GET: Manage/Eventhours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventhour eventhour = db.Eventhours.Find(id);
            if (eventhour == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", eventhour.DepartmentId);
            return View(eventhour);
        }

        // POST: Manage/Eventhours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Thepersonincharge,DayTime,DepartmentId")] Eventhour eventhour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventhour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", eventhour.DepartmentId);
            return View(eventhour);
        }

        // GET: Manage/Eventhours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventhour eventhour = db.Eventhours.Find(id);
            if (eventhour == null)
            {
                return HttpNotFound();
            }
            return View(eventhour);
        }

        // POST: Manage/Eventhours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Eventhour eventhour = db.Eventhours.Find(id);
            db.Eventhours.Remove(eventhour);
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
