using System;
using System.Collections.Generic;
using System.Linq;
using Playground.Data;
using Playground.Models;

namespace Playground.Services
{
    public class SqlTicketData : ITicketService
    {
        private ChildVaccDbContext _context;

        public SqlTicketData(ChildVaccDbContext context)
        {
            _context = context;
        }

        public Ticket Add(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
            return ticket;
        }

        public void Delete(int id)
        {
            _context.Tickets.Remove(Get(id));
            _context.SaveChanges();
        }

        public Ticket Get(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets.OrderBy(t => t.Id);
        }
    }
}
