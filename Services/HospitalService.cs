using System;
using System.Collections.Generic;
using ChildhoodVaccination.Models;

namespace ChildhoodVaccination.Services
{
    public interface HospitalService
    {
        IEnumerable<Hospital> GetAll();
        Hospital Get(long id);
        Hospital Add(Hospital hospital);
    }
}
