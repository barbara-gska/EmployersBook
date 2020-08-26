using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployersBook
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssignedDepartment { get; set; }
        public string Comments { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime FireDate { get; set; }
        public bool StillWorking;

    }
}
