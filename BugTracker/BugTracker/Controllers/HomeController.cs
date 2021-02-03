using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "Fill out the following report accurately.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Choose a project to view all current bugs.";

            return View();
        }

        public ActionResult Recents()
        {
            ViewBag.Message = "The following bugs were recently reported.";

            return View();
        }

        public ActionResult Status()
        {
            ViewBag.Message = "The current status of your reported bugs.";

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