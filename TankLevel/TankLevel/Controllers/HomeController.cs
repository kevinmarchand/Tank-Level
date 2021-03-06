﻿using System;
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

        public ActionResult Index(int id)
        {
            // Do a regression and populate the function data
            repo.FindLowestIndexReverse(repo.GetData3);
            // Evaluate the function at 100% of level
            DateTime? evaluate = repo.EvaluateFunctionAt(100.0, repo.GetData3);
            double fit = 0;
            if (evaluate != null)
            {
                fit = repo.GoodnessFit * 100;
                ViewBag.Prediction = "Level at 100% at " + evaluate.ToString() + " with a fit of " + fit.ToString("F2") + "%.";
            }
            else
            {
                ViewBag.Prediction = "Was not able to Evaluate the curve.";
            }
            ViewBag.LastValue = repo.GetData3[repo.GetData3.Count - 1].Value;
            ViewBag.LastHour = repo.GetData3[repo.GetData3.Count - 1].Category;
            return View();
        }

        public ActionResult GetChartData1(int hours)
        {
            List<ChartData> filterList = new List<ChartData>();
            int max = repo.GetData3.Count;
            int start = max - hours;

            for (int i = start; i < max; i++)
            {
                filterList.Add(repo.GetData3[i]);
            }

            return Json(filterList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetChartData2()
        {
            return Json(repo.GetData3, JsonRequestBehavior.AllowGet);
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