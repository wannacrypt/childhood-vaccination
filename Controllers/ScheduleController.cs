using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;
using Microsoft.AspNetCore.Http;

namespace Playground.Controllers
{
    public class ScheduleController : Controller
    {
        private IScheduleService _scheduleService;
        private IDoctorService _doctorService; 

        public ScheduleController(IScheduleService scheduleService, IDoctorService doctorService) 
        {
            _scheduleService = scheduleService;
            _doctorService = doctorService; 
        }

        public IActionResult ListSchedule()
        {
            var model = _scheduleService.GetAll();
            return View(model);
        }

        public IActionResult DeleteSchedule(int id)
        {
            _scheduleService.Delete(id);
            return RedirectToAction(nameof(ListSchedule));
        }

        [HttpGet]
        public IActionResult CreateSchedule()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSchedule(Schedule schedule)
        {
            if(ModelState.IsValid)
            {
                var newSchedule = new Schedule
                {
                    Morning = schedule.Morning,
                    Afternoon = schedule.Afternoon,
                    Evening = schedule.Evening,
                    DoctorID = schedule.DoctorID
                };

                _scheduleService.Add(schedule);
                return RedirectToAction(nameof(ListSchedule));
            } else 
            {
                return View();
            }
        }

        public IActionResult Index()
        {
            string userLogin = HttpContext.Session.GetString("user");

            if (!string.IsNullOrEmpty(userLogin))
            {
                var doc = _doctorService.Get(userLogin); 
                return View("~/Views/Home/Calendar.cshtml", doc);

            }
            return RedirectToAction("Login", "Authorization");
        }
    }
}
