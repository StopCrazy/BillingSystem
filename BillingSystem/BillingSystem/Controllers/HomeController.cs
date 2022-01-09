using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult PieChart() 
        {
            ViewBag.Message = "你的本月各項目收支圓餅圖.";

            return View();
        }

        public ActionResult Surplus()
        {
            ViewBag.Message = "你的本月盈餘.";

            return View();
        }
    }
}