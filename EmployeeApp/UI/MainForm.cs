using EmployeeApp.Manager;
using Microsoft.IdentityModel.Tokens;

namespace EmployeeApp
{
    public partial class MainForm : Form
    {
        EmployeeManager _employeeManager;
        public MainForm()
        {
            InitializeComponent();
            _employeeManager = new EmployeeManager();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            EmployeeListLoad();
        }
        public void EmployeeListLoad()
        {
            var employees = _employeeManager.GetAll();
            dataGridView1.Rows.Clear();
            foreach (var item in employees)
            {
                dataGridView1.Rows.Add(item.EmployeeId, item.FullName, item.BirthDate.ToString("dd.MM.yyyy"), item.Gender.Name);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            DataGridViewRow rowData = dataGridView1.SelectedRows[0];
            editForm.EmployeeIdLabel.Text = rowData.Cells[0].Value.ToString();
            editForm.FullNameTextBox.Text = rowData.Cells[1].Value.ToString();
            editForm.birthDateTimePicker.Value = DateTime.Parse(rowData.Cells[2].Value.ToString()!);
            editForm.genderComboBox.Text = rowData.Cells[3].Value.ToString();
            editForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int empId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            DeleteEmployee(empId);
        }

        private void DeleteEmployee(int Id)
        {
            try
            {
                _employeeManager.Delete(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EmployeeListLoad();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string data = searchBox.Text;
            if (!string.IsNullOrEmpty(data))
            {
                try
                {
                    var empList = _employeeManager.Search(data);
                    if (empList.IsNullOrEmpty())
                    {
                        MessageBox.Show("Не найдено", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmployeeListLoad();
                    }
                    else
                    {
                        var employees = empList.ToList();
                        dataGridView1.Rows.Clear();
                        foreach (var item in employees)
                        {
                            dataGridView1.Rows.Add(item.EmployeeId, item.FullName, item.BirthDate.ToString("dd.MM.yyyy"), item.Gender.Name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Строка поиска пуста", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmployeeListLoad();
            }
        }
    }
}