using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App_RecordInFile.Entities
{

    public class Staff
    {


        public static int id = 0;

        public int Basicpay { get; set; }

         
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

        //===================================================


    }

    public class Doctor : Staff
    {


        public static List<Doctor> drList = new List<Doctor>();

        public int MaxPatients { get; set; }

        public int fees { get; set; }
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
    }

    public class Nurse : Staff
    {
       public static List <Nurse> nurseList = new List<Nurse>();

        public int ExtraHours { get; set; }
        public int Experience { get; set; }
    }

    public class Driver : Staff
    {
       public static List<Driver> driverList = new List<Driver>();

        public int Bonus { get; set; }
        public string VehicleType { get; set; }
    }

}