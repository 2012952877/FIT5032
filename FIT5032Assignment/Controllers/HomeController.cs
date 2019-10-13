using FIT5032Assignment.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032Assignment.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Send_Email()
        {
            return View(new SendEmailViewModel());
        }

        [HttpPost]
        public ActionResult Send_Email(SendEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;

                    //Get attachment
                    var attachment = Request.Files["attachment"];

                    //Check if customer has no attachment
                    if (attachment.FileName != "")
                    {
                        //Upload this attachment to local
                        var path = Path.Combine(Server.MapPath("~/Attachments/"), attachment.FileName);
                        attachment.SaveAs(path);

                        //Attach the attachment to email and send.
                        EmailSender es = new EmailSender();
                        es.SendWithAttachment(toEmail, subject, contents, path, attachment.FileName);
                    }
                    else
                    {
                        EmailSender es = new EmailSender();
                        es.Send(toEmail, subject, contents);
                    }       

                    ViewBag.Result = "Email has been send.";

                    ModelState.Clear();

                    return View(new SendEmailViewModel());
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }
    }
}