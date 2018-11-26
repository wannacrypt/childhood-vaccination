using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Models;

namespace Playground.Services
{
    public class InMemoryChildData : IChildService
    {
        public InMemoryChildData()
        {
            _children = new List<Child> {
                new Child { Id = 1, FirstName = "Zhandos"},
                new Child { Id = 2, FirstName = "Daulet"},
                new Child { Id = 3, FirstName = "Talgat"}
            };
        }

        public IEnumerable<Child> GetAll()
        {
            return _children.OrderBy(c => c.LastName);
        }

        public Child Get(int id)
        {
            return _children.FirstOrDefault(c => c.Id == id);
        }

        public Child Add(Child child)
        {
            child.Id = _children.Max(c => c.Id) + 1;
            _children.Add(child);
            return child;
        }

        List<Child> _children;
    }
}
