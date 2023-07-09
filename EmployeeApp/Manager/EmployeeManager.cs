using EmployeeApp.Gateway;
using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Manager
{
    public class EmployeeManager
    {
        EmployeeGateway _employeeGateway = new EmployeeGateway();

        public bool Add(Employee employee)
        {
            return _employeeGateway.Add(employee);
        }
        public bool Delete(int Id) 
        {
            return _employeeGateway.Delete(Id);
        }

        public bool Update(Employee employee)
        {
            return _employeeGateway.Update(employee);
        }
        public List<Employee> GetAll()
        {
            return _employeeGateway.GetAll();
        }

        public List<Gender> GetAllGender()
        {
            return _employeeGateway.GetAllGender();
        }

        internal List<Employee> Search(string data)
        {
            return _employeeGateway.Search(data);
        }
    }
}
