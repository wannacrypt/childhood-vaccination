using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface IChildService
    {
        IEnumerable<Child> GetAll();
        Child Get(int id);
        Child Add(Child child);
        void Delete(int id);
    }
}
