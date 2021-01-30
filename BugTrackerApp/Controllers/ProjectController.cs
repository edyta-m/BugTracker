using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerApp.Controllers
{
    public class ProjectController : Controller
    {
        private ProDBContext db = new ProDBContext();

        // GET: Project
        public ActionResult Index()
        {
            var projects = from pr in db.Projects
                           orderby pr.projectId
                           select pr;
            return View(projects);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(Project pro)
        {
            try
            {
                db.Projects.Add(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            var project = db.Projects.Single(m => m.projectId == id);
            return View(project);
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var project = db.Projects.Single(m => m.projectId == id);
                if (TryUpdateModel(project))
                {
                    //To do: - database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(project);
            }
            catch
            {
                return View();
            }
        }
    }
}
