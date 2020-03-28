using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers // identifies what youre going to have 
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // return "Hello MSSA";
            int hour = DateTime.Now.Hour;
            string greeting;
            if (hour < 12)
                greeting = "Good Morning";
            else if (hour < 16)
                greeting = "Good Afternoon";
            else
                greeting = "Good Evening";
            ViewBag.Greeting = greeting;
            ViewBag.Fairy = "Person A";
            ViewBag.Cyborg = "Person B";
            //ViewBag.Greeting = (hour < 12) ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet] // this is a declaration 
        public ViewResult RsvpForm() // you only invoke this method (rsvpform) if you have an http request that uses the GET method 
        {
            return View(); // if view returns nothing then it DEFAULT will return a view of the same name of action (RSVPFORM)
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
