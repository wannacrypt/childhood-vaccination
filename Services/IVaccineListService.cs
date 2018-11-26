using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface IVaccineListService
    {
        IEnumerable<VaccineList> GetAll();
        VaccineList Get(int id);
        VaccineList Add(VaccineList vaccineList);
        void Delete(int id);
    }
}
