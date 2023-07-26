namespace EmployeeApp.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string? Name { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; } = null!;
    }
}