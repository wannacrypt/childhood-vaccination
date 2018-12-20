using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Playground.Services;
using Playground.Models;
using Playground.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private ChildVaccDbContext _context;

        public AdminController(ChildVaccDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> Get()
        {
            return await _context.Admins.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{login}")]
        public async Task<ActionResult<Admin>> Get(string login)
        {
            var admin = await _context.Admins.Where(a => a.Login.Equals(login)).ToListAsync();

            if(admin == null)
            {
                return NotFound();
            }

            return admin[0];
        }

        // POST api/values 
        [HttpPost]
        public async Task<ActionResult<Admin>> Post(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = admin.Id }, admin);
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
