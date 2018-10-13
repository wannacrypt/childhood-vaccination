using System.Collections.Generic;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public class InMemoryData : IData
    {
        public InMemoryData()
        {
            _children = new List<Child>
            {
                new Child { Id = 1, Name = "Zhandos's Palace" },
                new Child { Id = 2, Name = "Daulet Pizza Place" },
                new Child { Id = 3, Name = "Talgat's Burgers" }
            };
        }

        public IEnumerable<Child> GetAll()
        {
            return _children;
        }

        List<Child> _children;
    }
}
