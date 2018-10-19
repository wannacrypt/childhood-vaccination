using System.Collections.Generic;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public interface IChildData
    {
        IEnumerable<Child> GetAll();
        Child Get(string iin);
        Child Add(Child child);
    }
}
