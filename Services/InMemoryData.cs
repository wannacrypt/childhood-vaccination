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
                new Child { Id = 1, Name = "Zhandos" },
                new Child { Id = 2, Name = "Daulet" },
                new Child { Id = 3, Name = "Talgat" }
            };
        }

        public IEnumerable<Child> GetAll()
        {
            return _children;
        }

        List<Child> _children;
    }
}
