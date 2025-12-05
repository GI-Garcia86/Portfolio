using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private ApplicationDbContexts db = new ApplicationDbContexts();

        public ActionResult Index()
        {
            var list = db.Projects.Include("StudentProfile").ToList();
            return View(list);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Projects Projects = db.Projects.Find(id);
            if (Projects == null) return HttpNotFound();

            return View(Projects);
        }

        public ActionResult Create()
        {
            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Projects Projects)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(Projects);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName", Projects.StudentProfileId);
            return View(Projects);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Projects Projects = db.Projects.Find(id);
            if (Projects == null) return HttpNotFound();

            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName", Projects.StudentProfileId);
            return View(Projects);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Projects Projects)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Projects).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName", Projects.StudentProfileId);
            return View(Projects);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Projects projects = db.Projects.Find(id);
            if (projects == null) return HttpNotFound();

            return View(projects);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projects Projects = db.Projects.Find(id);
            db.Projects.Remove(Projects);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}