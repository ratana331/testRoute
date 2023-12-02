using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstproject.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Saven()
        {
            return File(Server.MapPath("~/Content/test.txt"),"text/pain");
        }
        public FileResult Downlowd()
        {
            return File(Server.MapPath("~/Content/test.txt"), "test/pain", "kim.txt");
        }
    }
}