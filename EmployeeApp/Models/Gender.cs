using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    public class Gender
    {
        public int GenderId { get; set; }

        public string? Name { get; set; }

        public virtual ObservableCollectionListSource<Employee> Employees { get; set; } = new();
    }
}
