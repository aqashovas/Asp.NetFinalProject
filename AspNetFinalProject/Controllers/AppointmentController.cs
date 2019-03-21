using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.ViewModels;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Controllers

{
    public class AppointmentController : BaseController
    {
        // GET: Appointment
        public ActionResult Index()
        {
            VwAppointment model = new VwAppointment
            {
                Doctors=db.Doctors.ToList(),
                DepartmentCategories=db.DepartmentCategories.ToList(),
                Setting=db.Settings.FirstOrDefault()
            };
            
            return View(model);
        }
        [HttpPost]
        public ActionResult Book(Appointment appointment)
        {
            db.Appointments.Add(appointment);
            db.SaveChanges();


            return  RedirectToAction("index");
        }
    }
}