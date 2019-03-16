using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Controllers
{
    public class BaseController : Controller
    {
        protected readonly PromediHospitalContext db = new PromediHospitalContext();
        // GET: Base

    }
}