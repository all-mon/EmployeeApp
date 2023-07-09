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
        MainForm mainForm;
        public AddForm()
        {
            InitializeComponent();

            this.genders = context.Genders.ToList();
        }
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.genders = context.Genders.ToList();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {

            foreach (Gender gender in genders)
            {
                genderComboBox.Items.Add(gender.Name);
            }
            genderComboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(FullNameTextBox.Text))
                {
                    MessageBox.Show("Введите ФИО", "ФИО", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FullNameTextBox.Focus();
                    return;
                }
                Employee emp = new Employee
                {
                    FullName = FullNameTextBox.Text,
                    BirthDate = birthDateTimePicker.Value.Date,
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
                mainForm.EmployeeListLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
