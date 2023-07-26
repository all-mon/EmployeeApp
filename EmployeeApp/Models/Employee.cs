using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [DisplayName("ФИО")]
        public string FullName { get; set; } = string.Empty;
        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; } = null!;


    }
}
