using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2007_Staff.Entities
{
    public class Nurse : Staff
    {
        public int Experience { get; set; }


        public string specialization { get; set; }
        public int nightShiftHours { get; set; }
        public override int calculateNetIncome(int BasicPay)
        {
            return BasicPay * (nightShiftHours * 250);
        }
    }
}
