using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;
using Playground.Services;

namespace Playground.Controllers
{
	public class PrescriptionController : Controller
    {
        private IPrescriptionService _prescriptionService;

        public PrescriptionController(IPrescriptionService prescriptionService)
        {
            _prescriptionService = prescriptionService;
        }

        public IActionResult ListPrescriptions()
        {
            var model = _prescriptionService.GetAll();
            return View(model);
        }

        public IActionResult DeletePrescription(int id)
        {
            _prescriptionService.Delete(id);
            return RedirectToAction(nameof(ListPrescriptions));
        }

        [HttpGet]
        public IActionResult CreatePrescription()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePrescription(Prescription prescription)
        {
            if(ModelState.IsValid)
            {
                var newPrescription = new Prescription
                {
                    Text = prescription.Text
                };

                _prescriptionService.Add(newPrescription);

                return RedirectToAction(nameof(ListPrescriptions));
            } else 
            {
                return View();
            }
        }
    }
}
