using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [DisplayName("ФИО")]
        public string FullName { get; set; } = string.Empty;
        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }

        public virtual Gender Gender { get; set; } = null!;


    }
}
