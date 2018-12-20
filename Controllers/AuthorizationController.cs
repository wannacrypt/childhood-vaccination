using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Playground.Controllers
{
    public class AuthorizationController : Controller
    {
        private IAdminService _adminService;
        private IDoctorService _doctorService; 
        private IGreetingService _greeting;

        public AuthorizationController(IAdminService adminService,
                                       IGreetingService greeting, 
                                        IDoctorService doctorService)
        {
            _adminService = adminService;
            _greeting = greeting;
            _doctorService = doctorService; 
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                var dr = _doctorService.Get(doctor.Login);

                if(dr != null && dr.Password.Equals(doctor.Password))
                {
                    HttpContext.Session.SetString("user", doctor.Login);
                    _greeting.SetUser(doctor.Login);
                    return RedirectToAction("Index", "Home");
                }
            } 

            return View();
        }


        public IActionResult SignUp()
        {
            return View("~/Views/Authorization/SignUp.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccount(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _doctorService.Add(doctor);
                return RedirectToAction("Index", "Home");
            }

            return View(); 
        }
    }
}
