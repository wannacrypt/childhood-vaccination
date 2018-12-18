using System;
using Microsoft.EntityFrameworkCore;
using Playground.Models;

namespace Playground.Data
{
    public class ChildVaccDbContext : DbContext
    {
        // I can create a new instance of ChildVaccDbContext 
        // inside of one of my controllers
        // or 
        // better approach would be register ChildVaccDbContext
        // as a service, so that I could inject instances of that
        // class into various components 
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<VaccineList> VaccineLists { get; set; }

        public ChildVaccDbContext(DbContextOptions options)
            : base(options)
        {
           
        }
    }
}
