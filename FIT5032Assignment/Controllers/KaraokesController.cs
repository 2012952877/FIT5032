using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FIT5032Assignment.Models;

namespace FIT5032Assignment.Controllers
{
    public class KaraokesController : Controller
    {
        private AssignmentEntities db = new AssignmentEntities();

        // GET: Karaokes
        public ActionResult Index()
        {
            return View(db.Karaokes.ToList());
        }

        // GET: Karaokes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karaoke karaoke = db.Karaokes.Find(id);
            if (karaoke == null)
            {
                return HttpNotFound();
            }
            return View(karaoke);
        }

        // GET: Karaokes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Karaokes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Venue,AvailableDate,Address")] Karaoke karaoke)
        {
            if (ModelState.IsValid)
            {
                db.Karaokes.Add(karaoke);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(karaoke);
        }

        // GET: Karaokes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karaoke karaoke = db.Karaokes.Find(id);
            if (karaoke == null)
            {
                return HttpNotFound();
            }
            return View(karaoke);
        }

        // POST: Karaokes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Venue,AvailableDate,Address")] Karaoke karaoke)
        {
            if (ModelState.IsValid)
            {
                db.Entry(karaoke).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(karaoke);
        }

        // GET: Karaokes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karaoke karaoke = db.Karaokes.Find(id);
            if (karaoke == null)
            {
                return HttpNotFound();
            }
            return View(karaoke);
        }

        // POST: Karaokes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Karaoke karaoke = db.Karaokes.Find(id);
            db.Karaokes.Remove(karaoke);
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
