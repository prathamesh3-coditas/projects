using EmployeeDB;

string wish = "y";
do
{
    Console.WriteLine("Enter department name to get all records");
    string deptCheck = Console.ReadLine();
    int flag = 0;

    var employees = new EmployeeCollection();
    var departments = new DepartmentsCollection();
    var bgThread = new Thread(() =>
    {
        var combinedTables = from emp in employees
                             join dept in departments
                             on emp.DepartmentsNo equals dept.DepartmentsNo
                             where dept.Departmentsname == deptCheck
                             select emp;
        //group emp by dept.Departmentsname;

        Console.WriteLine();

        foreach (var item in combinedTables)
        {
            Console.WriteLine("===========================");
            Console.WriteLine($@"Name: {item.EmpName}
Salary: {item.Salary}
Designation: {item.Designation}
Emp ID: {item.EmpNo}");
            Console.WriteLine("===========================");
            flag = 1;

        }

        if (flag == 0)
        {
            Console.WriteLine("dept not found...!!!");
        }



        //foreach (var item in combinedTables)
        //{
        //    foreach (var item1 in item)
        //    {
        //        Console.WriteLine(item1);
        //    }
        //}
    });
    bgThread.IsBackground = true;
    bgThread.Start();
    //bgThread.Join();

    Console.WriteLine("Do you want to continue?");
    wish = Console.ReadLine();
} while (wish == "y" || wish == "Y");