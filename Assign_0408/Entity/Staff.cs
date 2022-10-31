using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_0408.Entity
{
    public class Staff
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int BasicPay { get; set; }

        public string StaffCatagory { get; set; } = String.Empty;

    }

    public class Doctor : Staff
    {
        public int MaxPatientsPerDay { get; set; }

        public string Education { get; set; } = string.Empty;

        public string Specialization { get; set; } = string.Empty;

    }

    public class Nurse : Staff
    {
        public int ExtraHours { get; set; }

        public int Experience { get; set; }
    }

    public class Driver :Staff
    {
        public int Bonus { get; set; }

        public string Vehicletype { get; set; } = String.Empty;
    }
}
