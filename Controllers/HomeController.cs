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

        public HomeController(IGreetingService greetingService, IAdminService adminService)
        {
            __adminService = adminService;
            _greetingService = greetingService;
        }


        public IActionResult Index()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                Admin admin = __adminService.Get(userLogin);
                return View("~/Views/Home/Index.cshtml");
            }
            return RedirectToAction("Login", "Authorization");
        }

        public IActionResult Profile()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                Admin admin = __adminService.Get(userLogin);
                return View("~/Views/Home/Profile.cshtml", admin);

            }
            return RedirectToAction("Login", "Authorization");
        }

        public IActionResult Calendar()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                return View("~/Views/Home/Calendar.cshtml");

            }
            return RedirectToAction("Login", "Authorization");
        }

        IGreetingService _greetingService;
    }
}
