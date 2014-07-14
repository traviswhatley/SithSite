using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite_Class.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /HOME/About

        public ActionResult About()
        {
            return View();
        }

        // GET: /Home/Work

        public ActionResult Work()
        {
            return View();
        }

        // GET: /Home/Contact

        [HttpGet]
        public ActionResult Contact()
        {
            //create a new contact from object
            //to pass our view
            Models.ContactForm cf = new Models.ContactForm();
            return View(cf);
        }

        // POST: /Home/Contact

        [HttpPost]
        public ActionResult Contact(Models.ContactForm cf)
        {
            //creat a new connection to database
            Models.ContactFormEntities db = new Models.ContactFormEntities();
            //add contact info to database
            db.ContactForms.Add(cf);
            //save changes
            db.SaveChanges();
            //redirect user to thank you page
            return RedirectToAction("ThankYou");
        }

        // GET: /Home/ThankYou

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
