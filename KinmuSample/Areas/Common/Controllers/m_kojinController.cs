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
    public class m_kojinController : Controller
    {
        private KinmuSampleDataEntities db = new KinmuSampleDataEntities();

        [ChildActionOnly]
        public ActionResult ForSearch()
        {
            var m_kojin = db.m_kojin;
            if ((int)Session["hyouji"] == 0)
            {
                return PartialView("~/Areas/Common/Views/m_kojin/_kojin_checkbox.cshtml", m_kojin.AsEnumerable());
            }
            else
            {
                return PartialView("~/Areas/Common/Views/m_kojin/_kojin_checkbox_disabled.cshtml", m_kojin.AsEnumerable());
            }
        }

    }
}
