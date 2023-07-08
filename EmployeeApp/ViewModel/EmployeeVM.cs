using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.ViewModel
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string? FullName { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Пол")]
        public string Gender { get; set; } = "Мужской";
    }
}
