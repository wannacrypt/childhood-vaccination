using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;

namespace Playground.Controllers
{
    public class ChildrenController : Controller
    {
        private IChildService _childService;

        public ChildrenController(IChildService childService)
        {
            _childService = childService;
        }

        public IEnumerable<Child> ListChildren()
        {
            var model = _childService.GetAll();
            //return View(model);
            return model;
        }

        [HttpGet]
        public IActionResult CreateChild()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateChild(Child child)
        {
            if (ModelState.IsValid)
            {
                var newChild = new Child();
                newChild.FirstName = child.FirstName;
                newChild.LastName = child.LastName;
                newChild.IIN = child.IIN;
                newChild.DateOfBirth = child.DateOfBirth;
                newChild.Phone = child.Phone;

                newChild = _childService.Add(newChild);

                return RedirectToAction(nameof(ListChildren));
            }
            else
            {
                return View();
            }
        }
    }
}
