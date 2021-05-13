using RailwayReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailwayReservationSystem.Controllers
{
    public class BookingController : Controller
    {

        public RailwayReservationSystemEntities1 context = new RailwayReservationSystemEntities1();
        // GET: Booking
        [Authorize]
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(Search model)
        {
            //using (var context = new RailwayReservationSystemEntities2())

            /* var validation = from t in context.Train_Details
                              join s in context.Station on t.Train_No equals s.Train_No
                              select new { t.Source, s.Stn_Name };*/
            if (context.Train_Details.Any(x => x.Source == model.Source && x.Destination == model.Destination && x.Start_Date == model.Doj) || context.Station.Any(y => y.Stn_Name == model.Source) || context.Station.Any(b => b.Stn_Name == model.Destination))
            {
                //var query = from a in context.Train_Details select a;
                //var item = query.FirstOrDefault();
                //if (item != null)
                //    return View(item);
                //else
                //    return View("Not Found");
                return RedirectToAction("TrainList", "Booking");
            }
            else
            {
                ModelState.AddModelError("", "Enter Correct Details");
                return View();



            }
        }
        public ActionResult TrainList()
        {
            //using (var context = new RailwayReservationSystemEntities2())
            {
                //var query = from a in context.Train_Details select a;
                //var item = query.FirstOrDefault();
                //if (item != null)
                //    return View(item);
                //else
                //    return View("Not Found");

                var query = from Train_Details in context.Train_Details
                            select Train_Details;
                var train_list = query.ToList();
                return View(train_list);
            }
        }





        public ActionResult Details()
        {
            // using (var context = new RailwayReservationSystemEntities())
            {
                var query = context.Station_details();



                //var query = (from p in context.Stations
                //                                     join T in context.Train_Details on p.Train_No equals T.Train_No
                //                                     select new { p.Stn_Name, p.Arrival_Time, p.Departure_Time });
                //var train_details = query.ToList();



                return View(query);







            }
        }
        [HttpGet]
        public ActionResult BookNow()
        {

            // using (var context = new RailwayReservationSystemEntities1())


            //context.Passenger_Details.Add(model);
            //context.SaveChanges();



            //    catch (DbEntityValidationException e)
            //{
            //    var newException = new FormattedDbEntityValidationException(e);
            //    throw newException;
            //}

            return View();
        }
        [HttpPost]
        public ActionResult BookNow(Passenger_Details model)
        {
            using (var context = new RailwayReservationSystemEntities1())
            {
                context.Passenger_Details.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Amount", "Booking",model);
        }
        //[HttpGet]
        //public ActionResult Amount()
        //{ return View(); }

        [HttpGet]
        public ActionResult Amount(Passenger_Details model)
        {
            using (var context = new RailwayReservationSystemEntities1())
            {
                int total = 0;
                var query = (from a in context.Calculate_Amount where a.PNR_No==model.PNR_No select a).SingleOrDefault();
                //int db = (from a in context.Calculate_Amount select a.Total_No_Of_Seats).FirstOrDefault();

                switch (query.Class)

                {
                    case "General":
                        total = 50 * query.Total_No_Of_Seats;
                        break;
                    case "Sleeper":
                        total = 100 * query.Total_No_Of_Seats;
                        break;
                    case "AC1":
                        total = 500 * query.Total_No_Of_Seats;
                        break;
                    case "AC2":
                        total = 350 * query.Total_No_Of_Seats;
                        break;
                    case "AC3":
                        total = 200 * query.Total_No_Of_Seats;
                        break;
                }



                TempData["Result"] = total;
                //TempData["Result"].keep
            }


            return RedirectToAction("Pay", "Payment");

        }




    }
}

