using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2107_Staff.Database;
using Assign_2107_Staff.Logics;

namespace Assign_2107_Staff.Entities
{
    public class Doctor : Staff
    {
        //static int addCount;
        //Dictionary<int, List<String>> _attributes = new Dictionary<int, List<String>>();

        public static int grossDrCount = 0, taxDrCount = 0, netDrCount = 0;

        public string? Education { get; set; }
        
        public string? Specialization { get; set; }



        private int _maxPatients;

        public int MaxPatientsPerDay { get { return _maxPatients; } 
            set {

                if (_maxPatients >= 0)
                {
                    _maxPatients = value;
                }
                else
                {
                    while (value<0)
                    {
                        Console.WriteLine("Enter valid number");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _maxPatients = value;
                }
            } }

        private int _fees;
        public int Fees {
            get { return _fees; } 
            set
            {

                if (_fees >= 0)
                {
                    _fees = value;
                }
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Enter valid number");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _fees = value;
                }
            }
        }

        

        public override int GrossIncome(Staff obj)
        {
            Doctor d = (Doctor)obj;
            var c =  obj.BasicPay + (d.MaxPatientsPerDay * d.Fees);
            // Console.WriteLine($"Gross income of {StaffName} is {c}");
            //addCount++;
           // add(c);
            return c;
        }

        public override int Tax(Staff staff)
        {
            var c = Convert.ToInt32((GrossIncome(staff)*15)/100);
            // Console.WriteLine($"Tax paid by {StaffName} is {c}");
            //addCount++;
            //add(c);
            return c;

        }


        public override int calculateNetIncome(Staff staff)
        {
            var c = GrossIncome(staff) - Tax(staff);
            //Console.WriteLine($"Net income of {StaffName} is {c}");
            //addCount++;
            //add(c);
            //addCount = 0;
            //add(c);
            return c;
        }
        //List<string> list = new List<string>();

        
        //public void add(int gross)
        //{
        //    if(addCount == 1)
        //    {
        //        list.Add($"Gross income is {gross}");

        //    }
        //    else if (addCount==2)
        //    {
        //        list.Add($"Tax paid is {gross}");
        //    }else if (addCount == 3)
        //    {
        //        list.Add($"Net income is {gross}");

        //    }
        //    else if (addCount==0)
        //    {
        //        addDict();
        //    }
        //}
        
        //public void addDict()
        //{
        //    _attributes.Add(StaffId,list);
        //}

        


    }
}
