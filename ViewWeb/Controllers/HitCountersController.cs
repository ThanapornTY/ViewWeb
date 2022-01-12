using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ViewWeb.Models;

namespace ViewWeb.Controllers
{
    public class HitCountersController : Controller
    {
        private MyDatabaseEntities db = new MyDatabaseEntities();

        // GET: HitCounters
        public ActionResult Index()
        {
            return View(db.HitCounters.ToList());
        }

        // GET: HitCounters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HitCounter hitCounter = db.HitCounters.Find(id);
            if (hitCounter == null)
            {
                return HttpNotFound();
            }
            return View(hitCounter);
        }

        // GET: HitCounters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HitCounters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SLID,IPAddress,CreateDate")] HitCounter hitCounter)
        {
            if (ModelState.IsValid)
            {
                db.HitCounters.Add(hitCounter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hitCounter);
        }

        // GET: HitCounters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HitCounter hitCounter = db.HitCounters.Find(id);
            if (hitCounter == null)
            {
                return HttpNotFound();
            }
            return View(hitCounter);
        }

        // POST: HitCounters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SLID,IPAddress,CreateDate")] HitCounter hitCounter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hitCounter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hitCounter);
        }

        // GET: HitCounters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HitCounter hitCounter = db.HitCounters.Find(id);
            if (hitCounter == null)
            {
                return HttpNotFound();
            }
            return View(hitCounter);
        }

        // POST: HitCounters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HitCounter hitCounter = db.HitCounters.Find(id);
            db.HitCounters.Remove(hitCounter);
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
