using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface INurseService
    {
        IEnumerable<Nurse> GetAll();
        Nurse Get(int id);
        void Delete(int id);
        Nurse Add(Nurse nurse);
    }
}
