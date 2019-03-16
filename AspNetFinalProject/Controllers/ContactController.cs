using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            VwContact model = new VwContact
            {
                Setting = db.Settings.FirstOrDefault(),
                ActiveTimes = db.ActiveTimes.ToList()
            };
            return View(model);
        }
    }
}