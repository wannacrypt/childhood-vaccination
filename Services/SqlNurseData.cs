using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlNurseData :INurseService
    {
        private ChildVaccDbContext _context;

        public SqlNurseData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Nurse Add(Nurse nurse)
        {
            _context.Nurses.Add(nurse);
            _context.SaveChanges();
            return nurse;
        }

        public void Delete(int id)
        {
            _context.Nurses.Remove(Get(id));
            _context.SaveChanges();
        }

        public Nurse Get(int id)
        {
            return _context.Nurses.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<Nurse> GetAll()
        {
            return _context.Nurses.OrderBy(n => n.LastName);
        }
    }
}
