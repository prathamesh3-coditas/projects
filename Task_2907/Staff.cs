using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Class_work
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }
    }
    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "YashodaNandan", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 102, EmpName = "DevkiNandan", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 103, EmpName = "RadheShyam", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 104, EmpName = "Gopal", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 105, EmpName = "Govind", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 106, EmpName = "Mohan", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 107, EmpName = "Madhav", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 108, EmpName = "Milind", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 109, EmpName = "Vasudev", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 110, EmpName = "Shridhar", DeptName = "IT", Salary = 83000 });
            Add(new Employee() { EmpNo = 111, EmpName = "Yashomati", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 112, EmpName = "Devika", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 113, EmpName = "RadheShyam", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 114, EmpName = "Gopal", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 115, EmpName = "Govindkumar", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 116, EmpName = "Mohan", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 117, EmpName = "Madhav", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 118, EmpName = "Himanshu", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 119, EmpName = "Vasu", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 120, EmpName = "Ram", DeptName = "IT", Salary = 83000 });
            Add(new Employee() { EmpNo = 121, EmpName = "Nandu", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 122, EmpName = "Dev", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 123, EmpName = "Shyam", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 124, EmpName = "Geetika", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 125, EmpName = "Ganesh", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 126, EmpName = "Neeti", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 127, EmpName = "Shakti", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 128, EmpName = "Mukesh", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 129, EmpName = "Pranav", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 130, EmpName = "Shivam", DeptName = "IT", Salary = 83000 });
            Add(new Employee() { EmpNo = 131, EmpName = "Shubham", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 132, EmpName = "Divyanshi", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 133, EmpName = "Rahul", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 134, EmpName = "Narendra", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 135, EmpName = "Akhilesh", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 136, EmpName = "Mohit", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 137, EmpName = "Mamata", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 138, EmpName = "Smriti", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 139, EmpName = "divyesh", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 140, EmpName = "roshani", DeptName = "IT", Salary = 83000 });
            Add(new Employee() { EmpNo = 141, EmpName = "Ratan", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 142, EmpName = "Sahil", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 143, EmpName = "Pari", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 144, EmpName = "Nilkanth", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 145, EmpName = "Bhuvan", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 146, EmpName = "Mohit", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 147, EmpName = "Charulata", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 148, EmpName = "Nikita", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 149, EmpName = "Abhishek", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 150, EmpName = "Swaraj", DeptName = "IT", Salary = 83000 });
            Add(new Employee() { EmpNo = 151, EmpName = "Santosh", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 152, EmpName = "Ibrahim", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 153, EmpName = "Akshat", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 154, EmpName = "Kareena", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 155, EmpName = "Nidhi", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 156, EmpName = "Yukta", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 157, EmpName = "Priyanka", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 158, EmpName = "Yogita", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 159, EmpName = "Falguni", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 160, EmpName = "Ishwari", DeptName = "IT", Salary = 83000 });
        }
    }
}