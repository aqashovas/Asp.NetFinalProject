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
    public class DepartmentCategoriesController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/DepartmentCategories
        public ActionResult Index()
        {
            return View(db.DepartmentCategories.ToList());
        }

        // GET: Manage/DepartmentCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmentCategory departmentCategory = db.DepartmentCategories.Find(id);
            if (departmentCategory == null)
            {
                return HttpNotFound();
            }
            return View(departmentCategory);
        }

        // GET: Manage/DepartmentCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/DepartmentCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Logo,Text")] DepartmentCategory departmentCategory)
        {
            if (ModelState.IsValid)
            {
                db.DepartmentCategories.Add(departmentCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departmentCategory);
        }

        // GET: Manage/DepartmentCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmentCategory departmentCategory = db.DepartmentCategories.Find(id);
            if (departmentCategory == null)
            {
                return HttpNotFound();
            }
            return View(departmentCategory);
        }

        // POST: Manage/DepartmentCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Logo,Text")] DepartmentCategory departmentCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departmentCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departmentCategory);
        }

        // GET: Manage/DepartmentCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmentCategory departmentCategory = db.DepartmentCategories.Find(id);
            if (departmentCategory == null)
            {
                return HttpNotFound();
            }
            return View(departmentCategory);
        }

        // POST: Manage/DepartmentCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DepartmentCategory departmentCategory = db.DepartmentCategories.Find(id);
            db.DepartmentCategories.Remove(departmentCategory);
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
