using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;

namespace Playground.Controllers
{
	public class NurseController : Controller
    {
        private INurseService _nurseService;

        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService;
        }

        public IActionResult ListNurse()
        {
            var model = _nurseService.GetAll();
            return View(model);
        }

        public IActionResult DeleteNurse(int id)
        {
            _nurseService.Delete(id);
            return RedirectToAction(nameof(ListNurse));
        }

        [HttpGet]
        public IActionResult CreateNurse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNurse(Nurse nurse)
        {
            if(ModelState.IsValid)
            {
                var newNurse = new Nurse
                {
                    LastName = nurse.LastName,
                    FirstName = nurse.FirstName
                };

                _nurseService.Add(newNurse);

                return RedirectToAction(nameof(ListNurse));
            } else
            {
                return View();
            }
        }
    }
}
