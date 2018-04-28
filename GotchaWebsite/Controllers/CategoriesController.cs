using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GotchaWebsite.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        //added search action with return Content.The parameter passes the content.

           
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            //redirect the search to the index page. Name equals same adds the search parameter in the qery string.
            return RedirectToAction("Index", "Home" , new { name = name });
        }
    }
}