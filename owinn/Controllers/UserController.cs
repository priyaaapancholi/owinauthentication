using owinn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace owinn.Controllers
{
    public class UserController : Controller
    {

       UserContext db = new UserContext();
        // GET: Default
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }


        [HttpGet]
        public ActionResult Registe()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registe([Bind(Include = "Id,UserName,Email,DOB,Address,Password")] User Users)
        {

            if (ModelState.IsValid)
            {



                var user = new User();
                user.Email = Users.Email;
                user.EmailConfirmed = false;
               
                MailMessage m = new MailMessage(
                new MailAddress("karan.desai@promactinfo.com", "priya pancholi"),
                new MailAddress(user.Email));
                m.Subject = "Email confirmation";
                m.Body = string.Format("Thank you for your registration");
                m.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient("webmail.promactinfo.com");
                smtp.Credentials = new NetworkCredential("karan.desai@promactinfo.com", "Ibx(mAMZs_6zY+_q");
           
                ServicePointManager.ServerCertificateValidationCallback =
                  delegate (object s, X509Certificate certificate,
                X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
                smtp.EnableSsl = true;

                smtp.Port = 25;
                smtp.Send(m);

               
            }
            
            return View(Users);
        }

    }
}