using AspNetFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Models;

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
        public JsonResult Message(string name, string email, string tel, string country, string message,Question question)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message))
            {
                Response.StatusCode = 406;
                return Json("Name,Email and Message is required", JsonRequestBehavior.AllowGet);
            }

            var body = "<ul><li>Name : {0}</li><li>Email : {1}</li><li>Phone : {2}</li><li>Country : {3}</li></ul><p>{4}</p>";
            var MailMessage = new MailMessage();
            MailMessage.To.Add(new MailAddress("aqashova0@gmail.com"));  // replace with valid value 
            MailMessage.From = new MailAddress(email);  // replace with valid value
            MailMessage.Subject = "Your email subject";
            MailMessage.Body = string.Format(body, name, email, tel, country, message);
            MailMessage.IsBodyHtml = true;

            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential
                {
                    UserName = "",  // replace with valid value
                    Password = ""  // replace with valid value
                }
            };

            client.Send(MailMessage);
            db.Questions.Add(question);
            db.SaveChanges();

            return Json("Your message sent,thanks", JsonRequestBehavior.AllowGet);
        }
    }
}