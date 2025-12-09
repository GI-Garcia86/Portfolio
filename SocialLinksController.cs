using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SocialLinksController : Controller
    {
        private ApplicationDbContexts db = new ApplicationDbContexts();

        public ActionResult Index()
        {
            var list = db.SocialLinks.Include("SutdentProfile").ToList();
            return View(list);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            SocialLinks link = db.SocialLinks.Find(id);
            if (link == null) return HttpNotFound();

            return View(link);
        }

        public ActionResult Create()
        {
            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SocialLinks link)
        {
            if (ModelState.IsValid)
            {
                db.SocialLinks.Add(link);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName", link.StudentProfileId);
            return View(link);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            SocialLinks link = db.SocialLinks.Find(id);
            if (link == null) return HttpNotFound();

            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName", link.StudentProfileId);
            return View(link);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SocialLinks link)
        {
            if (ModelState.IsValid)
            {
                db.Entry(link).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentProfileId = new SelectList(db.StudentProfile, "Id", "FullName", link.StudentProfileId);
            return View(link);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            SocialLinks link = db.SocialLinks.Find(id);
            if (link == null) return HttpNotFound();

            return View(link);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SocialLinks link = db.SocialLinks.Find(id);
            db.SocialLinks.Remove(link);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}