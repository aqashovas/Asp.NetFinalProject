using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Areas.Manage.Helpers;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Areas.Manage.Controllers
{
    public class PatientFeedbacksController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/PatientFeedbacks
        public ActionResult Index()
        {
            return View(db.PatientFeedbacks.ToList());
        }

        // GET: Manage/PatientFeedbacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientFeedback patientFeedback = db.PatientFeedbacks.Find(id);
            if (patientFeedback == null)
            {
                return HttpNotFound();
            }
            return View(patientFeedback);
        }

        // GET: Manage/PatientFeedbacks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/PatientFeedbacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Name,Text")] PatientFeedback patientFeedback,HttpPostedFileBase Photo)
        {
            if (ModelState.IsValid)
            {
                patientFeedback.Photo = FileManager.Upload(Photo);
                db.PatientFeedbacks.Add(patientFeedback);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientFeedback);
        }

        // GET: Manage/PatientFeedbacks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientFeedback patientFeedback = db.PatientFeedbacks.Find(id);
            if (patientFeedback == null)
            {
                return HttpNotFound();
            }
            return View(patientFeedback);
        }

        // POST: Manage/PatientFeedbacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Name,Text")] PatientFeedback patientFeedback,HttpPostedFileBase Photo)
        {
            db.Entry(patientFeedback).State = EntityState.Modified;

            if (Photo == null)
            {
                db.Entry(patientFeedback).Property(a => a.Photo).IsModified = false;
            }
            else
            {
                FileManager.Delete(patientFeedback.Photo);

                patientFeedback.Photo = FileManager.Upload(Photo);
            }

            if (ModelState.IsValid)
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientFeedback);
        }

        // GET: Manage/PatientFeedbacks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientFeedback patientFeedback = db.PatientFeedbacks.Find(id);
            if (patientFeedback == null)
            {
                return HttpNotFound();
            }
            return View(patientFeedback);
        }

        // POST: Manage/PatientFeedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientFeedback patientFeedback = db.PatientFeedbacks.Find(id);
            FileManager.Delete(patientFeedback.Photo);
            db.PatientFeedbacks.Remove(patientFeedback);
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
