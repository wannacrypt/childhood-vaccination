using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface IPrescriptionService
    {
        IEnumerable<Prescription> GetAll();
        Prescription Get(int id);
        Prescription Add(Prescription prescription);
        void Delete(int id);
    }
}
