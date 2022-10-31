using EmployeeRecords;
using System.Diagnostics;

//EmployeeCollection collection = new EmployeeCollection();
//Employee emp = new Employee();


//RecordLogics logic = new RecordLogics();

//Thread taxCalculator;


//string path = @"C:\.net Training\Solution\Employee data\AllData.txt";
//foreach (var item in EmployeeCollection.list)
//{
//    var sal = item.Salary;
//    //taxCalculator = new Thread(()=>logic.CalculateTax(sal));
//    //taxCalculator.Start();
//    item.Tax = logic.CalculateTax(item.Salary);

//    using (StreamWriter sw = new StreamWriter(@"C:\.net Training\Solution\Employee data\AllData.txt",true))
//    {
//        sw.WriteLine($"Emp_No:{item.EmpNo} | Emp_Name:{item.EmpName} | Dept:{item.DepartmentsNo} | Salary:{item.Salary} | Designation:{item.Designation} | Tax_Paid:{item.Tax}");
//    }
//}

//Thread t1 = new Thread(logic.GetData);
//t1.Start();
//t1.Join();

var timer = new Stopwatch();
timer.Start();
RecordLogics logic = new RecordLogics();
Thread t1 = new Thread(logic.TaxCalculations);
t1.Start();
t1.Join();

Thread t2 = new Thread(logic.WriteData);
t2.Start();
t2.Join();

Thread t3 = new Thread(logic.ReadData);
t3.Start();
t3.Join();


timer.Stop();

TimeSpan ts = timer.Elapsed;
Console.WriteLine(ts.TotalMilliseconds);