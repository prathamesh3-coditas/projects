using Assign_2107_Staff.Entities;
using Assign_2107_Staff.Logics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2107_Staff.Database
{
    public class HospitalDbStore
    {
        public static Dictionary<int,Staff> GlobalStafflist { get; set; } = new Dictionary<int, Staff>();

    }
}
