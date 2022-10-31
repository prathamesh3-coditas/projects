using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Approach.Models
{
    public class Department
    {
        public int DeptNo { get; set; }

        public string? DeptName { get; set; }
        public int Capacity  { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }


    public class Employee
    {
        public int EmpNo { get; set; }

        public string? EmpName { get; set; }

        public int Age { get; set; }

        public int DeptNo { get; set; }

        public Department? Dept { get; set; }
    }
}
