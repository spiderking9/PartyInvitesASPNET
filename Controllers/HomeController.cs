using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Costam = hour < 17 ? "dzien dobry" : "dobry wieczór";
            return View("MyView");
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListResponses()
        {
            return View(Repository.Responses.Where(r=>r.WillAttend==true));
        }


    }
}
