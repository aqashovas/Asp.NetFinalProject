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
    public class DepartmentsController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/Departments
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }

        // GET: Manage/Departments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // GET: Manage/Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/Departments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text,Photo,Slug,Address,Mail,Phone,CategoryName,HeadofDepartmentposition,HeadofDepartmentname,Facebook,Instagram,Twitter")] Department department,HttpPostedFileBase Photo)
        {
            if (ModelState.IsValid)
            {
                department.Photo = FileManager.Upload(Photo);
                db.Departments.Add(department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: Manage/Departments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Manage/Departments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text,Photo,Slug,Address,Mail,Phone,CategoryName,HeadofDepartmentposition,HeadofDepartmentname,Facebook,Instagram,Twitter")] Department department,HttpPostedFile Photo)
        {

            db.Entry(department).State = EntityState.Modified;

            if (Photo == null)
            {
                db.Entry(department).Property(a => a.Photo).IsModified = false;
            }
            else
            {
                FileManager.Delete(department.Photo);

                department.Photo = FileManager.Upload(Photo);
            }

            if (ModelState.IsValid)
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        // GET: Manage/Departments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Manage/Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = db.Departments.Find(id);
            FileManager.Delete(department.Photo);
            db.Departments.Remove(department);
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
