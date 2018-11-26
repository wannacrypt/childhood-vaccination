using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlDoctorData : IDoctorService
    {
        private ChildVaccDbContext _context;

        public SqlDoctorData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Doctor Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }

        public void Delete(int id)
        {
            _context.Doctors.Remove(Get(id));
            _context.SaveChanges();
        }

        public Doctor Get(int id)
        {
            return _context.Doctors.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.OrderBy(d => d.LastName);
        }
    }
}
