using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;

namespace Playground.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult ListAdmin()
        {
            var model = _adminService.GetAll();
            return View(model);
        }

        public IActionResult DeleteAdmin(int id)
        {
            _adminService.Delete(id);
            return RedirectToAction(nameof(ListAdmin));
        }

        [HttpGet]
        public IActionResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAdmin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var newAdmin = new Admin();
                newAdmin.Login = admin.Login;
                newAdmin.Password = admin.Password;

                newAdmin = _adminService.Add(newAdmin);

                return RedirectToAction(nameof(ListAdmin));
            }
            else
            {
                return View();
            }
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            var admins = _adminService.GetAll();
            return admins;
        }
    }
}
