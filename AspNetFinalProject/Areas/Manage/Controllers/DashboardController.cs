using AspNetFinalProject.Areas.Manage.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Areas.Manage.Controllers
{
    [Auth]
    public class DashboardController : Controller
    {
        // GET: Manage/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}