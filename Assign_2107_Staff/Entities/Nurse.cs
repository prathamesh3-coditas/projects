using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2107_Staff.Database;
using Assign_2107_Staff.Logics;

namespace Assign_2107_Staff.Entities
{
    public class Nurse : Staff
    {

        public static int grossNurseCount = 0, taxNurseCount = 0, netNurseCount = 0;

        private int _exp;
        public int Experience { get { return _exp; }
            set {
                if (value>0)
                {
                    _exp = value;
                }
                else
                {
                    while (value<0)
                    {
                        Console.WriteLine("Enter valid experience:");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _exp = value;
                }
            } 
        }


        private int _nightHours;
        public int nightShiftHours {
            get { return _nightHours; }
            set {
                if (value > 0)
                {
                    _nightHours = value;
                }
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Enter valid experience:");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _nightHours = value;

                }
            } 
        }

        public string SpecializationNurse { get; set; }
        public override int GrossIncome(Staff staff)
        {
            Nurse ns = (Nurse)staff;
            return staff.BasicPay + (ns.nightShiftHours * 250);
        }

        public override int Tax(Staff staff)
        {
            return (int)((GrossIncome(staff) * 75) / 10)/100;
        }

        public override int calculateNetIncome(Staff staff)
        {
            return GrossIncome(staff) - Tax(staff);
        }

    }
}
