using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeRecordsParallel
{
    public class RecordLogics
    {

        public int TaxCalculations(int salary)
        {
            int tax = salary * 15 / 100;
            return tax;
        }

        string path = @"C:\.net Training\Solution\Employee data\Parallel for\AllData.txt";

        //public void WriteData(Employee item)
        //{
        //    //foreach (var item in records)
        //    //{
        //    using (StreamWriter sw = new StreamWriter(path, true))
        //    {
        //        sw.WriteLine($"Emp_No:{item.EmpNo} | Emp_Name:{item.EmpName} | Dept:{item.DepartmentsNo} | Salary:{item.Salary} | Designation:{item.Designation} | Tax_Paid:{item.Tax}");

        //    }
        //    //}
        //}

        //public static readonly object locker = new object();
        public static object locker = new object();
        int counter = 1001;

        public void ReadData(Employee item)
        {

            try
            {
                Monitor.Enter(locker);
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"Emp_No:{item.EmpNo} | Emp_Name:{item.EmpName} | Dept:{item.DepartmentsNo} | Salary:{item.Salary} | Designation:{item.Designation} | Tax_Paid:{item.Tax}");

                }
                using (StreamWriter sw = new StreamWriter($@"C:\.net Training\Solution\Employee data\Parallel for\Salary slips\{counter++}.txt", true))
                {

                    sw.WriteLine($@"
                                    {"================================================="}
                                    {DateTime.Now.ToString("D")}
                                    {"================================================="}
                                    {$"Employee name:{item.EmpName}"}
                                    {$"Employee id:{item.EmpNo}"}
                                    {"----------------------------------------------------"}
                                    
                                    {$"Employee salary:           {item.Salary}"}
                                    {$"Deductions(Tax paid):   {item.Tax}"}     
                                    {"----------------------------------------------------"}
                                    {$"Net salary:             {(item.Salary) - (item.Tax)}"}   
                                    


                                    {"----------------------------------------------------"}");
                };
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(locker);
            }


        }
    }

}

