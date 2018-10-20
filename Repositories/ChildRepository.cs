using System;
using System.Collections.Generic;
using System.Linq;
using ChildhoodVaccination.Data;
using ChildhoodVaccination.Models;
using ChildhoodVaccination.Services;

namespace ChildhoodVaccination.Repositories
{
    public class ChildRepository : ChildService
    {
        private ChildhoodVaccinationDbContext _context;

        public ChildRepository(ChildhoodVaccinationDbContext context)
        {
            _context = context;
        }

        public Child Add(Child child)
        {
            _context.Children.Add(child);
            _context.SaveChanges();
            return child;
        }

        public Child Get(long id)
        {
            return _context.Children.FirstOrDefault(c => c.ChildID == id);
        }

        public IEnumerable<Child> GetAll()
        {
            return _context.Children.OrderBy(c => c.IIN);
        }
    }
}
