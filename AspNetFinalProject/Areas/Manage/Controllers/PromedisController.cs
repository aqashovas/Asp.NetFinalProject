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
    public class PromedisController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/Promedis
        public ActionResult Index()
        {
            return View(db.Promedis.ToList());
        }

        // GET: Manage/Promedis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promedi promedi = db.Promedis.Find(id);
            if (promedi == null)
            {
                return HttpNotFound();
            }
            return View(promedi);
        }

        // GET: Manage/Promedis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/Promedis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Logo,Photo,Text")] Promedi promedi)
        {
            if (ModelState.IsValid)
            {
                db.Promedis.Add(promedi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promedi);
        }

        // GET: Manage/Promedis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promedi promedi = db.Promedis.Find(id);
            if (promedi == null)
            {
                return HttpNotFound();
            }
            return View(promedi);
        }

        // POST: Manage/Promedis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Logo,Photo,Text")] Promedi promedi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promedi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promedi);
        }

        // GET: Manage/Promedis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promedi promedi = db.Promedis.Find(id);
            if (promedi == null)
            {
                return HttpNotFound();
            }
            return View(promedi);
        }

        // POST: Manage/Promedis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Promedi promedi = db.Promedis.Find(id);
            db.Promedis.Remove(promedi);
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
