using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DKartTest.Models;
using System.IO;

namespace DKartTest.Controllers
{    
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/CreateDonor
        [HttpGet]
        public ActionResult CreateDonor()
        {
            return View();
        }

        //
        // POST: /Home/CreateDonor
        [HttpPost]
        public ActionResult CreateDonor(DonorModel donor)
        {
            if (ModelState.IsValid)
            {
                WriteLog(string.Format("New donor with name {0} created", donor.Name));
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Home/ComposeMail
        [HttpGet]
        public ActionResult ComposeMail()
        {
            return View();
        }

        //
        // POST: /Home/ComposeMail
        [HttpPost]
        public ActionResult ComposeMail(MailDetailsModel mail)
        {
            if (ModelState.IsValid)
            {
                WriteLog(string.Format("Mail sent to {0}", mail.ToMailId));
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// Write log when some action is performed
        /// </summary>
        /// <param name="message">the message</param>
        private void WriteLog(string message)
        {
            using (StreamWriter logWriter = new StreamWriter(Server.MapPath("~/Logs/Log.txt"), true))
            {
                logWriter.WriteLine("******* Begin log *******");
                logWriter.WriteLine("Message: " + message);
                logWriter.WriteLine("******* End log *******");
                logWriter.WriteLine();
            }  
        }
    }
}
