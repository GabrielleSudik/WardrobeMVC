using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardrobeMVC.Models;

namespace WardrobeMVC.Controllers
{
    public class FeetController : Controller
    {
        private WardrobeMVCContext db = new WardrobeMVCContext();

        // GET: Feet
        public ActionResult Index()
        {
            return View(db.Feet.ToList());
        }

        // GET: Feet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foot foot = db.Feet.Find(id);
            if (foot == null)
            {
                return HttpNotFound();
            }
            return View(foot);
        }

        // GET: Feet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feet/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeetID,ShoeName,Photo,Type,Color,Style,Occasion")] Foot foot)
        {
            if (ModelState.IsValid)
            {
                db.Feet.Add(foot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foot);
        }

        // GET: Feet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foot foot = db.Feet.Find(id);
            if (foot == null)
            {
                return HttpNotFound();
            }
            return View(foot);
        }

        // POST: Feet/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeetID,ShoeName,Photo,Type,Color,Style,Occasion")] Foot foot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foot);
        }

        // GET: Feet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foot foot = db.Feet.Find(id);
            if (foot == null)
            {
                return HttpNotFound();
            }
            return View(foot);
        }

        // POST: Feet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Foot foot = db.Feet.Find(id);
            db.Feet.Remove(foot);
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
