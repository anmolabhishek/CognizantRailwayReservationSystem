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
    public class Passenger_DetailsController : Controller
    {
        private RailwayReservationSystemEntities1 db = new RailwayReservationSystemEntities1();

        // GET: Passenger_Details
        public ActionResult Index()
        {
            return View(db.Passenger_Details.ToList());
        }

        // GET: Passenger_Details/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
        //    if (passenger_Details == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(passenger_Details);
        //}

        // GET: Passenger_Details/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Passenger_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "User_Id,Passenger_Name1,Passenger_Name2,Passenger_Name3,Phone,Email,Train_No,Select_Seat_P1,Select_Seat_P2,Select_Seat_P3,Class,Date_Of_Booking,DOJ,BookingId,Total_No_Of_Seats,PNR_No")] Passenger_Details passenger_Details)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Passenger_Details.Add(passenger_Details);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(passenger_Details);
        //}

        // GET: Passenger_Details/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
        //    if (passenger_Details == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(passenger_Details);
        //}

        //// POST: Passenger_Details/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "User_Id,Passenger_Name1,Passenger_Name2,Passenger_Name3,Phone,Email,Train_No,Select_Seat_P1,Select_Seat_P2,Select_Seat_P3,Class,Date_Of_Booking,DOJ,BookingId,Total_No_Of_Seats,PNR_No")] Passenger_Details passenger_Details)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(passenger_Details).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(passenger_Details);
        //}

        // GET: Passenger_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
            if (passenger_Details == null)
            {
                return HttpNotFound();
            }
            return View(passenger_Details);
        }

        // POST: Passenger_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
            db.Passenger_Details.Remove(passenger_Details);
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
