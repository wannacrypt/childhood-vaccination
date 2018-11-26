using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Models;

namespace Playground.Services
{
    public class InMemoryAdminData : IAdminService
    {
        public InMemoryAdminData()
        {
            _admins = new List<Admin> {
                new Admin { Id = 1, Login = "wannacrypt", Password = "123" },
                new Admin { Id= 2, Login = "admin", Password = "admin"}
            };
        }

        public IEnumerable<Admin> GetAll()
        {
            return _admins;
        }

        public Admin Get(int id)
        {
            return _admins.FirstOrDefault(a => a.Id == id);
        }

        public Admin Add(Admin admin)
        {
            admin.Id = _admins.Max(a => a.Id) + 1;
            _admins.Add(admin);
            return admin;
        }

        public void Delete(int id)
        {
            _admins.Remove(Get(id));
        }

        List<Admin> _admins;
    }
}
