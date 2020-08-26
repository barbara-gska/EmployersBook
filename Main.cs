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
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new EmployersBook.FileHelper<List<Employee>>(Program.FilePath);

        private List<string> _stuff;

        public Main()
        {
            InitializeComponent();
            InitComboBoxStuff();
            RefreshBook();
            SetColumnsHeaders();
        }

        private void InitComboBoxStuff()
        {
            _stuff = new List<string>() { "Wszyscy", "Zatrudnieni", "Zwolnieni" };

            cmbStuff.DataSource = _stuff;

        }

        private void RefreshBook()
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (cmbStuff.SelectedIndex == 0)
                dgvBook.DataSource = employees.OrderBy(x => x.Id).ToList();

            else if (cmbStuff.SelectedIndex == 1)
            {
                dgvBook.DataSource = employees.Where(x => x.StillWorking == true).OrderBy(x => x.Id).ToList();
            }

            else
                dgvBook.DataSource = employees.Where(x => x.StillWorking == false).OrderBy(x => x.Id).ToList();
        }

        private void SetColumnsHeaders()
        {
            dgvBook.Columns[0].HeaderText = "Numer";
            dgvBook.Columns[1].HeaderText = "Imię";
            dgvBook.Columns[2].HeaderText = "Nazwisko";
            dgvBook.Columns[3].HeaderText = "Dział";
            dgvBook.Columns[4].HeaderText = "Uwagi";
            dgvBook.Columns[5].HeaderText = "Wynagrodzenie";
            dgvBook.Columns[6].HeaderText = "Data zatrudnienia";
            dgvBook.Columns[7].HeaderText = "Data zwolnienia";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshBook();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego dane chcesz edytować.");
                return;
            }

            var addEditEmployee = new AddEditEmployee(
                Convert.ToInt32(dgvBook.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego chcesz zwolnić.");
                return;
            }

            var fireEmployee = new FireEmployee(
                Convert.ToInt32(dgvBook.SelectedRows[0].Cells[0].Value));
            fireEmployee.FormClosing += FireEmployee_FormClosing;
            fireEmployee.ShowDialog();


        }

        private void FireEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshBook();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshBook();
        }

        private void cmbStuff_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBook();
        }
    }
}
