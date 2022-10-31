using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritence.Models;

namespace CS_Inheritance.Logic
{
    public class StaffLogic
    {

        List<Staff> staffList = new List<Staff>();
        StaffLogic staffLogic;


        public List<Staff> Register(Staff staff)
        {
            staffList.Add(staff);
            return this.staffList;
        }

        public List<Staff> getRecords()
        {
            return staffList;
        }

    }
}
