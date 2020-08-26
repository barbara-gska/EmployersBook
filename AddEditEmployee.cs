using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployersBook
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
           new EmployersBook.FileHelper<List<Employee>>(Program.FilePath);

        private int _employeeId;
        private Employee _employee;
        private List<Department> _departments;

        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;
            GetDates();
            InitComboBoxDepartment();

            GetEmployeeData();

            tbFirstName.Select();
        }

        private void InitComboBoxDepartment()
        {
            _departments = new List<Department>
                            { new Department {Id = 0, Name = "brak" },
                              new Department {Id = 1, Name = "IT" },
                              new Department {Id = 2, Name = "HR" },
                              new Department {Id = 3, Name = "Marketing" },
                              new Department {Id = 4, Name = "Księgowość" }};

            cmbDepartment.DataSource = _departments;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

        }

        private void GetDates()
        {
            dtpHireDate.MaxDate = DateTime.Today;
            dtpFireDate.MaxDate = DateTime.Today;
            dtpHireDate.Value = DateTime.Today;
            dtpFireDate.Value = DateTime.Today;
        
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";

                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);

                if (_employee == null)
                    throw new Exception("Brak pracownika o podanym Id");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            cmbDepartment.SelectedItem = _employee.AssignedDepartment;
            rtbComments.Text = _employee.Comments;
            tbSalary.Text = _employee.Salary.ToString();
            dtpHireDate.Value = _employee.HireDate;

            if (_employee.FireDate != default(DateTime))
            {
                chbIsFired.Checked = true;
                lbFireDate.Visible = true;
                dtpFireDate.Visible = true;
                dtpFireDate.Value = _employee.FireDate;
            }
        }

        private void chbIsFired_CheckedChanged(object sender, EventArgs e)
        {
            if (lbFireDate.Visible && dtpFireDate.Visible)
            {
                lbFireDate.Visible = false;
                dtpFireDate.Visible = false;
            }
            else
            {
                lbFireDate.Visible = true;
                dtpFireDate.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);

            AddNewEmployeeToList(employees);

            _fileHelper.SerializeToFile(employees);


            Close();
        }

        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var employeeWithHighestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();

            _employeeId = employeeWithHighestId == null ? 1 : employeeWithHighestId.Id + 1;
        }
        
        private void AddNewEmployeeToList(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                AssignedDepartment= ((Department)cmbDepartment.SelectedItem).Name,
                Comments = rtbComments.Text,
                Salary = decimal.Parse(tbSalary.Text),
                HireDate = dtpHireDate.Value
            };

            if (chbIsFired.Checked)
            {
                employee.FireDate = dtpFireDate.Value;
                employee.StillWorking = false;
            }
            else
                employee.StillWorking = true;

            employees.Add(employee);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
