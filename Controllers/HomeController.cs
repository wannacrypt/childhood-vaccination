using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;
using Playground.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Playground.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IGreetingService greetingService, 
                              IAdminService adminService, 
                              IChildService childService,
                              IDoctorService doctorService,
                              ITicketService ticketService)
        {
            _adminService = adminService;
            _greetingService = greetingService;
            _childService = childService;
            _doctorService = doctorService;
            _ticketService = ticketService;
        }


        public IActionResult Index()
        {
            string userLogin = HttpContext.Session.GetString("user");
            
            if (!string.IsNullOrEmpty(userLogin))
            {
                List<ChildDoctorViewModel> childDoctorList = new List<ChildDoctorViewModel>();
                IEnumerable<Child> children = _childService.GetAll();

                foreach (Child c in children)
                {
                    ChildDoctorViewModel cd = new ChildDoctorViewModel
                    {
                        child = c,
                        doctor = _doctorService.Get(c.DoctorID)
                    };
                    childDoctorList.Add(cd);
                }
                return View(childDoctorList);
            }
            return RedirectToAction("Login", "Authorization");
        }

        public IActionResult Profile()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                Doctor doctor = _doctorService.Get(userLogin);
                doctor.Tickets = _ticketService.GetDoctorTickets(doctor.Id); 

                return View("~/Views/Home/Profile.cshtml", doctor);

            }
            return RedirectToAction("Login", "Authorization");
        }

        [HttpPost]
        public IActionResult UpdateDoctor(Doctor doc)
        {
            if (ModelState.IsValid)
            {
                _doctorService.Update(doc);
            }

            return RedirectToAction("Profile", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user"); 
            return RedirectToAction("Login", "Authorization");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePatient(Child child)
        {
            if (ModelState.IsValid)
            {
                string userLogin = HttpContext.Session.GetString("user");
                Doctor doctor = _doctorService.Get(userLogin);

                var newChild = new Child
                {
                    FirstName = child.FirstName,
                    LastName = child.LastName,
                    IIN = child.IIN,
                    Phone = child.Phone,
                    DateOfBirth = child.DateOfBirth,
                    Login = child.Login,
                    Password = child.Password,
                    DoctorID = doctor.Id
                };

                newChild = _childService.Add(newChild);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        IGreetingService _greetingService;
        IAdminService _adminService;
        IChildService _childService;
        IDoctorService _doctorService;
    }
}
