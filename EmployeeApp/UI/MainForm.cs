using EmployeeApp.Data;
using EmployeeApp.Models;
using EmployeeApp.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;

namespace EmployeeApp
{
    public partial class MainForm : Form
    {
        private EmployeeContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dbContext = new EmployeeContext();
            this.dbContext.Database.EnsureCreated();
            EmployeeListLoad();
        }

        public void EmployeeListLoad()
        {
            List<EmployeeVM> employees = new List<EmployeeVM>();
            if (this.dbContext != null)
            {
                List<Employee> list = this.dbContext.Employees.Include(e => e.Gender).ToList();
                foreach (var item in list)
                {
                    EmployeeVM employee = new EmployeeVM
                    {
                        Id = item.EmployeeId,
                        FullName = item.FullName,
                        BirthDate = item.BirthDate,
                        Gender = item.Gender.Name!
                    };
                    employees.Add(employee);
                }
            }
            dataGridView1.DataSource = employees;
            DGVSettings();
        }

        public void DGVSettings()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int empId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            DeleteEmployee(empId);
        }

        private async void DeleteEmployee(int Id)
        {
            try
            {
                var emp = await dbContext!.Employees.FirstOrDefaultAsync(e => e.EmployeeId == Id);
                if (emp != null)
                {
                    dbContext.Remove(emp);
                }
                await dbContext.SaveChangesAsync();
                EmployeeListLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}