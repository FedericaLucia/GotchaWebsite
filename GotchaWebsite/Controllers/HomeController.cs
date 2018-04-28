using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GotchaWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {//a view is a type of action result, a dynamically typed object of C#
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We got you.";
            ViewBag.Location = "Edinburgh.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }
    }
}