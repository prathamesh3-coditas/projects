using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Assign_2007_Staff.Database;
namespace Assign_2007_Staff.Logics
{
    public abstract class StaffLogic
    {

        public abstract List<Staff> RegisterStaff(Staff staff);

        public abstract List<Staff> DeleteStaff(int id);   

        public abstract List<Staff> UpdateStaff(int id,Staff staff);
        public abstract List<Staff> GetStaff();

        

    }
}
