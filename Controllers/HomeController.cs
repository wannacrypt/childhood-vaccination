using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;
using Playground.ViewModels;
using Microsoft.AspNetCore.Http;

namespace Playground.Controllers
{
    public class HomeController : Controller
    {
        private IAdminService __adminService;
        private IDoctorService __doctorService;
        private ITicketService __ticketService; 

        public HomeController(IGreetingService greetingService, IAdminService adminService, IDoctorService doctorService, ITicketService ticketService)
        {
            __adminService = adminService;
            __doctorService = doctorService;
            __ticketService = ticketService; 
            _greetingService = greetingService;
        }


        public IActionResult Index()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                Doctor doc = __doctorService.Get(userLogin);
                return View("~/Views/Home/Index.cshtml", doc);
            }
            return RedirectToAction("Login", "Authorization");
        }

        public IActionResult Profile()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                Doctor doctor = __doctorService.Get(userLogin);
                doctor.Tickets = __ticketService.GetDoctorTickets(doctor.Id); 

                return View("~/Views/Home/Profile.cshtml", doctor);

            }
            return RedirectToAction("Login", "Authorization");
        }

        [HttpPost]
        public IActionResult UpdateDoctor(Doctor doc)
        {
            if (ModelState.IsValid)
            {
                __doctorService.Update(doc);
            }

            return RedirectToAction("Profile", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user"); 
            return RedirectToAction("Login", "Authorization");
        }

        IGreetingService _greetingService;
    }
}
