using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeApp.Models
{
    public class Gender
    {
        public int GenderId { get; set; }

        public string? Name { get; set; }

        public virtual ObservableCollectionListSource<Employee> Employees { get; set; } = new();
    }
}