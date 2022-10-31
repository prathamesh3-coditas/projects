using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2007_Staff.Entities
{
    public class Doctor : Staff
    {

        public string? Education { get; set; }

        public string? specialization { get; set; }

        public int MaxPatientsPerDay { get; set; }

        public int Fees { get; set; }

        public override int calculateNetIncome(int BasicPay)
        {
            return BasicPay + (MaxPatientsPerDay*Fees);
        }
    }
}
