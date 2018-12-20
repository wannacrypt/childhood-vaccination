using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Playground.Data;
using Playground.Models;
using Playground.Services;

namespace Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : Controller
    {
        private ChildVaccDbContext _context;

        public PrescriptionController(ChildVaccDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prescription>>> Get()
        {
            var prescriptions = await _context.Prescriptions.ToListAsync(); 

            return prescriptions;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Prescription>>> GetUserPrescriptions(int id)
        {
            var prescriptions = await _context.Prescriptions.Where(p => p.ChildId == id)
                                                            .OrderByDescending(t => t.DateTime.Day)
                                                            .ThenBy(t => t.DateTime.Year).ToListAsync();

            return prescriptions;
        }
    }
}
