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
        private IGreetingService _greeting;

        public AuthorizationController(IAdminService adminService,
                                       IGreetingService greeting)
        {
            _adminService = adminService;
            _greeting = greeting;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Admin admin)
        {
            if (ModelState.IsValid)
            {
                foreach(Admin a in _adminService.GetAll())
                {
                    if(a.Login.Equals(admin.Login) && 
                       a.Password.Equals(admin.Password))
                    {
                        HttpContext.Session.SetString("user", admin.Login); 
                        _greeting.SetUser(admin.Login);
                        return RedirectToAction("Index", "Home");
                    }
                }
            } 

            return View();
        }


        public IActionResult SignUp()
        {
            return View("~/Views/Authorization/SignUp.cshtml");
        }
    }
}
