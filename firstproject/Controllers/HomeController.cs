using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstproject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()            
        {
            ViewBag.name = "Show you Home Page";
            return View();
        }
    }
}