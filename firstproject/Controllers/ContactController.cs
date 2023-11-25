using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstproject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Show()
            
        {
            return View();
        }
        public ActionResult Shows()

        {
            return View("Show");
        }
        public ActionResult Showm()

        {
            return View();
        }
        public ActionResult Showc()

        {
            return View("~/Views/About/Add.cshtml");
        }
        public ContentResult showContent()
        {
            return Content("Hello");
        }

    }
}