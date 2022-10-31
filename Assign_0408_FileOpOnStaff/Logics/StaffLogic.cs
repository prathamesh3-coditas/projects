using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App_RecordInFile.Entities;

namespace CS_Gen_App_RecordInFile.Model
{

    public class DoctorLogic : IDbOperations<Doctor, int>
    {


        Doctor drObj = new Doctor();
        EventListener eventListener = new EventListener();


        
        
        //public static string msgNotification(String msg)
        //{
        //    return(msg);
        //}

        //OperationHandeller createHandeller = new OperationHandeller(msgNotification);

        Doctor IDbOperations<Doctor, int>.Create(Doctor dr)
        {
            Doctor.drList.Add(dr);
            return dr;

        }

        Doctor IDbOperations<Doctor, int>.Delete(int id)
        {
            foreach (var item in Doctor.drList)
            {
                if (id == item.StaffId)
                {
                    Doctor.drList.Remove(item);
                    break;
                }
            }
            return drObj;
        }

        Doctor IDbOperations<Doctor, int>.Get(int id)
        {
            foreach (var item in Doctor.drList)
            {
                if (id==item.StaffId)
                {
                    return item;
                }
            }
            return Doctor.drList[0];
        }


        List<Doctor> IDbOperations<Doctor, int>.GetAll()
        {
            var getAlphabetically = from record in Doctor.drList
                                    orderby record.StaffName
                                    select record;

            foreach (var item in getAlphabetically)
            {
                Console.WriteLine($"Doctor id: {item.StaffId}");
                Console.WriteLine($"Doctor name: {item.StaffName}");
                Console.WriteLine($"Doctor education: {item.Education}");
                Console.WriteLine($"Doctor specialization: {item.Specilization}");
                Console.WriteLine("===============================================================");
            }

            return new List<Doctor>();
        }

        public int GrossIncome(Doctor staff)
        {
            var c = staff.Basicpay + (staff.MaxPatients * staff.fees);
            return c;
        }

       public int Tax(Doctor staff)
        {
            var c = Convert.ToInt32((GrossIncome(staff)*15)/100);
            return c;
        }

        public int calculateNetIncome(Doctor staff)
        {
            var c =GrossIncome(staff) -Tax(staff);
            return c;
            
        }

        
        public void getSalary(int id)
        {
            DateOnly dateOnly = new DateOnly();
            foreach (var item in Doctor.drList)
            {
                if (item.StaffId == id)
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine(DateTime.Now.ToString("D"));
                    Console.WriteLine("=================================================");
                    Console.WriteLine($"Doctor name:{item.StaffName}");
                    Console.WriteLine();
                    Console.Write($"Doctor id:{item.StaffId}"); Console.Write("     "); 
                    Console.WriteLine($"Edu/Specialization:{item.Education}/{item.Specilization}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Gross income:           {GrossIncome(item)}");
                    Console.WriteLine($"Deductions(Tax paid):   {Tax(item)}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Net salary:             {calculateNetIncome(item)}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------");


                }
            }
        }

        //Doctor d1 = new Doctor();
        //public void getSalary(int id)
        //{
        //    if (Doctor.)
        //    {

        //    }
        //}
        //List<Doctor> IDbOperations<Doctor, int>.GetAll()
        //{
        //    string[] arr = new string[Doctor.drList.Count()];
        //    int i = 0;
        //    foreach (var item in Doctor.drList)
        //    {

        //            arr[i] = item.StaffName;
        //        i++;
        //    }

        //    Array.Sort(arr);

        //        for (int j= 0; j< arr.Length; j++)
        //        {
        //            foreach (var item in Doctor.drList)
        //            {
        //                if (arr[j] == item.StaffName)
        //                {
        //                    Console.WriteLine($"Doctor id: {item.StaffId}");
        //                    Console.WriteLine($"Doctor name: {item.StaffName}");
        //                    Console.WriteLine($"Doctor education: {item.Education}");
        //                    Console.WriteLine($"Doctor specialization: {item.Specilization}");
        //                    Console.WriteLine("===============================================================");
        //                }
        //            }

        //        }
        //    return Doctor.drList;
        //}




