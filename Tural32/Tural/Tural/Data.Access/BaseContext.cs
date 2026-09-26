using ConsoleApp2.Entities;
using ConsoleApp2.Entities.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tural.Entites.Mapping;

namespace Tural.Data.Access
{
    public class BaseContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee>  Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=TuralDB;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
