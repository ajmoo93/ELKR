using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectTesting2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View();
        }
        public ActionResult EditAccount()
        {
            return View();
        }
        public ActionResult DeleteAccount()
        {
            return View();
        }
    }
}