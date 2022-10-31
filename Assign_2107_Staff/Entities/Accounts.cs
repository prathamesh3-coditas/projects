using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2107_Staff.Database;


namespace Assign_2107_Staff.Entities
{
    class Accounts 
    {
        
        Doctor d = new Doctor();
        Nurse n = new Nurse();
        Technician t = new Technician();
        public void GetIncome(int id,Staff staff)
        {


            foreach (var item in HospitalDbStore.GlobalStafflist.Values)
            {
                Type v1 = d.GetType();
                Type v2 = n.GetType();
                Type v3 = t.GetType();
                Type v4 = staff.GetType();
                
                if (Object.ReferenceEquals(v1, v4) && item.StaffId ==id)
                {
                    //var cast = (Doctor)staff;
                    var g = d.GrossIncome(item);
                    Console.WriteLine($"Gross income of {item.StaffName} is {g}");
                    
                    var t = d.Tax(item);
                    Console.WriteLine($"Tax paid by {item.StaffName} is {t}");

                    var n = d.calculateNetIncome(item);
                    Console.WriteLine($"Net income of a {item.StaffName} is {n}");

                }
                else if (Object.ReferenceEquals(v2, v4) && item.StaffId == id)
                {
                    //var cast = (Nurse)staff;
                    var g = n.GrossIncome(item);
                    Console.WriteLine($"Gross income of {item.StaffName} is { g }");

                    var t = n.Tax(item);
                    Console.WriteLine($"Tax paid by {item.StaffName} is {t}");

                    var p = n.calculateNetIncome(item);
                    Console.WriteLine($"Net income of a {item.StaffName} is { p }");

                }
                else if (Object.ReferenceEquals(v3, v4) && item.StaffId == id)
                {
                    //var cast = (Technician)staff;
                    var g = t.GrossIncome(item);
                    Console.WriteLine($"Gross income of {item.StaffName} is {g}");

                    var p = t.Tax(item);
                    Console.WriteLine($"Tax paid by {item.StaffName} is {p}");

                    var n = t.calculateNetIncome(item);
                    Console.WriteLine($"Net income of a {item.StaffName} is {n}");

                }
            }

   

            //return 0;
        }
    }
}
