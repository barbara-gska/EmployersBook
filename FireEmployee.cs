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
    public partial class FireEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
           new EmployersBook.FileHelper<List<Employee>>(Program.FilePath);

        private int _employeeId;
        private Employee _employee;

        public FireEmployee(int id)
        {
            InitializeComponent();
            _employeeId = id;

            GetInfo();

        }

        private void GetInfo()
        {
            dtpFiringDate.Value = DateTime.Today;

            var employees = _fileHelper.DeserializeFromFile();
            _employee = employees.FirstOrDefault(x => x.Id == _employeeId);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            _employee = employees.FirstOrDefault(x => x.Id == _employeeId);


            var confirmFiring = MessageBox.Show($"Czy na pewno chcesz zwolnić pracownika " +
                $"{(_employee.FirstName + " " + _employee.LastName).Trim()}",
                "Zwolnij pracownika", MessageBoxButtons.OKCancel);

            if (confirmFiring == DialogResult.OK)
            {
                _employee.FireDate = dtpFiringDate.Value;
                _employee.StillWorking = false;
            }

            _fileHelper.SerializeToFile(employees);


            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
