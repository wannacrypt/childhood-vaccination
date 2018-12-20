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
    public class ChildrenController : Controller
    {
        private ChildVaccDbContext _context;

        public ChildrenController(ChildVaccDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Child>>> Get()
        {
            return await _context.Children.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{iin}")]
        public async Task<ActionResult<Child>> Get(string iin)
        {
            var child = await _context.Children.Where(a => a.IIN.Equals(iin)).ToListAsync();

            if (child == null)
            {
                return NotFound();
            }

            return child[0];
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ChangeChild(long id, Child child)
        {
            if (id != child.Id)
            {
                return BadRequest();
            }

            _context.Entry(child).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
