using EmployeeApp.Data;
using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Gateway
{
    public class EmployeeGateway
    {
        EmployeeContext _dbContext = new EmployeeContext();

        public bool Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int Id) 
        {
           
                var emp = _dbContext.Employees.FirstOrDefault(e => e.EmployeeId == Id);
                if (emp != null)
                {
                    _dbContext.Remove(emp);
                }
               return _dbContext.SaveChanges() > 0;
        }

        public bool Update(Employee employee)
        {
            var data = _dbContext.Employees.FirstOrDefault(c => c.EmployeeId == employee.EmployeeId);
            if (data == null) { return false; }
            data!.FullName = employee.FullName;
            data.BirthDate = employee.BirthDate;
            data.GenderId = employee.GenderId;

            return _dbContext.SaveChanges() > 0;
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.Include(e => e.Gender).ToList();
        }

        public List<Gender> GetAllGender()
        {
            return _dbContext.Genders.ToList();
        }
    }
}
