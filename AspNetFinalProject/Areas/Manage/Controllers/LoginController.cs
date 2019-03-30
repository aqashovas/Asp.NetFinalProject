using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AspNetFinalProject.Areas.Manage.Controllers
{
    public class LoginController : Controller
    {
        PromediHospitalContext db = new PromediHospitalContext();
        // GET: Manage/Login
        public ActionResult Index()
        {
            if (Session["AdminLogin"] != null)
            {
                return RedirectToAction("index", "dashboard");
            }
           
            return View();
        }
        public ActionResult Login(Admin admin)
        {
            if (string.IsNullOrEmpty(admin.Email) || string.IsNullOrEmpty(admin.Password))
            {
                Session["LoginError"] = "Fill mail and password";
                return RedirectToAction("index");
            }

            Admin adm = db.Admins.FirstOrDefault(a => a.Email == admin.Email);
            if (adm != null)
            {
                if (Crypto.VerifyHashedPassword(adm.Password, admin.Password))
                {
                    Session["AdminLogin"] = true;
                    Session["Admin"] = adm;
                    return RedirectToAction("index", "dashboard");
                }
            }

            Session["LoginError"] = "Email or password incorrect";
            return RedirectToAction("index");
        }

    }
}