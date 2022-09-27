using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WidgetsERPSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Widgets ERP application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Widgets contact details.";

            return View();
        }
    }
}