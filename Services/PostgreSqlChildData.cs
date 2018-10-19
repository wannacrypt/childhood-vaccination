using System;
using System.Collections.Generic;
using System.Linq;
using ChildhoodVaccination.Data;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public class PostgreSqlChildData : IChildData
    {
        private ChildhoodVaccinationDbContext _context;

        public PostgreSqlChildData(ChildhoodVaccinationDbContext context)
        {
            _context = context;
        }

        public Child Add(Child child)
        {
            _context.Children.Add(child);
            _context.SaveChanges();
            return child;
        }

        public Child Get(string iin)
        {
            return _context.Children.FirstOrDefault(c => c.IIN == iin);
        }

        public IEnumerable<Child> GetAll()
        {
            return _context.Children.OrderBy(c => c.IIN);
        }
    }
}
