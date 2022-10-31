using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2107_Staff.Database;
using Assign_2107_Staff.Logics;

namespace Assign_2107_Staff.Entities
{
    public class Technician : Staff
    {

        public static int grossTechCount = 0, taxTechCount = 0, netTechCount = 0;

        private int _exp;
        public int Exp
        {
            get { return _exp; }
            set
            {
                if (value > 0)
                {
                    _exp = value;
                }
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Enter valid Exp:");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _exp = value;
                }
            }
        }


        private int _overtime;
        public int OverTime { get { return _overtime; } 
            set {
                if (value > 0)
                {
                    _overtime = value;
                }
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Enter valid Exp:");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _overtime = value;
                }
            } 
        }

        public string SpecializationTech { get; set; }

        public override int GrossIncome(Staff staff)
        {
            Technician ts = (Technician)staff;
            return staff.BasicPay + (ts.OverTime * 150);
        }

        public override int Tax(Staff staff)
        {
            return (GrossIncome(staff) * 10) / 100;
        }
        public override int calculateNetIncome(Staff staff)
        {
            return GrossIncome(staff) - Tax(staff);

        }

    }

}
