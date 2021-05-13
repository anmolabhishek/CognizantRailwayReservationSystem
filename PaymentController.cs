using RailwayReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailwayReservationSystem.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Pay()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Pay(Payment_Details model)
        {
            using (var context = new RailwayReservationSystemEntities1())
            {
                if (context.Payment_Details.Any(x => x.Card_No == model.Card_No && x.CVV == model.CVV && x.Expiry_Date == model.Expiry_Date))
                {
                    return RedirectToAction("RedirectFromPayment", "Payment");
                }
                else
                {
                    ModelState.AddModelError("", "Enter Correct Details");
                    return View();

                }
            }
        }
        public ActionResult RedirectFromPayment()

        {
            Console.WriteLine("Payment Successful");
            return View();
            // This method calls when payment get success for sure. Write the code after payment successfull

        }

    }
}


      
