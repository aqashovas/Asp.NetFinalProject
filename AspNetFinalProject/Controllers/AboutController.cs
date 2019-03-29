using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            VwAbout model = new VwAbout
            {
                About = db.Abouts.FirstOrDefault(),
                Counters = db.Counters.ToList(),
                Promedismini=db.Promedis.Take(3).ToList(),
                Promedisall=db.Promedis.ToList(),
                PatientFeedbacks=db.PatientFeedbacks.ToList(),
                Doctors = db.Doctors.Include("Speciality").Include("Speciality.ExpertIns").Include("Speciality.DepartmentCategory").ToList()
        };
            return View(model);
        }
    }
}