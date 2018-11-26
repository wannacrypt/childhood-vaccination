using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlVaccineListData : IVaccineListService
    {
        private ChildVaccDbContext _context;

        public SqlVaccineListData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public VaccineList Add(VaccineList vaccineList)
        {
            _context.VaccineLists.Add(vaccineList);
            _context.SaveChanges();
            return vaccineList;
        }

        public void Delete(int id)
        {
            _context.VaccineLists.Remove(Get(id));
            _context.SaveChanges();
        }

        public VaccineList Get(int id)
        {
            return _context.VaccineLists.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<VaccineList> GetAll()
        {
            return _context.VaccineLists.OrderBy(v => v.Id);
        }
    }
}
