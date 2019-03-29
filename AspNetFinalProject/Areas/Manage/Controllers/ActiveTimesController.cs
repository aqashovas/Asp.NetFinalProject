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
    public class ActiveTimesController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/ActiveTimes
        public ActionResult Index()
        {
            return View(db.ActiveTimes.ToList());
        }

        // GET: Manage/ActiveTimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveTime activeTime = db.ActiveTimes.Find(id);
            if (activeTime == null)
            {
                return HttpNotFound();
            }
            return View(activeTime);
        }

        // GET: Manage/ActiveTimes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/ActiveTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Day,Time")] ActiveTime activeTime)
        {
            if (ModelState.IsValid)
            {
                db.ActiveTimes.Add(activeTime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activeTime);
        }

        // GET: Manage/ActiveTimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveTime activeTime = db.ActiveTimes.Find(id);
            if (activeTime == null)
            {
                return HttpNotFound();
            }
            return View(activeTime);
        }

        // POST: Manage/ActiveTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Day,Time")] ActiveTime activeTime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activeTime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activeTime);
        }

        // GET: Manage/ActiveTimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveTime activeTime = db.ActiveTimes.Find(id);
            if (activeTime == null)
            {
                return HttpNotFound();
            }
            return View(activeTime);
        }

        // POST: Manage/ActiveTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActiveTime activeTime = db.ActiveTimes.Find(id);
            db.ActiveTimes.Remove(activeTime);
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
