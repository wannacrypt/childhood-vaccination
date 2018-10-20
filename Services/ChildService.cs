using System.Collections.Generic;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public interface ChildService
    {
        IEnumerable<Child> GetAll();
        Child Get(long id);
        Child Add(Child child);
    }
}
