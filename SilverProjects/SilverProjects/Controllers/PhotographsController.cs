using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SilverProjects.Models;

namespace SilverProjects.Controllers
{
    public class PhotographsController : Controller
    {
        private PhotographsDBContext db = new PhotographsDBContext();

        // GET: Photographs
        public ActionResult Index()
        {
            return View(db.Photographs.ToList());
        }

        // GET: Photographs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photographs photographs = db.Photographs.Find(id);
            if (photographs == null)
            {
                return HttpNotFound();
            }
            return View(photographs);
        }

        // GET: Photographs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Photographs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,filepath,tags,category")] Photographs photographs)
        {
            if (ModelState.IsValid)
            {
                db.Photographs.Add(photographs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photographs);
        }

        // GET: Photographs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photographs photographs = db.Photographs.Find(id);
            if (photographs == null)
            {
                return HttpNotFound();
            }
            return View(photographs);
        }

        // POST: Photographs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,filepath,tags,category")] Photographs photographs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photographs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(photographs);
        }

        // GET: Photographs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photographs photographs = db.Photographs.Find(id);
            if (photographs == null)
            {
                return HttpNotFound();
            }
            return View(photographs);
        }

        // POST: Photographs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Photographs photographs = db.Photographs.Find(id);
            db.Photographs.Remove(photographs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
