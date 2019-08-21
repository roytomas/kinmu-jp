using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KinmuSample.Models;
namespace KinmuSample.Controllers
{
    public class HomeController : Controller
    {
        KinmuSampleDataEntities _dbEntity = null;
        public ActionResult Index()
        {
            //_dbEntity = new KinmuSampleDataEntities();
            if( Session["username"] == null){
                 return RedirectToAction("Login", "Account");
            }

            ViewBag.Departments = new List<m_bumon>() {
                    new m_bumon(){ id=1, bumon="IT" },
                    new m_bumon(){ id=2, bumon="Operations" }                 
            };

            ViewBag.Subgroups = new List<m_bumon>() {
                    new m_bumon(){ id=1, bumon="Developer" },
                    new m_bumon(){ id=2, bumon="Newtork" }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}