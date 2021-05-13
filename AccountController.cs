using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RailwayReservationSystem.Models;

namespace RailwayReservationSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Membership model)
        {
            using (var context = new RailwayReservationSystemEntities1())
            {
                /* bool isValid = context.User_Details.Any(x => x.UserId == model.UserId && x.Password == model.Password); */
                //if (context.User_Details.Any(x => x.UserId == model.UserId && x.Password == model.Password))
                //{
                //    System.Web.Security.FormsAuthentication.SetAuthCookie(model.UserId, false);
                //    return RedirectToAction("Search", "Booking");
                //}
                 if (context.User_Details.Any(x => x.UserId == model.UserId && x.Password == model.Password && x.User_Type == "Admin"))
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(model.UserId, false);
                    return RedirectToAction("Index", "Train_Details");
                }
               else if (context.User_Details.Any(x => x.UserId == model.UserId && x.Password == model.Password))
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(model.UserId, false);
                    return RedirectToAction("Search", "Booking");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username and Password");
                    return View();
                }
            }

        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User_Details model)
        {
            using (var context = new RailwayReservationSystemEntities1())
            {
                context.User_Details.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("login");
        }
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}