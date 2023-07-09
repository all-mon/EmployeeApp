using EmployeeApp.Data;
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
    public partial class AddForm : Form
    {
        EmployeeContext _dbContext = new EmployeeContext();
        EmployeeManager _employeeManager = new EmployeeManager();
        List<Gender> genders;
        MainForm mainForm;
        
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.genders = _dbContext.Genders.ToList();
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

                if (_employeeManager.Add(emp))
                {
                    MessageBox.Show("Сотрудник успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
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

        private void ResetForm()
        {
            FullNameTextBox.Text = string.Empty;
            genderComboBox.SelectedIndex = 0;
        }
    }
}