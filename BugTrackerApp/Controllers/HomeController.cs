using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Home/Reports
        public ActionResult Reports()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ViewData["BugTitle"] = collection[1];
                ViewData["Severity"] = collection[2];
                ViewData["ProgramBehaviour"] = collection[3];
                ViewData["ReproduceBehaviour"] = collection[4];

                return View("Reports");
            }
            catch
            {
                return View();
            }
        }

    }
}
