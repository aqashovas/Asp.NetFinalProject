﻿using System;
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
    public class DoctorsController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/Doctors
        public ActionResult Index()
        {
            var doctors = db.Doctors.Include(d => d.Speciality);
            return View(doctors.ToList());
        }

        // GET: Manage/Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Manage/Doctors/Create
        public ActionResult Create()
        {
            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name");
            return View();
        }

        // POST: Manage/Doctors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Moretext,FullName,Photo,BigPhoto,Address,Phone,Mail,Degree,Slug,Facebook,Instagram,Linkedin,Twitter,SpecialityId")] Doctor doctor,HttpPostedFileBase Photo1, HttpPostedFileBase Photo2)
        {
            if (ModelState.IsValid)
            {
                doctor.Photo = FileManager.Upload(Photo1);
                doctor.BigPhoto = FileManager.Upload(Photo2);

                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name", doctor.SpecialityId);
            return View(doctor);
        }

        // GET: Manage/Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name", doctor.SpecialityId);
            return View(doctor);
        }

        // POST: Manage/Doctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Moretext,FullName,Photo,BigPhoto,Address,Phone,Mail,Degree,Slug,Facebook,Instagram,Linkedin,Twitter,SpecialityId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SpecialityId = new SelectList(db.Specialities, "Id", "Name", doctor.SpecialityId);
            return View(doctor);
        }

        // GET: Manage/Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Manage/Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor doctor = db.Doctors.Find(id);
            FileManager.Delete(doctor.Photo);
            FileManager.Delete(doctor.BigPhoto);
            db.Doctors.Remove(doctor);
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
