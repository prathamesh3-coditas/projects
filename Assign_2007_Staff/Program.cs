// See https://aka.ms/new-console-template for more information
using Assign_2007_Staff.Logics;
using Assign_2007_Staff.Entities;
using Assign_2007_Staff.Database;

DoctorLogic dl = new DoctorLogic();
Doctor drobj = new Doctor();

Nurse nurse = new Nurse();
NurseLogic nl = new NurseLogic();

Technician technician = new Technician();
TechnicianLogic tl = new TechnicianLogic();


String cont = "y";

do
{
    Console.WriteLine("Enter choice for performing operation");

    Console.WriteLine("Enter 1 for Doctor");
    Console.WriteLine("Enter 2 for Nurse");
    Console.WriteLine("Enter 3 for Technician");
    Console.WriteLine("Enter 4 to perform serach operation by name");
    Console.WriteLine("Enter 5 to view list of all staff");
    Console.WriteLine("Enter 6 to get income of staff based on ID");
    Console.WriteLine("Enter 7 to get list of staff having specific specialization");



    Console.WriteLine("=======================================================================================");

    // Console.WriteLine("Enter 4 for Education");


    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            String cont1 = "y";

            do
            {
                Console.WriteLine("1. Insert New Staff");
                Console.WriteLine("2. Update Staff");
                Console.WriteLine("3. Get all Staffs");
                Console.WriteLine("4. Delete a Staff member");
                Console.WriteLine("5. Get Staff Information by Specialization");
                Console.WriteLine("Enter choice:");
                Console.WriteLine("=======================================================================================");

                int subChoice = Convert.ToInt32(Console.ReadLine());

                switch (subChoice)
                {
                    case 1:

                        drobj = new Doctor();
                        drobj.StaffId = Staff.id++;

                        Console.WriteLine("Enter Staff Name");
                        drobj.StaffName = Console.ReadLine();

                        drobj.Catagory = "Doctor";

                        Console.WriteLine("Enter Education");
                        drobj.Education = Console.ReadLine();

                        Console.WriteLine("Enter Specialization");
                        drobj.specialization = Console.ReadLine();

                        Console.WriteLine("Enter patients handelled per day");
                        drobj.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Fees charged by doctor");
                        drobj.Fees = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter basic pay");
                        drobj.BasicPay = Convert.ToInt32(Console.ReadLine());
                        dl.RegisterStaff(drobj);
                        break;


                    case 2:
                        Console.WriteLine("Enter id to update info:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                       var lStaff =  dl.UpdateStaff(id1,drobj);
                        break;

                    case 3:
                        foreach (var item in HospitalDbStore.GlobalStafflist)
                        {
                            var s = item.GetType();
                            var t = drobj.GetType();

                            if (Object.ReferenceEquals(s,t))
                            {
                                var l = (Doctor)item;

                                Console.WriteLine($"Staff Name:{l.StaffName}");
                                Console.WriteLine($"Staff Id :{l.StaffId}");
                                Console.WriteLine($"Staff Education: {l.Education}");
                                Console.WriteLine($"Basic Pay is:{l.BasicPay}");
                                Console.WriteLine($"Specializaton is:{l.specialization}");
                                Console.WriteLine($"Net income of doctor is {drobj.calculateNetIncome(drobj.BasicPay)}");
                                //  Console.WriteLine($"Basic Pay is:{l.calculateNetIncome(BasicPay)}");
                                Console.WriteLine("===============================================================");

                            }

                        }

                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        dl.DeleteStaff(id);
                        foreach (var item in HospitalDbStore.GlobalStafflist)
                        {
                            var l = (Doctor)item;
                            Console.WriteLine($"Staff Name:{l.StaffName}");
                            Console.WriteLine($"Staff Id :{l.StaffId}");
                            Console.WriteLine($"Staff Education: {l.Education}");
                            Console.WriteLine($"Basic Pay is:{l.BasicPay}");
                            Console.WriteLine($"Specializaton is:{l.specialization}");
                            //  Console.WriteLine($"Basic Pay is:{l.calculateNetIncome(BasicPay)}");
                            Console.WriteLine("===============================================================");

                        }
                        break;
                }
                Console.WriteLine("Press y or Y to continue with doctor operations");
                cont1 = Console.ReadLine();
                Console.Clear();
            } while (cont1 == "y" || cont1 == "Y");

            break;


        case 2:


            //String cont1 = "y";
            do
            {
                Console.WriteLine("1. Insert New Staff");
                Console.WriteLine("2. Update Staff");
                Console.WriteLine("3. Get all Staffs");
                Console.WriteLine("4. Delete a Staff member");
                Console.WriteLine("5. Get Staff Information by Specialization");
                Console.WriteLine("Enter choice:");
                int subChoiceNurse = Convert.ToInt32(Console.ReadLine());
                switch (subChoiceNurse)
                {
                    case 1:
                        nurse = new Nurse();
                      //  NurseLogic nl = new NurseLogic();

                        nurse.StaffId = Staff.id++;

                        Console.WriteLine("Enter Staff Name");
                        nurse.StaffName = Console.ReadLine();

                        nurse.Catagory = "Nurse";

                        Console.WriteLine("Enter extra hours");
                        nurse.nightShiftHours = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter nurse specilization");
                        nurse.specialization = Console.ReadLine();

                        Console.WriteLine("Enter Experience:");
                        nurse.Experience = Convert.ToInt32(Console.ReadLine());
                        

                        Console.WriteLine("Enter basic pay");
                        nurse.BasicPay = Convert.ToInt32(Console.ReadLine());
                        nl.RegisterStaff(nurse);
                        break;



                    case 2:
                        Console.WriteLine("Enter id to update info:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        var lStaff = nl.UpdateStaff(id1,nurse);
                        break;


                    case 3:
                        foreach (var item in HospitalDbStore.GlobalStafflist)
                        {
                            var s = item.GetType();
                            var t = nurse.GetType();
                            if (object.ReferenceEquals(s,t))
                            {
                                var p = (Nurse)item;

                                Console.WriteLine($"Staff Name:{p.StaffName}");
                                Console.WriteLine($"Staff Id :{p.StaffId}");
                                //Console.WriteLine($"Staff Education: {p.Education}");
                                Console.WriteLine($"Basic Pay is:{p.BasicPay}");
                                Console.WriteLine(nurse.calculateNetIncome(drobj.BasicPay));

                                Console.WriteLine($"Specializaton is:{p.specialization}");
                                Console.WriteLine("===============================================================");

                            }

                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        nl.DeleteStaff(id);

                        foreach (var item in HospitalDbStore.GlobalStafflist)
                        {
                            var s = (Nurse)item;
                            Console.WriteLine($"Staff Name:{s.StaffName}");
                            Console.WriteLine($"Staff Id :{s.StaffId}");
                            Console.WriteLine($"Staff Id :{s.Experience}");
                            Console.WriteLine($"Staff Id :{s.nightShiftHours}");
                            Console.WriteLine($"Specializaton is:{s.specialization}");
                            Console.WriteLine("===============================================================");


                        }
                        break;
                }
                Console.WriteLine("Press y or Y to continue with nurse");
                cont1 = Console.ReadLine();
                Console.Clear();
            } while (cont1 == "y" || cont1 == "Y");
            break;

        case 3:


            //String cont1 = "y";
            do
            {
                Console.WriteLine("1. Insert New Staff");
                Console.WriteLine("2. Update Staff");
                Console.WriteLine("3. Get all Staffs");
                Console.WriteLine("4. Delete a Staff member");
                Console.WriteLine("5. Get Staff Information by Specialization");
                Console.WriteLine("Enter choice:");
                int subChoiceTech = Convert.ToInt32(Console.ReadLine());
                switch (subChoiceTech)
                {
                    case 1:
                        technician = new Technician();
                        tl = new TechnicianLogic();

                        technician.StaffId = Staff.id++;

                        Console.WriteLine("Enter Staff Name");
                        technician.StaffName = Console.ReadLine();

                        technician.Catagory = "Technician";

                        Console.WriteLine("Enter technician specialization");
                        technician.specialization = Console.ReadLine();

                        Console.WriteLine("Enter extra hours");
                        technician.OverTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Experience:");
                        technician.Exp = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter basic pay");
                        technician.BasicPay = Convert.ToInt32(Console.ReadLine());
                        tl.RegisterStaff(technician);

                        break;

                    case 2:
                        Console.WriteLine("Enter id to update info:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        var lstaff = tl.UpdateStaff(id1,technician);
                        break;
                    case 3:
                        foreach (var item in HospitalDbStore.GlobalStafflist)
                        {
                            var s = item.GetType();
                            var t = technician.GetType();

                            if (object.ReferenceEquals(s,t))
                            {
                                var p = (Nurse)item;
                                Console.WriteLine($"Staff Name:{p.StaffName}");
                                Console.WriteLine($"Staff Id :{p.StaffId}");
                                //Console.WriteLine($"Staff Education: {p.Education}");
                                Console.WriteLine($"Basic Pay is:{p.BasicPay}");
                                Console.WriteLine(technician.calculateNetIncome(drobj.BasicPay));

                                Console.WriteLine($"Specializaton is:{p.specialization}");
                                Console.WriteLine("===============================================================");

                            }

                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        tl.DeleteStaff(id);

                        foreach (var item in HospitalDbStore.GlobalStafflist)
                        {
                            var s = (Technician)item;
                            Console.WriteLine($"Staff Name:{s.StaffName}");
                            Console.WriteLine($"Staff Id :{s.StaffId}");
                            Console.WriteLine($"Experience is :{s.Exp}");
                            Console.WriteLine($"Specialization is :{s.specialization}");
                            Console.WriteLine($"Overtime is:{s.OverTime}");
                            Console.WriteLine("===============================================================");


                        }
                        break;
                }
                Console.WriteLine("Press y or Y to continue with technician");
                cont1 = Console.ReadLine();
                Console.Clear();
            } while (cont1 == "y" || cont1 == "Y");
            break;
           
        
        
        case 4:
            Console.WriteLine("Enter name to search:");
            String nameToSearch = Console.ReadLine();


            
            foreach (var item in HospitalDbStore.GlobalStafflist)
            {
                Type t1 = item.GetType();
                Type t2 = drobj.GetType();
                Type t3 = nurse.GetType();
                Type t4 = technician.GetType();
               
                
                
                if(item.StaffName == nameToSearch &&  Object.ReferenceEquals(t1,t2))
                {
                    var e = (Doctor)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff ID = {e.StaffId}\nStaff Eductaion = {e.Education}\nStaff Specialization = {e.specialization}");
                    Console.WriteLine("===============================================================");
                    break;

                }
                else if (item.StaffName == nameToSearch && Object.ReferenceEquals(t1, t3))
                {
                    var e = (Nurse)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Experience}\nNight shift hours = {e.nightShiftHours}");
                    Console.WriteLine("===============================================================");
                    break;
                }
                else if(item.StaffName == nameToSearch && Object.ReferenceEquals(t1, t4))
                {
                    var e = (Technician)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Exp}\nStaff experience = {e.OverTime}");
                    Console.WriteLine("===============================================================");
                    break;
                }
            }
            break;


        case 5:
            foreach (var item in HospitalDbStore.GlobalStafflist)
            {
                Type t1 = item.GetType();
                Type t2 = drobj.GetType();
                Type t3 = nurse.GetType();
                Type t4 = technician.GetType();



                if (Object.ReferenceEquals(t1, t2))
                {
                    var e = (Doctor)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff ID = {e.StaffId}\nStaff Eductaion = {e.Education}\nStaff Specialization = {e.specialization}");
                    Console.WriteLine("===============================================================");

                }
                else if (Object.ReferenceEquals(t1, t3))
                {
                    var e = (Nurse)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Experience}\nNight shift hours = {e.nightShiftHours}");
                    Console.WriteLine("===============================================================");

                }
                else if (Object.ReferenceEquals(t1, t4))
                {
                    var e = (Technician)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Exp}\nStaff experience = {e.OverTime}");
                    Console.WriteLine("===============================================================");

                }
            }
            break;

        case 6:
            Console.WriteLine("Enter id to get income");
            int idInput = Convert.ToInt32(Console.ReadLine());

            foreach (var item in HospitalDbStore.GlobalStafflist)
            {
                Type t1 = item.GetType();
                Type t2 = drobj.GetType();
                Type t3 = nurse.GetType();
                Type t4 = technician.GetType();

                if (idInput == item.StaffId && Object.ReferenceEquals(t1,t2))
                {
                    var v1 = (Doctor)item;
                    // Console.WriteLine($"Staff name = {v1.StaffName}\nStaff ID = {v1.StaffId}\nStaff Eductaion = {v1.Education}\nStaff Specialization = {v1.Specialization}");
                   var income  = v1.calculateNetIncome(v1.BasicPay);
                    Console.WriteLine($"Income of {v1.StaffName} is {income}");
                    Console.WriteLine("===============================================================");

                }
                else if (idInput == item.StaffId && Object.ReferenceEquals(t1, t3))
                {
                    var v2 = (Nurse)item;
                   // Console.WriteLine($"Staff name = {v2.StaffName}\nStaff id = {v2.StaffId}\nStaff Experience = {v2.Experience}\nNight shift hours = {v2.nightShiftHours}");
                   var income =  v2.calculateNetIncome(v2.BasicPay);
                    Console.WriteLine($"Income of {v2.StaffName} is {income}");
                    Console.WriteLine("===============================================================");

                }
                else if (idInput == item.StaffId && Object.ReferenceEquals(t1, t4))
                {
                    var v3 = (Technician)item;
                    //Console.WriteLine($"Staff name = {v3.StaffName}\nStaff id = {v3.StaffId}\nStaff Experience = {v3.Exp}\nStaff experience = {v3.OverTime}");
                   var income = v3.calculateNetIncome(v3.BasicPay);
                    Console.WriteLine($"Income of {v3.StaffName} is {income}");
                    Console.WriteLine("===============================================================");

                }
            }
            break;


        case 7:

            Console.WriteLine("Enter specialization");
            String spl = Console.ReadLine();
            foreach (var item in HospitalDbStore.GlobalStafflist)
            {
                var v1 = item.GetType();
                var v2 = drobj.GetType();
                var v3 = nl.GetType();
                var v4 = tl.GetType();

                if (Object.ReferenceEquals(v1,v2))
                {
                    var e = (Doctor)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff ID = {e.StaffId}\nStaff Eductaion = {e.Education}\nStaff Specialization = {e.specialization}");
                    Console.WriteLine("===============================================================");
                }
                else if (Object.ReferenceEquals(v1, v3))
                {
                    var e = (Nurse)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Experience}\nNight shift hours = {e.nightShiftHours}");
                    Console.WriteLine("===============================================================");

                }
                else if (Object.ReferenceEquals(v1, v4))
                {
                    var e = (Technician)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Exp}\nStaff experience = {e.OverTime}");
                    Console.WriteLine("===============================================================");

                }
            }
            break;
    }
    Console.WriteLine("Enter \"y\" or \"Y\" to continue to main menu");
    cont = Console.ReadLine();
    Console.Clear();
} while (cont=="y" || cont == "Y");
//DoctorLogic dl = new DoctorLogic();

