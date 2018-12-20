using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface IDoctorService
    {
        IEnumerable<Doctor> GetAll();
        Doctor Get(int id);
        Doctor Get(string login); 
        Doctor Add(Doctor doctor);
        void Delete(int id);
    }
}
