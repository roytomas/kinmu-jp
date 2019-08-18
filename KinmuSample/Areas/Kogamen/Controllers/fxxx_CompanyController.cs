using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KinmuSample.Models;


namespace KinmuSample.Areas.Kogamen.Controllers
{
    public class Fxxx_CompanyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Company()
        {
            KinmuSampleDataEntities db = new KinmuSampleDataEntities();
            IEnumerable<m_bumon> companyMasterFind = db.m_bumon;

            //var encodeTest = AntiXssEncoder.HtmlEncode(test, true);

            this.ViewData.Model = companyMasterFind;
            return PartialView("~/Areas/Kogamen/Views/fxxx_Company/Company.cshtml");
        }

        public ActionResult Confirm(string company_code)
        {
            this.ViewBag.company_code = company_code;

            return View("~/Kogamen/Home/Index");
        }

        public ActionResult Cancel()
        {
            return View("Index");

        }

    }
}