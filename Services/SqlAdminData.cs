using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlAdminData : IAdminService
    {
        private ChildVaccDbContext _context;

        public SqlAdminData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Admin Add(Admin admin)
        {
            _context.Admins.Add(admin); // will not be added until
            _context.SaveChanges();     // SaveChanges() are not invoked

            return admin;
        }

        public void Delete(int id)
        {
            _context.Admins.Remove(Get(id));
            _context.SaveChanges();
        }

        public Admin Get(int id)
        {
            return _context.Admins.FirstOrDefault(a => a.Id == id);
        }

        public Admin Get(string login)
        {
            return _context.Admins.FirstOrDefault(a => a.Login == login);
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins.OrderBy(a => a.Login);
        }
    }
}
