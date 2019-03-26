using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Controllers
{
    public class DoctorsController : BaseController
    {
        // GET: Doctors
        public ActionResult Index()
        {
            var doctors = db.Doctors.ToList();
            return View(doctors);
        }
        public ActionResult Details(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return HttpNotFound();
            }

            var doctor = db.Doctors.FirstOrDefault(s => s.Slug == slug);

            if (doctor == null)
            {
                return HttpNotFound();
            }

            ViewBag.Doctors = db.Doctors.ToList();

            return View(doctor);
        }
    }
}