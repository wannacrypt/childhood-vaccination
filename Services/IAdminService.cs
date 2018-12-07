using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface IAdminService
    {
        IEnumerable<Admin> GetAll();
        Admin Get(int id);
        Admin Get(string login);
        Admin Add(Admin admin);
        void Delete(int id);
    }
}
