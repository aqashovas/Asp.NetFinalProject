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
    public class ExpertInsController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/ExpertIns
        public ActionResult Index()
        {
            var expertIns = db.ExpertIns.Include(e => e.Speciality);
            return View(expertIns.ToList());
        }

        // GET: Manage/ExpertIns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpertIn expertIn = db.ExpertIns.Find(id);
            if (expertIn == null)
            {
                return HttpNotFound();
            }
            return View(expertIn);
        }

        // GET: Manage/ExpertIns/Create
        public ActionResult Create()
        {
            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name");
            return View();
        }

        // POST: Manage/ExpertIns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,SpecialityId")] ExpertIn expertIn)
        {
            if (ModelState.IsValid)
            {
                db.ExpertIns.Add(expertIn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name", expertIn.SpecialityId);
            return View(expertIn);
        }

        // GET: Manage/ExpertIns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpertIn expertIn = db.ExpertIns.Find(id);
            if (expertIn == null)
            {
                return HttpNotFound();
            }
            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name", expertIn.SpecialityId);
            return View(expertIn);
        }

        // POST: Manage/ExpertIns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,SpecialityId")] ExpertIn expertIn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expertIn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name", expertIn.SpecialityId);
            return View(expertIn);
        }

        // GET: Manage/ExpertIns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpertIn expertIn = db.ExpertIns.Find(id);
            if (expertIn == null)
            {
                return HttpNotFound();
            }
            return View(expertIn);
        }

        // POST: Manage/ExpertIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpertIn expertIn = db.ExpertIns.Find(id);
            db.ExpertIns.Remove(expertIn);
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
