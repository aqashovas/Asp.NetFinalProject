using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class BlogsController : BaseController
    {
        // GET: Blogs
        public ActionResult Index(int? category,int page=1)
        {
            VwBlog model = new VwBlog();
            model.BlogCategories = db.BlogCategories.ToList();
            model.Category = category;
            model.Tags = db.Tags.ToList();
            model.LatestBlogs = db.Blogs.OrderByDescending(d => d.Date).Take(4).ToList();
            model.Blogs = db.Blogs.Include("Author").OrderByDescending(d => d.Date).Skip((page - 1) * 4).Take(4).ToList();
            model.TotalPage =Convert.ToInt32(Math.Ceiling(db.Blogs.Count()/4.0));

            if (page < 1 || page > model.TotalPage)
            {
                return HttpNotFound();
            }

            model.Page = page;
            return View(model);
        }
        public ActionResult Details(string Slug)
        {
            if (string.IsNullOrEmpty(Slug))
            {
                return HttpNotFound();
            }

            var blog = db.Blogs.Include("Author").FirstOrDefault(s => s.Slug == Slug);

            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.Blogs = db.Blogs.Include("Tags").Include("BlogCategory").ToList();

            return View(blog);
        }
    }
}