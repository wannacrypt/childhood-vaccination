using ChildhoodVaccination.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChildhoodVaccination.Controllers
{
    public class HomeController : Controller
    {
        private ChildService _data;

        public HomeController(ChildService data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            var model = _data.GetAll();
            return View(model);
        }
    }
}