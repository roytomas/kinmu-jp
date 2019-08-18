using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KinmuSample.Models;
using KinmuSample.Areas.Shoukai.Models.ViewModels;

namespace KinmuSample.Areas.Shoukai.Controllers
{
    public class KinmuShoukaiController : Controller
    {
        private KinmuSampleDataEntities db = new KinmuSampleDataEntities();

        public ActionResult Search()
        {
            var m_gamen = db.Database.SqlQuery<m_gamen>("SELECT * FROM m_gamen WHERE company_code = 5 AND screen_code = 1");
 
            String gamenstring = "";
            foreach (var item in m_gamen)
                gamenstring = gamenstring + item.hyouji.ToString() + "," + item.item_code.ToString() + ";";

            KinmuShoukaiSearch kinmuShoukaiSearch = new KinmuShoukaiSearch
            {
                gamenString = gamenstring
            };

            return View(kinmuShoukaiSearch);
        }

        public ActionResult Index(List<string> kojin_name, string bumon)
        {
            string query1 = 
                "SELECT kojin_name, bumon, kinmu_jikan, husyuugyou_jikan FROM kinmu " +
                "INNER JOIN m_kojin ON kinmu.kojin_id = m_kojin.id " +
                "INNER JOIN m_bumon ON m_kojin.bumon_id = m_bumon.id ";

            if (kojin_name != null)
            {
                query1 += "WHERE kojin_name IN " + "('" + String.Join("','", kojin_name) + "')"; 
            }
            if (string.IsNullOrEmpty(bumon) != true)
            {
                query1 += "WHERE bumon ='" + bumon + "'";
            }

            var queryablekinmuDatas = db.Database.SqlQuery<KinmuData>(query1);

            var m_gamen = db.Database.SqlQuery<m_gamen>("SELECT * FROM m_gamen WHERE company_code = 4 AND screen_code = 2");

            String gamenstring = "";
            foreach (var item in m_gamen)
                gamenstring = gamenstring + item.hyouji.ToString() + "," + item.item_code.ToString() + ";";

            KinmuShoukaiResult kinmuShoukaiResult = new KinmuShoukaiResult
            {
                kinmuDatas = queryablekinmuDatas.AsEnumerable(),
                gamenString = gamenstring
            };
            return View(kinmuShoukaiResult);
        }
    }
}