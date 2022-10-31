
namespace EmployeeRecordsTask
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public int DepartmentsNo { get; set; }
        public int Salary { get; set; }

        public string Designation { get; set; }

        public int Tax { get; set; }


    }
    public class EmployeeCollection : List<Employee>
    {
        //public static List<Employee> list = new List<Employee>();

        public EmployeeCollection()
        {

            Add(new Employee() { EmpNo = 1001, EmpName = "YashodaNandan", DepartmentsNo = 1, Salary = 53000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1002, EmpName = "DevkiNandan", DepartmentsNo = 2, Salary = 33000, Designation = "Developer" });
            Add(new Employee() { EmpNo = 1003, EmpName = "RadheShyam", DepartmentsNo = 3, Salary = 63000, Designation = "Testing" });
            Add(new Employee() { EmpNo = 1004, EmpName = "Gopal", DepartmentsNo = 17, Salary = 13000, Designation = "Developer" });
            Add(new Employee() { EmpNo = 1005, EmpName = "Govind", DepartmentsNo = 13, Salary = 93000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1006, EmpName = "Mohan", DepartmentsNo = 9, Salary = 63000, Designation = "Testing" });
            Add(new Employee() { EmpNo = 1007, EmpName = "Madhav", DepartmentsNo = 3, Salary = 23000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1008, EmpName = "Milind", DepartmentsNo = 20, Salary = 53000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1009, EmpName = "Vasudev", DepartmentsNo = 5, Salary = 63000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1010, EmpName = "Shridhar", DepartmentsNo = 1, Salary = 83000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1011, EmpName = "Yash", DepartmentsNo = 14, Salary = 53000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1012, EmpName = "Dev", DepartmentsNo = 12, Salary = 33000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1013, EmpName = "Radhe", DepartmentsNo = 10, Salary = 63000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1014, EmpName = "Gopalswami", DepartmentsNo = 8, Salary = 13000, Designation = "Developer" });
            Add(new Employee() { EmpNo = 1015, EmpName = "Govindkumar", DepartmentsNo = 6, Salary = 93000, Designation = "Developer" });
            Add(new Employee() { EmpNo = 1016, EmpName = "ManMohan", DepartmentsNo = 9, Salary = 63000, Designation = "Developer" });
            Add(new Employee() { EmpNo = 1017, EmpName = "Madhavan", DepartmentsNo = 12, Salary = 23000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1018, EmpName = "Manshu", DepartmentsNo = 15, Salary = 53000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1019, EmpName = "Vasu", DepartmentsNo = 18, Salary = 63000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1020, EmpName = "Shriram", DepartmentsNo = 11, Salary = 83000, Designation = "HR" });
            Add(new Employee() { EmpNo = 1021, EmpName = "Nandan", DepartmentsNo = 7, Salary = 53000, Designation = "Testing" });
            Add(new Employee() { EmpNo = 1022, EmpName = "Devika", DepartmentsNo = 5, Salary = 33000, Designation = "Testing" });
            Add(new Employee() { EmpNo = 1023, EmpName = "Shyam", DepartmentsNo = 10, Salary = 63000, Designation = "Testing" });
            Add(new Employee() { EmpNo = 1024, EmpName = "Geet", DepartmentsNo = 12, Salary = 13000, Designation = "Administrator" });
            Add(new Employee() { EmpNo = 1025, EmpName = "Ganesh", DepartmentsNo = 13, Salary = 93000, Designation = "Administrator" });
            Add(new Employee() { EmpNo = 1026, EmpName = "Neeti", DepartmentsNo = 19, Salary = 63000, Designation = "Administrator" });
            Add(new Employee() { EmpNo = 1027, EmpName = "Shakti", DepartmentsNo = 19, Salary = 23000, Designation = "Administrator" });
            Add(new Employee() { EmpNo = 1028, EmpName = "Mukesh", DepartmentsNo = 18, Salary = 53000, Designation = "Analyst" });
            Add(new Employee() { EmpNo = 1029, EmpName = "Vasa", DepartmentsNo = 15, Salary = 63000, Designation = "Analyst" });
            Add(new Employee() { EmpNo = 1030, EmpName = "Shivam", DepartmentsNo = 13, Salary = 83000, Designation = "Analyst" });
            Add(new Employee() { EmpNo = 1031, EmpName = "yatharth", DepartmentsNo = 14, Salary = 53000, Designation = "Analyst" });
            Add(new Employee() { EmpNo = 1032, EmpName = "Divyanshi", DepartmentsNo = 8, Salary = 33000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1033, EmpName = "Rahul", DepartmentsNo = 7, Salary = 63000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1034, EmpName = "gautam", DepartmentsNo = 9, Salary = 13000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1035, EmpName = "Gyani", DepartmentsNo = 6, Salary = 93000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1036, EmpName = "Mohit", DepartmentsNo = 8, Salary = 63000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1037, EmpName = "Milu", DepartmentsNo = 9, Salary = 23000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1038, EmpName = "pawan", DepartmentsNo = 11, Salary = 53000, Designation = "QA" });
            Add(new Employee() { EmpNo = 1039, EmpName = "divyesh", DepartmentsNo = 5, Salary = 63000, Designation = "R&D Manager" });
            Add(new Employee() { EmpNo = 1040, EmpName = "roshani", DepartmentsNo = 1, Salary = 83000, Designation = "R&D Manager" });
            Add(new Employee() { EmpNo = 1041, EmpName = "sahil", DepartmentsNo = 1, Salary = 53000, Designation = "R&D Manager" });
            Add(new Employee() { EmpNo = 1042, EmpName = "pari", DepartmentsNo = 2, Salary = 33000, Designation = "R&D Manager" });
            Add(new Employee() { EmpNo = 1043, EmpName = "Rathore", DepartmentsNo = 3, Salary = 63000, Designation = "SDE" });
            Add(new Employee() { EmpNo = 1044, EmpName = "Nikhilesh", DepartmentsNo = 16, Salary = 13000, Designation = "SDE" });
            Add(new Employee() { EmpNo = 1045, EmpName = "Tribhuvan", DepartmentsNo = 13, Salary = 93000, Designation = "SDE" });
            Add(new Employee() { EmpNo = 1046, EmpName = "Mohit", DepartmentsNo = 2, Salary = 63000, Designation = "SDE" });
            Add(new Employee() { EmpNo = 1047, EmpName = "charu", DepartmentsNo = 1, Salary = 23000, Designation = "SDE" });
            Add(new Employee() { EmpNo = 1048, EmpName = "NIkita", DepartmentsNo = 5, Salary = 53000, Designation = "SDE" });
            Add(new Employee() { EmpNo = 1049, EmpName = "Himanshu", DepartmentsNo = 5, Salary = 63000, Designation = "ASE" });
            Add(new Employee() { EmpNo = 1050, EmpName = "bhuresh", DepartmentsNo = 1, Salary = 83000, Designation = "ASE" });
            Add(new Employee() { EmpNo = 1051, EmpName = "Santosh", DepartmentsNo = 20, Salary = 53000, Designation = "ASE" });
            Add(new Employee() { EmpNo = 1052, EmpName = "Ifham", DepartmentsNo = 2, Salary = 33000, Designation = "ASE" });
            Add(new Employee() { EmpNo = 1053, EmpName = "Akshat", DepartmentsNo = 3, Salary = 63000, Designation = "ASE" });
            Add(new Employee() { EmpNo = 1054, EmpName = "nishi", DepartmentsNo = 20, Salary = 13000, Designation = "ASE" });
            Add(new Employee() { EmpNo = 1055, EmpName = "Nidhi", DepartmentsNo = 3, Salary = 93000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1056, EmpName = "Yukta", DepartmentsNo = 2, Salary = 63000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1057, EmpName = "AAshi", DepartmentsNo = 19, Salary = 23000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1058, EmpName = "Yogyata", DepartmentsNo = 5, Salary = 53000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1059, EmpName = "Falguni", DepartmentsNo = 14, Salary = 63000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 1060, EmpName = "Princee", DepartmentsNo = 13, Salary = 83000, Designation = "Manager" });


        }
    }
}