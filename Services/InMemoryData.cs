using System.Collections.Generic;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public class InMemoryData : IChildData
    {
        public InMemoryData()
        {
            _children = new List<Child>
            {
                new Child { IIN = "322141", Name = "John", LastName = "Doe", Phone = "+1-555-555-555"}
            };
        }

        public IEnumerable<Child> GetAll()
        {
            return _children;
        }

        public Child Get(string iin)
        {
            throw new System.NotImplementedException();
        }

        public Child Add(Child child)
        {
            throw new System.NotImplementedException();
        }

        List<Child> _children;
    }
}
