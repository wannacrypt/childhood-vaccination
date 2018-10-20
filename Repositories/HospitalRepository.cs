using System;
using System.Collections.Generic;
using System.Linq;
using ChildhoodVaccination.Data;
using ChildhoodVaccination.Models;
using ChildhoodVaccination.Services;

namespace ChildhoodVaccination.Repositories
{
    public class HospitalRepository : HospitalService
    {
        private ChildhoodVaccinationDbContext _context;

        public HospitalRepository(ChildhoodVaccinationDbContext context)
        {
            _context = context;
        }

        public Hospital Add(Hospital hospital)
        {
            _context.Hospitals.Add(hospital);
            _context.SaveChanges();
            return hospital;
        }

        public Hospital Get(long id)
        {
            return _context.Hospitals.FirstOrDefault(h => h.HospitalID == id);
        }

        public IEnumerable<Hospital> GetAll()
        {
            return _context.Hospitals.OrderBy(h => h.HospitalID);
        }
    }
}
