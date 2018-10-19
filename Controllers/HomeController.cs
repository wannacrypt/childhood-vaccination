using ChildhoodVaccination.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChildhoodVaccination.Controllers
{
    public class HomeController : Controller
    {
        private IChildData _data;

        public HomeController(IChildData data)
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