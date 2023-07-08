using EmployeeApp.Data;
using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            EmployeeListLoad();
        }

        public void EmployeeListLoad()
        {
            
            if (this.dbContext != null)
            {
                List<Employee> list = this.dbContext.Employees.ToList();
                dataGridView1.DataSource = list;
            }
        }

        public void DGWSettings()
        {
            dataGridView1.Columns[0].Visible = false;
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
    }
}