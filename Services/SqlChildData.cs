using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlChildData : IChildService
    {
        private ChildVaccDbContext _context;

        public SqlChildData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Child Add(Child child)
        {
            _context.Children.Add(child);
            _context.SaveChanges();
            return child;
        }

        public void Delete(int id)
        {
            _context.Children.Remove(Get(id));
            _context.SaveChanges();
        }

        public Child Get(int id)
        {
            return _context.Children.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Child> GetAll()
        {
            return _context.Children.OrderBy(c => c.FirstName);
        }
    }
}