//Doctor drobj = new Doctor();

//drobj.StaffId = Staff.id++;

//Console.WriteLine("Enter Staff Name");
//drobj.StaffName = Console.ReadLine();

//Console.WriteLine("Enter Catagory");
//drobj.Catagory = Console.ReadLine();

//Console.WriteLine("Enter Education");
//drobj.Education = Console.ReadLine();

//Console.WriteLine("Enter Specialization");
//drobj.Specialization = Console.ReadLine();

//Console.WriteLine("Enter basic pay");
//drobj.BasicPay = Convert.ToInt32(Console.ReadLine());
//dl.RegisterStaff(drobj);
//staffObj.RegisterStaff(drobj);

//============================================================================================================

//Nurse nurse = new Nurse();
//NurseLogic nl = new NurseLogic();

//nurse.StaffId = Staff.id++;

//Console.WriteLine("Enter Staff Name");
//nurse.StaffName = Console.ReadLine();

//Console.WriteLine("Enter Catagory");
//nurse.Catagory = Console.ReadLine();

//Console.WriteLine("Enter extra hours");
//nurse.nightShiftHours = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Experience:");
//nurse.Experience = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter basic pay");
//nurse.BasicPay = Convert.ToInt32(Console.ReadLine());
//nl.RegisterStaff(nurse);

