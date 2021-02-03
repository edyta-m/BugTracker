using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerApp.Controllers
{
    public class BugController : Controller
    {
        private BDBContext db = new BDBContext();

        // GET: Bug
        public ActionResult Index()
        {
            var bugs = from b in db.Bugs
                       orderby b.bugId
                       select b;
            return View(bugs);
        }

        // GET: Bug/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bug/Create
        [HttpPost]
        public ActionResult Create(Bug b)
        {
            try
            {
                db.Bugs.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bug/Edit/5
        public ActionResult Edit(int id)
        {
            var bug = db.Bugs.Single(m => m.bugId == id);
            return View(bug);
        }

        // POST: Bug/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var bug = db.Bugs.Single(m => m.bugId == id);
                if (TryUpdateModel(bug))
                {
                    //To do: - database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(bug);
            }
            catch
            {
                return View();
            }
        }
    }
}
