using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class DoctorsController : BaseController
    {
        // GET: Doctors
        public ActionResult Index()
        {
            //VwDoctor model = new VwDoctor
            //{
            //   Doctor=db.Doctors.ToList(),

            //};
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}