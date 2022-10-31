using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2007_Staff.Entities
{
    public class Technician : Staff
    {
        public int Exp { get; set; }
        //    public string? Education1 { get; set; }

        public int OverTime { get; set; }

        public string specialization { get; set; }

        public override int calculateNetIncome(int BasicPay)
        {
            return BasicPay + (OverTime * 150);
        }
    }
}
