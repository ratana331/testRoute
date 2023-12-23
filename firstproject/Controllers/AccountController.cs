using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstproject.Controllers
{
    [RoutePrefix("admin")]
    public class AccountController : Controller
    {
        // GET: Account
        [Route("account")]
        public ActionResult Login()
        {
            return View();
        }

        [Route("display")]
        public ActionResult Register()
        {
            return View();
        }

        [Route("letgo")]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [Route(@"display/{id:range(1,100)}/{qty:regex(\d{3})}")]
        public ActionResult Show(int id, int qty)
        {
            return View();
        }
    }
}