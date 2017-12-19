using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TankLevel.Models;

namespace TankLevel.Controllers
{
    public class HomeController : Controller
    {
        private ChartRepository repo = new ChartRepository();

        public ActionResult Index()
        {
            ViewBag.LastValue = repo.GetData1[repo.GetData1.Count - 1].Value;
            ViewBag.LastHour = repo.GetData1[repo.GetData1.Count - 1].Category;
            return View();
        }

        public ActionResult GetChartData1(int hours)
        {
            List<ChartData> filterList = new List<ChartData>();
            int max = repo.GetData1.Count;
            int start = max - hours;

            for (int i = start; i < max; i++)
            {
                filterList.Add(repo.GetData1[i]);
            }

            return Json(filterList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetChartData2()
        {
            return Json(repo.GetData2, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetChartData3()
        {
            return Json(repo.GetData3, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}