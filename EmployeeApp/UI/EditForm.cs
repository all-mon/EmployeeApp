using EmployeeApp.Manager;
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
    public partial class EditForm : Form
    {
        EmployeeManager _employeeManager = new EmployeeManager();
        MainForm mainForm;
        public EditForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
                    EmployeeId =Int32.Parse( EmployeeIdLabel.Text),
                    FullName = FullNameTextBox.Text,
                    BirthDate = birthDateTimePicker.Value.Date,
                    GenderId = _employeeManager.GetAllGender()[genderComboBox.SelectedIndex].GenderId,
                };

                if (_employeeManager.Update(emp))
                {
                    MessageBox.Show("Данные обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.EmployeeListLoad();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Сотрудник не был обновлен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
