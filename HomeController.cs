using partyInvitationJuly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace partyInvitationJuly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RsvpForm()
        {
            return View();
        }

       [HttpPost]
       public ActionResult RsvpForm(guestResponse guestResponse)
        {
            //to do: send email to party organiser 
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else //if there has been an error
            {
                return View();
            }
          

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}