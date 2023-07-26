using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;

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
                new Gender { GenderId = 1, Name = "Мужской" },
                new Gender { GenderId = 2, Name = "Женский" });
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, FullName = "Иванов Иван Иванович", GenderId = 1, BirthDate = DateTime.Parse("1990-01-12") },
                new Employee { EmployeeId = 2, FullName = "Петров Петр Петрович", GenderId = 1, BirthDate = DateTime.Parse("1990-09-10") },
                new Employee { EmployeeId = 3, FullName = "Сидорова Ольга Николаевна", GenderId = 2, BirthDate = DateTime.Parse("1990-09-10") }
                );
        }
    }
}
