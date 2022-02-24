using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ehrman_SD2.DAL;
using Ehrman_SD2.Models;

namespace Ehrman_SD2.Controllers
{
    [Authorize]
    public class VisitsController : Controller
    {
        private Ehrman_SD2Context db = new Ehrman_SD2Context();

        // GET: Visits
        public ActionResult Index()
        {
            var visits = db.visits.Include(v => v.pet).Include(v => v.vet);
            return View(visits.ToList());
        }

        // GET: Visits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // GET: Visits/Create
        public ActionResult Create()
        {
            ViewBag.petID = new SelectList(db.pets, "petID", "petName");
            ViewBag.vetID = new SelectList(db.vets, "vetID", "vetFullName");
            return View();
        }

        // POST: Visits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitID,description,visitDate,petID,vetID")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.visits.Add(visit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petID = new SelectList(db.pets, "petID", "petName", visit.petID);
            ViewBag.vetID = new SelectList(db.vets, "vetID", "vetFullName", visit.vetID);
            return View(visit);
        }

        // GET: Visits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            ViewBag.petID = new SelectList(db.pets, "petID", "petName", visit.petID);
            ViewBag.vetID = new SelectList(db.vets, "vetID", "vetFullName", visit.vetID);
            return View(visit);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitID,description,visitDate,petID,vetID")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petID = new SelectList(db.pets, "petID", "petName", visit.petID);
            ViewBag.vetID = new SelectList(db.vets, "vetID", "vetFullName", visit.vetID);
            return View(visit);
        }

        // GET: Visits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visit visit = db.visits.Find(id);
            db.visits.Remove(visit);
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
