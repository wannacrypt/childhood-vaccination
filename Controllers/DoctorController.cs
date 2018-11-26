using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;

namespace Playground.Controllers
{
	public class DoctorController : Controller
    {
        private IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public IActionResult ListDoctor()
        {
            var model = _doctorService.GetAll();
            return View(model);
        }

        public IActionResult DeleteDoctor(int id)
        {
            _doctorService.Delete(id);
            return RedirectToAction(nameof(ListDoctor));
        }

        [HttpGet]
        public IActionResult CreateDoctor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDoctor(Doctor doctor)
        {
            if(ModelState.IsValid)
            {
                var newDoctor = new Doctor();
                newDoctor.FirstName = doctor.FirstName;
                newDoctor.LastName = doctor.LastName;

                newDoctor = _doctorService.Add(newDoctor);

                return RedirectToAction(nameof(ListDoctor));
            } else
            {
                return View();
            }
        }

    }
}
