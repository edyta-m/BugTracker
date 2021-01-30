using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerApp.Controllers
{
    public class PersonController : Controller
    {
        private PerDBContext db = new PerDBContext();

        // GET: Person
        public ActionResult Index()
        {
            var people = from p in db.People
                         orderby p.personId
                         select p;
            return View(people);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person per)
        {
            try
            {
                db.People.Add(per);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            var person = db.People.Single(m => m.personId == id);
            return View(person);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var person = db.People.Single(m => m.personId == id);
                if (TryUpdateModel(person))
                {
                    //To do: - database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(person);
            }
            catch
            {
                return View();
            }
        }
    }
}
