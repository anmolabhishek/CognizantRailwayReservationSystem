using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem.Controllers
{
    public class Train_DetailsController : Controller
    {
         RailwayReservationSystemEntities1 db = new RailwayReservationSystemEntities1();

        // GET: Train_Details
        public ActionResult Index()
        {
            return View(db.Train_Details.ToList());
        }

        // GET: Train_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train_Details train_Details = db.Train_Details.Find(id);
            if (train_Details == null)
            {
                return HttpNotFound();
            }
            return View(train_Details);
        }

        // GET: Train_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Train_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Source,Destination,Start_Date,End_Date,Start_Time,End_Time,Train_Type,Train_No,Train_Name")] Train_Details train_Details)
        {
            if (ModelState.IsValid)
            {
                db.Train_Details.Add(train_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(train_Details);
        }

        // GET: Train_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train_Details train_Details = db.Train_Details.Find(id);
            if (train_Details == null)
            {
                return HttpNotFound();
            }
            return View(train_Details);
        }

        // POST: Train_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Source,Destination,Start_Date,End_Date,Start_Time,End_Time,Train_Type,Train_No,Train_Name")] Train_Details train_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(train_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(train_Details);
        }

        // GET: Train_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train_Details train_Details = db.Train_Details.Find(id);
            if (train_Details == null)
            {
                return HttpNotFound();
            }
            return View(train_Details);
        }

        // POST: Train_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Train_Details train_Details = db.Train_Details.Find(id);
            db.Train_Details.Remove(train_Details);
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
