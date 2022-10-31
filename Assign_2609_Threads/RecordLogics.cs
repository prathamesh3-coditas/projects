using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeRecords
{
    public class RecordLogics
    {
        EmployeeCollection records = new EmployeeCollection();

        public void TaxCalculations()
        {
            foreach (var item in records)
            {
                int tax = item.Salary * 15 / 100;
                item.Tax = tax;
            }
        }

        string path = @"C:\.net Training\Solution\Employee data\AllData.txt";

        public void WriteData()
        {
            foreach (var item in records)
            {
                using (StreamWriter sw = new StreamWriter(path,true))
                {
                    sw.WriteLine($"Emp_No:{item.EmpNo} | Emp_Name:{item.EmpName} | Dept:{item.DepartmentsNo} | Salary:{item.Salary} | Designation:{item.Designation} | Tax_Paid:{item.Tax}");

                }
            }
        }


        public void ReadData()
        {
            int counter = 1001;
            foreach (var item in records)
            {

                using (StreamWriter sw = new StreamWriter($@"C:\.net Training\Solution\Employee data\Salary slips\{counter++}.txt", true))
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

        }
    }

}

