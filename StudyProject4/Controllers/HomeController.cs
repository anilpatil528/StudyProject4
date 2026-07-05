using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyProject4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //a-first Commmit
            //a - second commit
            //B - First commit
            //B- Second Commit
            //F- First Commit
            //F-Second Commit
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