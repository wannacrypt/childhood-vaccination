using System;
using System.Linq;
using ChildhoodVaccination.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessPostgreSqlProvider
{
    // >dotnet ef migration add testMigration in AspNet5MultipleProject
    public class DomainModelPostgreSqlContext : DbContext
    {
        public DomainModelPostgreSqlContext(DbContextOptions<DomainModelPostgreSqlContext> options) :base(options)
        {
        }
         
        public DbSet<Child> DataEventRecords { get; set; }
 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Child>().HasKey(m => m.Id);
 
            // shadow properties
            builder.Entity<Child>().Property<DateTime>("UpdatedTimestamp");
 
            base.OnModelCreating(builder);
        }
    }
}
