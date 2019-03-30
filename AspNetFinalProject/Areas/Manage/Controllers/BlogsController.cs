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
    public class BlogsController : Controller
    {
        private PromediHospitalContext db = new PromediHospitalContext();

        // GET: Manage/Blogs
        public ActionResult Index()
        {
            var blogs = db.Blogs.Include(b => b.Author);
            return View(blogs.ToList());
        }

        // GET: Manage/Blogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // GET: Manage/Blogs/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            return View();
        }

        // POST: Manage/Blogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,AuthorId,Text,Title,Date,CategoryId,Slug,Postedby,SpecialText,Moretext")] Blog blog,HttpPostedFileBase Photo)
        {
            if (ModelState.IsValid)
            {
                blog.Photo = FileManager.Upload(Photo);

                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", blog.AuthorId);
            return View(blog);
        }

        // GET: Manage/Blogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", blog.AuthorId);
            return View(blog);
        }

        // POST: Manage/Blogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,AuthorId,Text,Title,Date,CategoryId,Slug,Postedby,SpecialText,Moretext")] Blog blog,HttpPostedFileBase Photo)
        {
            db.Entry(blog).State = EntityState.Modified;

            if (Photo == null)
            {
                db.Entry(blog).Property(a => a.Photo).IsModified = false;
            }
            else
            {
                FileManager.Delete(blog.Photo);

                blog.Photo = FileManager.Upload(Photo);
            }

            if (ModelState.IsValid)
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", blog.AuthorId);
            return View(blog);
        }

        // GET: Manage/Blogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Manage/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog blog = db.Blogs.Find(id);
            FileManager.Delete(blog.Photo);
            db.Blogs.Remove(blog);
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
