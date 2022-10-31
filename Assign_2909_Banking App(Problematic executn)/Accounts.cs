using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2909_Banking_App
{
    public class Account
    {

        public decimal accNumber { get; set; }

        public string accName { get; set; } = String.Empty;

        public decimal initialBalance { get; set; }

        //public decimal credit { get; set; }

        //public decimal debit { get; set; }

        //public decimal transactionAmount { get; set; }

        public decimal netBalance { get; set; }

        public decimal pastAmnt { get; set; }
    }
}

