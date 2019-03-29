using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class DepartmentController : BaseController
    {
        // GET: Department
        public ActionResult Details(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return HttpNotFound();
            }

            var department = db.Departments.FirstOrDefault(s => s.Slug == slug);

            if (department == null)
            {
                return HttpNotFound();
            }

            ViewBag.Department = db.Departments.Include("Eventhours").ToList();

            
            return View(department);
        }
    }
}