using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KinmuSample.Models;
namespace KinmuSample.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount account) {
            if (account != null)
            {
                if (account.UserName == "admin" && account.Password == "password")
                {
                    Session["userid"] = 1;
                    Session["username"] = "admin";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username and password is wrong");
                }
            }

            return View();
        }

    }
}