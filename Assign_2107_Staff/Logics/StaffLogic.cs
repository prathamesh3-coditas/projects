using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2107_Staff.Entities;
using Assign_2107_Staff.Database;

namespace Assign_2107_Staff.Logics
{
    public abstract class StaffLogic
    {

        public abstract Dictionary<int,Staff> RegisterStaff(int id,Staff staff);

        //public abstract int GrossIncome(int BasicPay);

        //public abstract int Tax();

        public abstract Dictionary<int, Staff> DeleteStaff(int id);   

        public abstract Dictionary<int, Staff> UpdateStaff(int id,Staff staff);
        public abstract Dictionary<int, Staff> GetStaff();

        

    }
}
