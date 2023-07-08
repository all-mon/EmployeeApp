using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Data
{
    public class EmployeeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDb;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                new Gender { GenderId = 1, Name = "Male" },
                new Gender { GenderId = 2, Name = "Female" });
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, FullName = "Ivanov Ivan Ivanovich", GenderId = 1, BirthDate = DateTime.Parse("1990-01-12") },
                new Employee { EmployeeId = 2, FullName = "Petrov Petr Ivanovich", GenderId = 1, BirthDate = DateTime.Parse("1990-09-10") },
                new Employee { EmployeeId = 3, FullName = "Sidorova Olga Ivanovna", GenderId = 2, BirthDate = DateTime.Parse("1990-09-10") }
                );
        }
    }
}
