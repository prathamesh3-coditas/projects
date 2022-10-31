using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Per_Hierarchy.Models
{
    public class Staff
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Salary { get; set; }
    }


    public class Doctor : Staff
    {
        public string? Education { get; set; }

        public int MaxPatients { get; set; }
    }

    public class Nurse : Staff
    {
        public int ExtraHours { get; set; }

        public int Experience { get; set; }
    }

    public class Driver : Staff
    {
        public string? VehicleType { get; set; }

        public int Bonus { get; set; }

    }
}
