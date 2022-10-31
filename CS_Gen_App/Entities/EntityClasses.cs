using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entities
{
    public class Staff
    {
        public static int id = 0;

        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;
//==========================================================
        public static void searchedName(string name)
        {
            foreach (var item in Doctor.drList)
            {
                if (name == item.StaffName)
                {
                    Console.WriteLine($"Doctor id: {item.StaffId}");
                    Console.WriteLine($"Doctor name: {item.StaffName}");
                    Console.WriteLine($"Doctor education: {item.Education}");
                    Console.WriteLine($"Doctor specialization: {item.Specilization}");
                    Console.WriteLine("===============================================================");
                }
            }

            foreach (var item in Nurse.nurseList)
            {
                if (name == item.StaffName)
                {
                    Console.WriteLine($"Nurse id: {item.StaffId}");
                    Console.WriteLine($"Nurse name: {item.StaffName}");
                    Console.WriteLine($"Nurse education: {item.Experience}");
                    Console.WriteLine("===============================================================");
                }

            }

            foreach (var item in Driver.driverList)
            {
                if (name == item.StaffName)
                {
                    Console.WriteLine($"Driver id: {item.StaffId}");
                    Console.WriteLine($"Driver name: {item.StaffName}");
                    Console.WriteLine($"Driver vehicle type: {item.VehicleType}");
                    Console.WriteLine("===============================================================");
                }
            }
        }



//===========================================

        public static void searchedId(int id)
        {
            foreach (var item in Doctor.drList)
            {
                if (id == item.StaffId)
                {
                    Console.WriteLine($"Doctor id: {item.StaffId}");
                    Console.WriteLine($"Doctor name: {item.StaffName}");
                    Console.WriteLine($"Doctor education: {item.Education}");
                    Console.WriteLine($"Doctor specialization: {item.Specilization}");
                    Console.WriteLine("===============================================================");
                }
            }

            foreach (var item in Nurse.nurseList)
            {
                if (id == item.StaffId)
                {
                    Console.WriteLine($"Nurse id: {item.StaffId}");
                    Console.WriteLine($"Nurse name: {item.StaffName}");
                    Console.WriteLine($"Nurse education: {item.Experience}");
                    Console.WriteLine("===============================================================");
                }

            }

            foreach (var item in Driver.driverList)
            {
                if (id == item.StaffId)
                {
                    Console.WriteLine($"Driver id: {item.StaffId}");
                    Console.WriteLine($"Driver name: {item.StaffName}");
                    Console.WriteLine($"Driver vehicle type: {item.VehicleType}");
                    Console.WriteLine("===============================================================");
                }
            }
        }
    }

    public class Doctor : Staff
    {
        public static List<Doctor> drList = new List<Doctor>();
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
    }

    public class Nurse : Staff
    {
       public static List <Nurse> nurseList = new List<Nurse>();
        public int Experience { get; set; }
    }

    public class Driver : Staff
    {
       public static List<Driver> driverList = new List<Driver>();
        public string VehicleType { get; set; }
    }

}