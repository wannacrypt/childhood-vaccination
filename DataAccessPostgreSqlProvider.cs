using System;
using System.Collections.Generic;
using System.Linq;
using ChildhoodVaccination.Models;
using ChildhoodVaccination.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataAccessPostgreSqlProvider
{
    public class DataAccessPostgreSqlProvider : IData
    {
        private readonly DomainModelPostgreSqlContext _context;

        public DataAccessPostgreSqlProvider(DomainModelPostgreSqlContext context)
        {
            _context = context;
        }


        IEnumerable<Child> IData.GetAll()
        {
            // Using the shadow property EF.Property<DateTime>(dataEventRecord)
            return _context.DataEventRecords.OrderByDescending(dataEventRecord => EF.Property<string>(dataEventRecord, "fname")).ToList();
        }
    }
}