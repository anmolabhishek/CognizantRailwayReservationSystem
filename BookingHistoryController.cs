using RailwayReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailwayReservationSystem.Controllers
{
    public class BookingHistoryController : Controller
    {
        // GET: BookingHistory
        public RailwayReservationSystemEntities1 context = new RailwayReservationSystemEntities1();
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [Authorize]
        public ActionResult History(string searching)
        {

            ViewBag.Id = (from h in context.Passenger_Details select h.User_Id).Distinct();
            dynamic myModel = new ExpandoObject();
            myModel.History = from h in context.Passenger_Details
                              where h.User_Id == searching
                              || searching == null || searching == ""
                              select h;
            //if (context.Passenger_Details.Any(x => x.User_Id == User.Identity.Name))
            //{
                return View(myModel);
            
            //return View("Not Found");

        }
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Passenger_Details");

        }
    }
}