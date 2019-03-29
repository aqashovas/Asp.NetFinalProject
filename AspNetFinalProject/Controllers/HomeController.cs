using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            VwHome model = new VwHome
            {
                Doctors = db.Doctors.Include("Speciality").Include("Speciality.ExpertIns").Include("Speciality.DepartmentCategory").ToList(),
                DepartmentCategories = db.DepartmentCategories.ToList(),
                Setting = db.Settings.FirstOrDefault(),
                PatientFeedbacks=db.PatientFeedbacks.ToList(),
                Promedis=db.Promedis.Take(3).ToList(),
                Counters=db.Counters.ToList(),
                Blogs=db.Blogs.Include("Author").ToList(),
                About = db.Abouts.OrderBy(d => d.Id).Skip(1).Take(1).First(),
                Slider1 =db.Sliders.OrderBy(i=>i.Id).Take(1).First(),
                Slider2=db.Sliders.OrderBy(i => i.Id).Skip(1).Take(1).First(),
                Slider3=db.Sliders.OrderBy(i => i.Id).Skip(2).Take(1).First()
            };
            return View(model);
        }

       
    }
}