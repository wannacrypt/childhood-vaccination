using System;
using ChildhoodVaccination.Models;
using Microsoft.EntityFrameworkCore;

namespace ChildhoodVaccination.Data
{
    public class ChildhoodVaccinationDbContext : DbContext
    {
        public ChildhoodVaccinationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Child> Children { get; set; }
    }
}
