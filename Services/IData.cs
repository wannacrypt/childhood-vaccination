using System.Collections.Generic;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public interface IData
    {
        IEnumerable<Child> GetAll();
    }
}
