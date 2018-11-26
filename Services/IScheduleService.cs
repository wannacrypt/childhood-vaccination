using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface IScheduleService
    {
        IEnumerable<Schedule> GetAll();
        Schedule Get(int id);
        Schedule Add(Schedule schedule);
        void Delete(int id);
    }
}
