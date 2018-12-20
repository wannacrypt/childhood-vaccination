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
    public class ScheduleController : Controller
    {
        private ChildVaccDbContext _context;

        public ScheduleController(ChildVaccDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet("{id}", Name = "Tickets")]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTickets(int id)
        {
            return await _context.Tickets.Where(t => t.UserId == id)
                                         .OrderByDescending(t => t.StartDate.Date)
                                         .ThenBy(t => t.StartDate.Year).ToListAsync();
        }
    }
}
