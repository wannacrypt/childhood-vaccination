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
                new Child { IIN = "322141", Name = "John", LastName = "Doe", Phone = "+1-555-555-555"}
            };
        }

        public IEnumerable<Child> GetAll()
        {
            return _children;
        }

        List<Child> _children;
    }
}
