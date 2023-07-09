using EmployeeApp.Data;
using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class AddForm : Form
    {
        EmployeeContext context = new EmployeeContext();
        List<Gender> genders;
        public AddForm()
        {
            InitializeComponent();
            this.genders = context.Genders.ToList();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            
            foreach (Gender gender in genders)
            {
                genderComboBox.Items.Add(gender.Name);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee
                {
                    FullName = FullNameTextBox.Text,
                    BirthDate = dateTimePicker1.Value.Date,
                    GenderId = genders[genderComboBox.SelectedIndex].GenderId,
                };
                context.Employees.Add(emp);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Сотрудник успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сотрудник не был добавлен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
