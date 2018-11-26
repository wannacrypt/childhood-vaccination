using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlScheduleData : IScheduleService
    {
        private ChildVaccDbContext _context;

        public SqlScheduleData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Schedule Add(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
            return schedule;
        }

        public void Delete(int id)
        {
            _context.Schedules.Remove(Get(id));
            _context.SaveChanges();
        }

        public Schedule Get(int id)
        {
            return _context.Schedules.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Schedule> GetAll()
        {
            return _context.Schedules.OrderBy(s => s.Id);
        }
    }
}
