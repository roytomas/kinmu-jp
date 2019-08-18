using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KinmuSample.Models;

namespace KinmuSample.Areas.Common.Controllers
{
    public class m_bumonController : Controller
    {
        private KinmuSampleDataEntities db = new KinmuSampleDataEntities();

        [ChildActionOnly]
        public ActionResult ForSearch()
        {
            var m_bumon = db.m_bumon;
            return PartialView("~/Areas/Common/Views/m_bumon/_bumon_pulldown.cshtml", m_bumon.AsEnumerable());
        }
    }
}
