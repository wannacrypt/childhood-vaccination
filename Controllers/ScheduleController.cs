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

        public ScheduleController(IScheduleService scheduleService) 
        {
            _scheduleService = scheduleService;
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
                return View("~/Views/Home/Calendar.cshtml");

            }
            return RedirectToAction("Login", "Authorization");
        }
    }
}
