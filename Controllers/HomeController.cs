using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;
using Playground.ViewModels;

namespace Playground.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public IActionResult Index()
        {
            //var model = new HomeIndexViewModel
            //{
            //    children = _childService.GetAll(),
            //    messageOfTheDay = _greetingService.messageOfTheDay() + 
            //                                      _greetingService.GetUser() + '!'
            //};
            return View();
        }

        IGreetingService _greetingService;
    }
}