//============================================================================================================
//Technician technician = new Technician();
//TechnicianLogic tl = new TechnicianLogic();

//technician.StaffId = Staff.id++;

//Console.WriteLine("Enter Staff Name");
//technician.StaffName = Console.ReadLine();

//Console.WriteLine("Enter Catagory");
//technician.Catagory = Console.ReadLine();

//Console.WriteLine("Enter extra hours");
//technician.OverTime = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Experience:");
//technician.Exp = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter basic pay");
//technician.BasicPay = Convert.ToInt32(Console.ReadLine());
//tl.RegisterStaff(technician);






//foreach (var item in HospitalDbStore.GlobalStafflist)
//{
//    if (item.Catagory == "Doctor")
//    {
//        var a = (Doctor)(item);

//        Console.WriteLine(a.StaffId+" "+a.StaffName+" "+a.Specialization+" "+a.Catagory+" "+a.calculateNetIncome(a.BasicPay));
//    }

//    if (item.Catagory == "nurse")
//    {
//        var a = (Nurse)(item);

//        Console.WriteLine(a.StaffId + " " + a.StaffName + " " + a.Catagory+" "+a.Experience+" "+a.calculateNetIncome(a.BasicPay));
//    }

//    if (item.Catagory == "technician")
//    {
//        var a = (Technician)(item);

//        Console.WriteLine(a.StaffId + " " + a.StaffName + " " + a.Catagory+" "+a.Exp+" "+a.calculateNetIncome(a.BasicPay));
//    }

//}

