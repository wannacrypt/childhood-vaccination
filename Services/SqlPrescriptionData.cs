using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlPrescriptionData : IPrescriptionService
    {
        private ChildVaccDbContext _context;

        public SqlPrescriptionData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Prescription Add(Prescription prescription)
        {
            _context.Prescriptions.Add(prescription);
            _context.SaveChanges();
            return prescription;
        }

        public void Delete(int id)
        {
            _context.Prescriptions.Remove(Get(id));
            _context.SaveChanges();
        }

        public Prescription Get(int id)
        {
            return _context.Prescriptions.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Prescription> GetAll()
        {
            return _context.Prescriptions.OrderBy(p => p.Id);
        }
    }
}