        Doctor IDbOperations<Doctor, int>.Update(int id, Doctor entity)
        {
 
            foreach (var item in Doctor.drList)
            {
                var v = item;
                if (item.StaffId == id)
                {

                    String wish = "y";

                    do
                    {
                        Console.WriteLine("====================================================");

                        Console.WriteLine("Press 1 to update name");
                        //Console.WriteLine("Press 2 to update email");
                        Console.WriteLine("Press 2 specialization");
                        Console.WriteLine("Press 3 to update education");
                        int updatedChoice = Convert.ToInt32(Console.ReadLine());

                        switch (updatedChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter updated name");
                                String newName = Console.ReadLine();

                                v.StaffName = newName;
                                eventListener.Updated($"Name updated to {newName}");
                                break;

                            //case 2:
                            //    Console.WriteLine("Enter updated mail");
                            //    String newMail = Console.ReadLine();

                            //    item.Email = newMail;
                            //    break;

                            case 2:
                                Console.WriteLine("Enter updated specialization");
                                String newSpecialization = Console.ReadLine();

                                v.Specilization = newSpecialization;
                                eventListener.Updated($"Specialization updated to {newSpecialization}");
                                break;


                            case 3:
                                Console.WriteLine("Enter updated education");
                                String newEdu = Console.ReadLine();

                                v.Education = newEdu;
                                eventListener.Updated($"Education updated to {newEdu}");
                                break;

                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }

            }   
            return drObj;
        }
    }
//===================================================================================================================
    public class NurseLogic : IDbOperations<Nurse, int>
    {
        Nurse nrObj = new Nurse();
        EventListener eventListener = new EventListener();

        IDbOperations<Nurse, int> interFaceObj;



        Nurse IDbOperations<Nurse, int>.Create(Nurse nr)
        {
            Nurse.nurseList.Add(nr);
            return nr;
        }

        Nurse IDbOperations<Nurse, int>.Delete(int id)
        {
            foreach (var item in Nurse.nurseList)
            {
                if (id == item.StaffId)
                {
                    Nurse.nurseList.Remove(item);
                    break;
                }
            }
            return nrObj;
        }

        Nurse IDbOperations<Nurse, int>.Get(int id)
        {
            foreach (var item in Nurse.nurseList)
            {
                if (id == item.StaffId)
                {
                    return item;
                }
            }
            return Nurse.nurseList[0];
        }

        List<Nurse> IDbOperations<Nurse, int>.GetAll()
        {

            string[] arr = new string[Nurse.nurseList.Count()];
            int i = 0;
            foreach (var item in Nurse.nurseList)
            {

                arr[i] = item.StaffName;
                i++;
            }

            Array.Sort(arr);

            for (int j = 0; j < arr.Length; j++)
            {
                foreach (var item in Nurse.nurseList)
                {
                    if (arr[j] == item.StaffName)
                    {
                        Console.WriteLine($"Nurse id: {item.StaffId}");
                        Console.WriteLine($"Nurse name: {item.StaffName}");
                        Console.WriteLine($"Nurse education: {item.Experience}");
                        Console.WriteLine("===============================================================");
                    }
                }

            }
            return Nurse.nurseList;
        }

        public void getSalary(int id)
        {
            DateOnly dateOnly = new DateOnly();
            foreach (var item in Nurse.nurseList)
            {
                if (item.StaffId == id)
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine(DateTime.Now.ToString("D"));
                    Console.WriteLine("=================================================");
                    Console.WriteLine($"Nurse name:{item.StaffName}");
                    Console.WriteLine();
                    Console.WriteLine($"Nurse id:{item.StaffId}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Gross income:           {GrossIncome(item)}");
                    Console.WriteLine($"[Extra hours]={item.ExtraHours}*250");
                    Console.WriteLine();
                    Console.WriteLine($"Deductions(Tax paid):   {Tax(item)}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Net salary:             {calculateNetIncome(item)}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------");


                }
            }
        }
        public int GrossIncome(Nurse staff)
        {
            return staff.Basicpay + (staff.ExtraHours * 250);

        }

        public int Tax(Nurse staff)
        {
            return (int)((GrossIncome(staff) * 75) / 10)/100;

        }

       public int calculateNetIncome(Nurse staff)
        {
            return GrossIncome(staff) - Tax(staff);

        }

        Nurse IDbOperations<Nurse, int>.Update(int id, Nurse entity)
        {
            foreach (var item in Nurse.nurseList)
            {

                var v = item;
                if (item.StaffId == id)
                {

                    String wish = "y";

                    do
                    {
                        Console.WriteLine("====================================================");

                        Console.WriteLine("Press 1 to update name");
                        //Console.WriteLine("Press 2 to update email");
                        Console.WriteLine("Press 2 experience");
                       // Console.WriteLine("Press 3 to update education");
                        int updatedChoice = Convert.ToInt32(Console.ReadLine());

                        switch (updatedChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter updated name:");
                                String newName = Console.ReadLine();

                                v.StaffName = newName;
                                eventListener.Updated($"Name updated to {newName}");

                                break;

                            //case 2:
                            //    Console.WriteLine("Enter updated mail");
                            //    String newMail = Console.ReadLine();

                            //    item.Email = newMail;
                            //    break;

                            case 2:
                                Console.WriteLine("Enter updated experience:");
                                int newExp = Convert.ToInt32(Console.ReadLine());

                                v.Experience = newExp;
                                eventListener.Updated($"Experience updated to {newExp}");

                                break;

                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }

            }

            return nrObj;
        }
    }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class DriverLogic : IDbOperations<Driver, int>
    {
        Driver drvObj = new Driver();
        EventListener eventListener1 = new EventListener();

        IDbOperations<Driver, int> interFaceobj;

        Driver IDbOperations<Driver, int>.Create(Driver drv)
        {
            Driver.driverList.Add(drv);
            return drv;
        }

        Driver IDbOperations<Driver, int>.Delete(int id)
        {
            foreach (var item in Driver.driverList)
            {
                if (id == item.StaffId)
                {
                    Driver.driverList.Remove(item);
                    break;
                }
            }
            return drvObj;
        }

        Driver IDbOperations<Driver, int>.Get(int id)
        {
            foreach (var item in Driver.driverList)
            {
                if (id == item.StaffId)
                {
                    return item;
                }
            }
            return Driver.driverList[0];
        }

        List<Driver> IDbOperations<Driver, int>.GetAll()
        {

            string[] arr = new string[Driver.driverList.Count()];
            int i = 0;
            foreach (var item in Driver.driverList)
            {

                arr[i] = item.StaffName;
                i++;
            }

            Array.Sort(arr);

            for (int j = 0; j < arr.Length; j++)
            {
                foreach (var item in Driver.driverList)
                {
                    if (arr[j] == item.StaffName)
                    {
                        Console.WriteLine($"Driver id: {item.StaffId}");
                        Console.WriteLine($"Driver name: {item.StaffName}");
                        Console.WriteLine($"Driver vehicle type: {item.VehicleType}");
                        Console.WriteLine("===============================================================");
                    }
                }

            }
            return Driver.driverList;
        }


        public void getSalary(int id)
        {
            DateOnly dateOnly = new DateOnly();
            foreach (var item in Driver.driverList)
            {
                if (item.StaffId == id)
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine(DateTime.Now.ToString("D"));
                    Console.WriteLine("=================================================");
                    Console.WriteLine($"Driver name:{item.StaffName}");
                    Console.WriteLine();
                    Console.WriteLine($"Driver id:{item.StaffId}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Gross income:           {GrossIncome(item)}");
                    Console.WriteLine($"[Bonus amnt]={item.Bonus}");
                    Console.WriteLine();
                    Console.WriteLine($"Deductions(Tax paid):   {Tax(item)}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Net salary:             {calculateNetIncome(item)}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------");


                }
            }
        }
        public int GrossIncome(Driver staff)
        {
            return staff.Basicpay + staff.Bonus;
        }

       public int Tax(Driver staff)
        {
            return (GrossIncome(staff) * 10) / 100;

        }

       public int calculateNetIncome(Driver staff)
        {
            return GrossIncome(staff) - Tax(staff);

        }

        Driver IDbOperations<Driver, int>.Update(int id, Driver entity)
        {
            foreach (var item in Driver.driverList)
            {

                var v = item;
                if (item.StaffId == id)
                {

                    String wish = "y";

                    do
                    {
                        Console.WriteLine("====================================================");

                        Console.WriteLine("Press 1 to update name");
                        //Console.WriteLine("Press 2 to update email");
                        Console.WriteLine("Press 2 to update vehicle");
                        // Console.WriteLine("Press 3 to update education");
                        int updatedChoice = Convert.ToInt32(Console.ReadLine());

                        switch (updatedChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter updated name:");
                                String newName = Console.ReadLine();

                                v.StaffName = newName;
                                eventListener1.Updated($"Name updated to {newName}");
                                break;

                            //case 2:
                            //    Console.WriteLine("Enter updated mail");
                            //    String newMail = Console.ReadLine();

                            //    item.Email = newMail;
                            //    break;

                            case 2:
                                Console.WriteLine("Enter vehicle type:");
                                String newVehicle = Console.ReadLine();

                                v.VehicleType = newVehicle;
                                eventListener1.Updated($"Vehicle updated to {newVehicle}");
                                break;

                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }

            }
            return drvObj;
        }
    }

}