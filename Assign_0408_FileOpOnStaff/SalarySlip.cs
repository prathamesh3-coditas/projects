using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App_RecordInFile.Entities;
using CS_Gen_App_RecordInFile.Model;
namespace Assign_2707_GenApp_RecordInFile
{
    public class SalarySlip
    {
        DoctorLogic doctorLogic = new DoctorLogic();
        NurseLogic nurseLogic = new NurseLogic();
        DriverLogic driverLogic = new DriverLogic();
        public void getSalarySlip(int id,string path,string content)
        {
            string sub = path.Substring(path.Length - 3, 3);
            try
            {
                foreach (var item in Doctor.drList)
                {
                    if (id == item.StaffId && sub.Equals("txt"))
                    {
                        FileStream fs = File.Create(path);

                        fs.Close();
                        
                        File.WriteAllText(path,content);
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Salary slip successfully created !!");
                        Console.WriteLine("You can view it in following path:");
                        Console.WriteLine($@"{path}");
                        Console.WriteLine("----------------------------------------------------");
                    }
                }

                foreach (var item in Nurse.nurseList)
                {
                    if (id == item.StaffId && sub.Equals("txt"))
                    {
                        FileStream fs = File.Create(path);

                        fs.Close();

                        File.WriteAllText(path, content);
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Salary slip successfully created !!");
                        Console.WriteLine("You can view it in following path:");
                        Console.WriteLine($@"{path}");
                        Console.WriteLine("----------------------------------------------------");

                    }
                }

                foreach (var item in Driver.driverList)
                {
                    if (id == item.StaffId && sub.Equals("txt"))
                    {
                        FileStream fs = File.Create(path);

                        fs.Close();

                        File.WriteAllText(path, content);
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Salary slip successfully created !!");
                        Console.WriteLine("You can view it in following path:");
                        Console.WriteLine($@"{path}");
                        Console.WriteLine("----------------------------------------------------");

                    }
                }

                Console.WriteLine();

            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public String getPath(int id)
        {
            foreach (var item in Doctor.drList)
            {
                if (id==item.StaffId)
                {
                    return $"{item.StaffId}_{item.StaffName}";
                    break;
                }
            }

            foreach (var item in Nurse.nurseList)
            {
                if (id == item.StaffId)
                {
                    return $"{item.StaffId}_{item.StaffName}";
                    break;
                }
            }

            foreach (var item in Driver.driverList)
            {
                if (id == item.StaffId)
                {
                    return $"{item.StaffId}_{item.StaffName}";
                    break;
                }
            }

            throw new Exception("Id not found !!");
        }

       
        
        public string getContent(int id)
        {
            try
            {
                foreach (var item in Doctor.drList)
                {
                    if (id == item.StaffId)
                    {
                        var gross = doctorLogic.GrossIncome(item);
                        var tax = doctorLogic.Tax(item);
                        var net = doctorLogic.calculateNetIncome(item);

                        string str = $@"
                                    {"================================================="}
                                    {DateTime.Now.ToString("D")}
                                    {"================================================="}
                                    {$"Doctor name:{item.StaffName}"}
                                    {$"Doctor id:{item.StaffId}"}
                                    {$"Edu/Specialization:{item.Education}/{item.Specilization}"}
                                    {"----------------------------------------------------"}
                                    {$"Gross income:           {gross}"}    {Output(gross)}
                                    {$"Deductions(Tax paid):   {tax}"}      {Output(tax)}
                                    {"----------------------------------------------------"}
                                    {$"Net salary:             {net}"}      {Output(net)}
                                    


                                    {"----------------------------------------------------"}";
                        //Console.WriteLine("=================================================");
                        //Console.WriteLine(DateTime.Now.ToString("D"));
                        //Console.WriteLine("=================================================");
                        //Console.WriteLine($"Doctor name:{item.StaffName}");
                        //Console.WriteLine();
                        //Console.Write($"Doctor id:{item.StaffId}"); Console.Write("     ");
                        //Console.WriteLine($"Edu/Specialization:{item.Education}/{item.Specilization}");
                        //Console.WriteLine("----------------------------------------------------");
                        //Console.WriteLine($"Gross income:           {doctorLogic.GrossIncome(item)}");
                        //Console.WriteLine($"Deductions(Tax paid):   {doctorLogic.Tax(item)}");
                        //Console.WriteLine("----------------------------------------------------");
                        //Console.WriteLine($"Net salary:             {doctorLogic.calculateNetIncome(item)}");
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine("----------------------------------------------------");
                        return str;
                        break;
                    }
                }

                foreach (var item in Nurse.nurseList)
                {
                    if (id == item.StaffId)
                    {
                        var gross = nurseLogic.GrossIncome(item);
                        var tax = nurseLogic.Tax(item);
                        var net = nurseLogic.calculateNetIncome(item);
                        string str1 = $@"
                                    {"================================================="}
                                    {DateTime.Now.ToString("D")}
                                    {"================================================="}
                                    {$"Nurse name:{item.StaffName}"}
                                    {$"Nurse id:{item.StaffId}"}
                                    {"----------------------------------------------------"}
                                    {$"Gross income:           {gross}"}    {Output(gross)}
                                    {$"[Extra hours]={item.ExtraHours}"}    
                                    {$"Deductions(Tax paid):   {tax}"}      {Output(tax)}
                                    {"----------------------------------------------------"}
                                    {$"Net salary:             {net}"}      {Output(net)}
                                    


                                    {"----------------------------------------------------"}";
                        //Console.WriteLine("=================================================");
                        //Console.WriteLine(DateTime.Now.ToString("D"));
                        //Console.WriteLine("=================================================");
                        //Console.WriteLine($"Nurse name:{item.StaffName}");
                        //Console.WriteLine();
                        //Console.WriteLine($"Nurse id:{item.StaffId}");
                        //Console.WriteLine("----------------------------------------------------");
                        //Console.WriteLine($"Gross income:           {nurseLogic.GrossIncome(item)}");
                        //Console.WriteLine($"[Extra hours]={item.ExtraHours}");
                        //Console.WriteLine();
                        //Console.WriteLine($"Deductions(Tax paid):   {nurseLogic.Tax(item)}");
                        //Console.WriteLine("----------------------------------------------------");
                        //Console.WriteLine($"Net salary:             {nurseLogic.calculateNetIncome(item)}");
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine("----------------------------------------------------");
                        return str1;
                        break;
                    }
                }

                foreach (var item in Driver.driverList)
                {
                    if (id == item.StaffId)
                    {
                        var gross = driverLogic.GrossIncome(item);
                        var tax = driverLogic.Tax(item);
                        var net = driverLogic.calculateNetIncome(item);

                        string str2 = $@"
                                    {"================================================="}
                                    {DateTime.Now.ToString("D")}
                                    {"================================================="}
                                    {$"Driver name: {item.StaffName}"}
                                    {$"Driver id:   {item.StaffId}"}
                                    {"----------------------------------------------------"}
                                    {$"Gross income:           {gross}"}    {Output(gross)}
                                    {$"[Bonus]={item.Bonus}"}
                                    {$"Deductions(Tax paid):   {tax}"}      {Output(tax)}
                                    {"----------------------------------------------------"}
                                    {$"Net salary:             {net}"}      {Output(net)}
                                    


                                    {"----------------------------------------------------"}";
                        //Console.WriteLine("=================================================");
                        //Console.WriteLine(DateTime.Now.ToString("D"));
                        //Console.WriteLine("=================================================");
                        //Console.WriteLine($"Driver name:{item.StaffName}");
                        //Console.WriteLine();
                        //Console.WriteLine($"Driver id:{item.StaffId}");
                        //Console.WriteLine("----------------------------------------------------");
                        //Console.WriteLine($"Gross income:           {driverLogic.GrossIncome(item)}");
                        //Console.WriteLine($"[Bonus]={item.Bonus}");
                        //Console.WriteLine();
                        //Console.WriteLine($"Deductions(Tax paid):   {driverLogic.Tax(item)}");
                        //Console.WriteLine("----------------------------------------------------");
                        //Console.WriteLine($"Net salary:             {driverLogic.calculateNetIncome(item)}");
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine("----------------------------------------------------");
                        return str2;
                        break;
                    }
                }

                throw new Exception("Id not found !!");
            }
            catch (Exception e)
            {

                throw e;
            }   
        }



//        Console.WriteLine("Enter a Number to convert to words");
//Int64 number = Convert.ToInt64(Console.ReadLine());
//        var s = Output(number);
//        Console.WriteLine(s);
static String Output(Int64 number)
        {
            String[]? units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
            String[]? tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            if (number < 20)
            {
                return units[number];
            }
            if (number < 100)
            {
                return tens[number / 10] + ((number % 10 > 0) ? " " + Output(number % 10) : "");
            }
            if (number < 1000)
            {
                return units[number / 100] + " Hundred"
                        + ((number % 100 > 0) ? " And " + Output(number % 100) : "");
            }
            if (number < 100000)
            {
                return Output(number / 1000) + " Thousand "
                        + ((number % 1000 > 0) ? " " + Output(number % 1000) : "");
            }
            if (number < 10000000)
            {
                return Output(number / 100000) + " Lakh "
                        + ((number % 100000 > 0) ? " " + Output(number % 100000) : "");
            }
            if (number < 1000000000)
            {
                return Output(number / 10000000) + " Crore "
                        + ((number % 10000000 > 0) ? " " + Output(number % 10000000) : "");
            }
            else
            {
                return Output(number / 1000000000) + " Arab "
                        + ((number % 1000000000 > 0) ? " " + Output(number % 1000000000) : "");
            }
        }
    }
}
