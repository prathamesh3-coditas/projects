// See https://aka.ms/new-console-template for more information
using Assign_2107_Staff.Logics;
using Assign_2107_Staff.Entities;
using Assign_2107_Staff.Database;
using System.Collections.Generic;


DoctorLogic dl = new DoctorLogic();
Doctor drobj = new Doctor();

Nurse nurse = new Nurse();
NurseLogic nl = new NurseLogic();

Technician technician = new Technician();
TechnicianLogic tl = new TechnicianLogic();

Accounts acc = new Accounts();

String cont = "y";

List<int> grossDr = new List<int>();
List<int> taxDr = new List<int>();
List<int> netDr = new List<int>();

List<int> grossNurse = new List<int>();
List<int> taxNurse = new List<int>();
List<int> netNurse = new List<int>();

List<int> grossTech = new List<int>();
List<int> taxTech = new List<int>();
List<int> netTech = new List<int>();

do
{
    Console.WriteLine("Enter choice for performing operation");

    Console.WriteLine("Enter 1 for Doctor");
    Console.WriteLine("Enter 2 for Nurse");
    Console.WriteLine("Enter 3 for Technician");
    Console.WriteLine("Enter 4 to perform serach operation");
    Console.WriteLine("Enter 5 to view list of all staff");
    Console.WriteLine("Enter 6 to get income of staff based on ID");
    Console.WriteLine("Enter 7 to get income by passing single object");


    Console.WriteLine("=======================================================================================");

    // Console.WriteLine("Enter 4 for Education");


    int choice = Convert.ToInt32(Console.ReadLine());

    double time = 10;

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
                Console.WriteLine("Enter choice:");
                Console.WriteLine("=======================================================================================");

                int subChoice = Convert.ToInt32(Console.ReadLine());

                switch (subChoice)
                {
                    case 1:

                       Doctor drObj = new Doctor()
                        {
                            StaffId = 101,
                            StaffName = "Kelvin",
                            Catagory = "Doctor",
                            Education = "BHMS",
                            Specialization = "heart",
                            MaxPatientsPerDay = 10,
                            Fees = 50,
                            BasicPay = 4500
                        };
                        dl.RegisterStaff(drObj.StaffId, drObj);
                       // drObj.GrossIncome(drObj);
                        grossDr.Add(drobj.GrossIncome(drObj));
                       // drObj.Tax(drObj);
                        taxDr.Add(drobj.Tax(drObj));
                        //drObj.calculateNetIncome(drObj);
                        netDr.Add(drobj.calculateNetIncome(drObj));

                        drObj = new Doctor()
                        {
                            StaffId = 102,
                            StaffName = "John",
                            Catagory = "Doctor",
                            Education = "MD",
                            Specialization = "cancer",
                            MaxPatientsPerDay = 8,
                            Fees = 500,
                            BasicPay = 6000
                        };
                        dl.RegisterStaff(drObj.StaffId, drObj);
                        //drObj.GrossIncome(drObj);
                        grossDr.Add(drobj.GrossIncome(drObj));

                        // drObj.Tax(drObj);
                        taxDr.Add(drobj.Tax(drObj));

                        // drObj.calculateNetIncome(drObj);
                        netDr.Add(drobj.calculateNetIncome(drObj));



                        drObj = new Doctor()
                        {
                            StaffId = 103,
                            StaffName = "Sara",
                            Catagory = "Doctor",
                            Education = "MBBS",
                            Specialization = "heart",
                            MaxPatientsPerDay = 10,
                            Fees = 150,
                            BasicPay = 5210
                        };
                        dl.RegisterStaff(drObj.StaffId, drObj);
                        //drObj.GrossIncome(drObj);
                        grossDr.Add(drobj.GrossIncome(drObj));

                        //drObj.Tax(drObj);
                        taxDr.Add(drobj.Tax(drObj));

                        //drObj.calculateNetIncome(drObj);
                        netDr.Add(drobj.calculateNetIncome(drObj));




                        drObj = new Doctor()
                        {
                            StaffId = 104,
                            StaffName = "Maria",
                            Catagory = "Doctor",
                            Education = "MD",
                            Specialization = "organ",
                            MaxPatientsPerDay = 9,
                            Fees = 150,
                            BasicPay = 6410
                        };
                        dl.RegisterStaff(drObj.StaffId, drObj);
                        // drObj.GrossIncome(drObj);
                        grossDr.Add(drobj.GrossIncome(drObj));

                        // drObj.Tax(drObj);
                        taxDr.Add(drobj.Tax(drObj));

                        // drObj.calculateNetIncome(drObj);
                        netDr.Add(drobj.calculateNetIncome(drObj));



                        drObj = new Doctor();
                        drObj.StaffId = Staff.id++;

                        Console.WriteLine("Enter Staff Name");
                        drObj.StaffName = Console.ReadLine();

                        drObj.Catagory = "Doctor";

                        Console.WriteLine("Enter Education");
                        drObj.Education = Console.ReadLine();

                        Console.WriteLine("Enter Specialization");
                        drObj.Specialization = Console.ReadLine();

                        Console.WriteLine("Enter patients handelled per day");
                        drObj.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Fees charged by doctor");
                        drObj.Fees = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter basic pay");
                        drObj.BasicPay = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter shift start time:");
                        int startHour = Convert.ToInt32(Console.ReadLine());


                        dl.RegisterStaff(drObj.StaffId, drObj);
                        grossDr.Add(drobj.GrossIncome(drObj));
                        taxDr.Add(drobj.Tax(drObj));
                        netDr.Add(drobj.calculateNetIncome(drObj));

                        break;


                    case 2:
                        Console.WriteLine("Enter id to update info:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        var lStaff = dl.UpdateStaff(id1, drobj);
                        break;

                    case 3:
                        foreach (var item in HospitalDbStore.GlobalStafflist.Values)
                        {
                            var q = item.GetType();
                            var d = drobj.GetType();
                            if (Object.ReferenceEquals(q,d))
                            {
                                var l = (Doctor)item;
                                Console.WriteLine($"Staff Name:{l.StaffName}");
                                Console.WriteLine($"Staff Id :{l.StaffId}");
                                Console.WriteLine($"Staff Education: {l.Education}");
                                Console.WriteLine($"Basic Pay is:{l.BasicPay}");
                                Console.WriteLine($"Specializaton is:{l.Specialization}");
                                //Console.WriteLine($"Gross income of dr = {drobj.GrossIncome(drobj)}");
                                //Console.WriteLine($"Tax paid by dr = {drobj.Tax(drobj)}");
                                //Console.WriteLine($"Net income of doctor = {drobj.calculateNetIncome(drobj)}");
                                if (Doctor.grossDrCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Gross income of dr = {grossDr[Doctor.grossDrCount++]}");
                                }

                                if (Doctor.taxDrCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Tax paid by dr = {taxDr[Doctor.taxDrCount++]}");

                                }
                                if (Doctor.netDrCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Net income of doctor = {netDr[Doctor.netDrCount++]}");
                                }


                                Console.WriteLine("========================================================================");
                            }
                            

                            //  Console.WriteLine($"Basic Pay is:{l.calculateNetIncome(BasicPay)}");

                        }

                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        dl.DeleteStaff(id);
                        foreach (var item in HospitalDbStore.GlobalStafflist.Values)
                        {
                            var q = item.GetType();
                            var d = drobj.GetType();
                            if (Object.ReferenceEquals(q, d))
                            {
                                var l = (Doctor)item;
                                Console.WriteLine($"Staff Name:{l.StaffName}");
                                Console.WriteLine($"Staff Id :{l.StaffId}");
                                Console.WriteLine($"Staff Education: {l.Education}");
                                Console.WriteLine($"Basic Pay is:{l.BasicPay}");
                                Console.WriteLine($"Specializaton is:{l.Specialization}");
                                Console.WriteLine("========================================================================");
                            }
                            

                            //  Console.WriteLine($"Basic Pay is:{l.calculateNetIncome(BasicPay)}");

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
                Console.WriteLine("Enter choice:");
                int subChoiceNurse = Convert.ToInt32(Console.ReadLine());
                switch (subChoiceNurse)
                {
                    case 1:
                        nurse = new Nurse()
                        {
                            StaffId = 201,StaffName="Disha",Catagory="Nurse",nightShiftHours=3,
                            Experience=4,BasicPay=2500
                        };
                        nl.RegisterStaff(nurse.StaffId, nurse);
                        //nurse.GrossIncome(nurse);
                        grossNurse.Add(nurse.GrossIncome(nurse));
                       // nurse.Tax(nurse);
                        taxNurse.Add(nurse.Tax(nurse));
                        //nurse.calculateNetIncome(nurse);
                        netNurse.Add(nurse.calculateNetIncome(nurse));

                        nurse = new Nurse()
                        {
                            StaffId = 202,
                            StaffName = "Disha",
                            Catagory = "Nurse",
                            nightShiftHours = 6,
                            Experience = 1,
                            BasicPay = 3400
                        };
                        nl.RegisterStaff(nurse.StaffId, nurse);
                        //nurse.GrossIncome(nurse);
                        grossNurse.Add(nurse.GrossIncome(nurse));

                        //nurse.Tax(nurse);
                        taxNurse.Add(nurse.Tax(nurse));

                        //nurse.calculateNetIncome(nurse);
                        netNurse.Add(nurse.calculateNetIncome(nurse));


                        nurse = new Nurse()
                        {
                            StaffId = 203,
                            StaffName = "Alia",
                            Catagory = "Nurse",
                            nightShiftHours = 7,
                            Experience = 2,
                            BasicPay = 3800
                        };
                        nl.RegisterStaff(nurse.StaffId, nurse);
                        //nurse.GrossIncome(nurse);
                        grossNurse.Add(nurse.GrossIncome(nurse));

                        //nurse.Tax(nurse);
                        taxNurse.Add(nurse.Tax(nurse));

                        // nurse.calculateNetIncome(nurse);
                        netNurse.Add(nurse.calculateNetIncome(nurse));


                        nurse = new Nurse()
                        {
                            StaffId = 204,
                            StaffName = "Anushka",
                            Catagory = "Nurse",
                            nightShiftHours = 5,
                            Experience = 8,
                            BasicPay = 3200
                        };
                        nl.RegisterStaff(nurse.StaffId, nurse);
                        //nurse.GrossIncome(nurse);
                        grossNurse.Add(nurse.GrossIncome(nurse));

                        // nurse.Tax(nurse);
                        taxNurse.Add(nurse.Tax(nurse));

                        //nurse.calculateNetIncome(nurse);
                        netNurse.Add(nurse.calculateNetIncome(nurse));

                      
                        nurse = new Nurse();

                        nurse.StaffId = Staff.id++;

                        Console.WriteLine("Enter Staff Name");
                        nurse.StaffName = Console.ReadLine();

                        nurse.Catagory = "Nurse";

                        Console.WriteLine("Enter extra hours");
                        nurse.nightShiftHours = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Experience:");
                        nurse.Experience = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter basic pay");
                        nurse.BasicPay = Convert.ToInt32(Console.ReadLine());
                        nl.RegisterStaff(nurse.StaffId,nurse);
                        grossNurse.Add(nurse.GrossIncome(nurse));
                        taxNurse.Add(nurse.Tax(nurse));
                        netNurse.Add(nurse.calculateNetIncome(nurse));

                        break;



                    case 2:
                        Console.WriteLine("Enter id to update info:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        var lStaff = nl.UpdateStaff(id1, nurse);
                        break;


                    case 3:
                        foreach (var item in HospitalDbStore.GlobalStafflist.Values)
                        {
                            var r = item.GetType();
                            var t = nurse.GetType();
                            if (Object.ReferenceEquals(r, t))
                            {
                                var p = (Nurse)item;
                                Console.WriteLine($"Staff Name:{p.StaffName}");
                                Console.WriteLine($"Staff Id :{p.StaffId}");
                                //Console.WriteLine($"Staff Education: {p.Education}");
                                Console.WriteLine($"Basic Pay is:{p.BasicPay}");

                                if (Nurse.grossNurseCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Gross income of dr = {grossNurse[Nurse.grossNurseCount++]}");
                                }

                                if (Nurse.taxNurseCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Tax paid by dr = {taxNurse[Nurse.taxNurseCount++]}");

                                }
                                if (Nurse.netNurseCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Net income of doctor = {netNurse[Nurse.netNurseCount++]}");
                                }
                                //Console.WriteLine($"Gross income of nurse = {nurse.GrossIncome(nurse)}");
                                //Console.WriteLine($"Tax paid by nurse = {nurse.Tax(nurse)}");
                                //Console.WriteLine($"Net income of nurse = {nurse.calculateNetIncome(nurse)}");

                                Console.WriteLine("========================================================================");

                            }

                            // Console.WriteLine($"Specializaton is:{p.Specialization}")
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        nl.DeleteStaff(id);

                        foreach (var item in HospitalDbStore.GlobalStafflist.Values)
                        {
                            var q = item.GetType();
                            var d = nurse.GetType();
                            if (Object.ReferenceEquals(q, d))
                            {

                                var s = (Nurse)item;
                                Console.WriteLine($"Staff Name:{s.StaffName}");
                                Console.WriteLine($"Staff Id :{s.StaffId}");
                                Console.WriteLine($"Staff Id :{s.Experience}");
                                Console.WriteLine($"Staff Id :{s.nightShiftHours}");
                                Console.WriteLine("========================================================================");

                            }
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
                Console.WriteLine("Enter choice:");
                int subChoiceTech = Convert.ToInt32(Console.ReadLine());
                switch (subChoiceTech)
                {
                    case 1:

                        technician = new Technician()
                        {
                            StaffId = 301,StaffName="Rajesh",Catagory="Technician",
                            OverTime=3,Exp=12,BasicPay=4500
                        };
                        tl.RegisterStaff(technician.StaffId,technician);
                        //technician.GrossIncome(technician);
                        grossTech.Add(technician.GrossIncome(technician));
                        //technician.Tax(technician);
                        taxTech.Add(technician.Tax(technician));
                        //technician.calculateNetIncome(technician);
                        netTech.Add(technician.calculateNetIncome(technician));


                        technician = new Technician()
                        {
                            StaffId = 302,
                            StaffName = "Mayur",
                            Catagory = "Technician",
                            OverTime = 5,
                            Exp = 2,
                            BasicPay = 2300
                        };
                        tl.RegisterStaff(technician.StaffId, technician);
                        //technician.GrossIncome(technician);
                        grossTech.Add(technician.GrossIncome(technician));

                        //technician.Tax(technician);
                        taxTech.Add(technician.Tax(technician));

                        //technician.calculateNetIncome(technician);
                        netTech.Add(technician.calculateNetIncome(technician));



                        technician = new Technician()
                        {
                            StaffId = 303,
                            StaffName = "Divya",
                            Catagory = "Technician",
                            OverTime = 9,
                            Exp = 8,
                            BasicPay = 5500
                        };
                        tl.RegisterStaff(technician.StaffId, technician);
                        //technician.GrossIncome(technician);
                        grossTech.Add(technician.GrossIncome(technician));

                        //technician.Tax(technician);
                        taxTech.Add(technician.Tax(technician));

                        //technician.calculateNetIncome(technician);
                        netTech.Add(technician.calculateNetIncome(technician));




                        technician = new Technician()
                        {
                            StaffId = 304,
                            StaffName = "Rajesh",
                            Catagory = "Technician",
                            OverTime = 9,
                            Exp = 3,
                            BasicPay = 8000
                        };
                        tl.RegisterStaff(technician.StaffId, technician);
                        //technician.GrossIncome(technician);
                        grossTech.Add(technician.GrossIncome(technician));

                        //technician.Tax(technician);
                        taxTech.Add(technician.Tax(technician));

                        //technician.calculateNetIncome(technician);
                        netTech.Add(technician.calculateNetIncome(technician));


                        technician = new Technician();
                        tl = new TechnicianLogic();

                        technician.StaffId = Staff.id++;

                        Console.WriteLine("Enter Staff Name");
                        technician.StaffName = Console.ReadLine();

                        technician.Catagory = "Technician";

                        Console.WriteLine("Enter extra hours");
                        technician.OverTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Experience:");
                        technician.Exp = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter basic pay");
                        technician.BasicPay = Convert.ToInt32(Console.ReadLine());
                        tl.RegisterStaff(technician.StaffId, technician);
                        grossTech.Add(technician.GrossIncome(technician));
                        taxTech.Add(technician.Tax(technician));
                        netTech.Add(technician.calculateNetIncome(technician));


                        break;

                    case 2:
                        Console.WriteLine("Enter id to update info:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        var lstaff = tl.UpdateStaff(id1, technician);
                        break;
                    case 3:
                        foreach (var item in HospitalDbStore.GlobalStafflist.Values)
                        {
                            var r = item.GetType();
                            var t = technician.GetType();
                            if (Object.ReferenceEquals(r, t))
                            {
                                var p = (Technician)item;
                                Console.WriteLine($"Staff Name:{p.StaffName}");
                                Console.WriteLine($"Staff Id :{p.StaffId}");
                                //Console.WriteLine($"Staff Education: {p.Education}");
                                Console.WriteLine($"Basic Pay is:{p.BasicPay}");

                                if (Technician.grossTechCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Gross income of dr = {grossTech[Technician.grossTechCount++]}");
                                }

                                if (Technician.taxTechCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Tax paid by dr = {taxTech[Technician.taxTechCount++]}");

                                }
                                if (Technician.netTechCount < HospitalDbStore.GlobalStafflist.Count())
                                {
                                    Console.WriteLine($"Net income of doctor = {netTech[Technician.netTechCount++]}");
                                }
                                //Console.WriteLine($"Gross income of nurse = {technician.GrossIncome(technician)}");
                                //Console.WriteLine($"Tax paid by nurse = {technician.Tax(technician)}");
                                //Console.WriteLine($"Net income of nurse = {technician.calculateNetIncome(technician)}");
                                Console.WriteLine("========================================================================");
                            }
                               

                            // Console.WriteLine($"Specializaton is:{p.Specialization}")
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        tl.DeleteStaff(id);

                        foreach (var item in HospitalDbStore.GlobalStafflist.Values)
                        {
                            var r = item.GetType();
                            var t = technician.GetType();
                            if (Object.ReferenceEquals(r, t))
                            {
                                var s = (Technician)item;
                                Console.WriteLine($"Staff Name:{s.StaffName}");
                                Console.WriteLine($"Staff Id :{s.StaffId}");
                                Console.WriteLine($"Staff Id :{s.Exp}");
                                Console.WriteLine($"Staff Id :{s.OverTime}");
                                Console.WriteLine("========================================================================");
                            }
                               

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



            foreach (var item in HospitalDbStore.GlobalStafflist.Values)
            {
                Type t1 = item.GetType();
                Type t2 = drobj.GetType();
                Type t3 = nurse.GetType();
                Type t4 = technician.GetType();



                if (item.StaffName == nameToSearch && Object.ReferenceEquals(t1, t2))
                {
                    var e = (Doctor)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff ID = {e.StaffId}\nStaff Eductaion = {e.Education}\nStaff Specialization = {e.Specialization}");
                    Console.WriteLine("========================================================================");
                }
                else if (item.StaffName == nameToSearch && Object.ReferenceEquals(t1, t3))
                {
                    var e = (Nurse)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Experience}\nNight shift hours = {e.nightShiftHours}");
                    Console.WriteLine("========================================================================");
                }
                else if (item.StaffName == nameToSearch && Object.ReferenceEquals(t1, t4))
                {
                    var e = (Technician)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Exp}\nStaff experience = {e.OverTime}");
                    Console.WriteLine("========================================================================");
                }
            }
            break;


        case 5:
            foreach (var item in HospitalDbStore.GlobalStafflist.Values)
            {
                Type t1 = item.GetType();
                Type t2 = drobj.GetType();
                Type t3 = nurse.GetType();
                Type t4 = technician.GetType();



                if (Object.ReferenceEquals(t1, t2))
                {
                    var e = (Doctor)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff ID = {e.StaffId}" +
                        $"\nStaff Eductaion = {e.Education}\n" + $"Staff Specialization = {e.Specialization}\n" +
                        $"Gross income: {e.GrossIncome(item)}\n" +$"Tax paid: {e.Tax(item)}\nNet income:{e.calculateNetIncome(item)}");
                    Console.WriteLine("========================================================================");
                }
                else if (Object.ReferenceEquals(t1, t3))
                {
                    var e = (Nurse)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\n" +
                        $"Staff Experience = {e.Experience}\nNight shift hours = {e.nightShiftHours}" +
                        $"Gross income:{e.GrossIncome(item)}\nTax paid: {e.Tax(item)}\nNet income: {e.calculateNetIncome(item)}");
                    Console.WriteLine("========================================================================");
                }
                else if (Object.ReferenceEquals(t1, t4))
                {
                    var e = (Technician)item;
                    Console.WriteLine($"Staff name = {e.StaffName}\nStaff id = {e.StaffId}\nStaff Experience = {e.Exp}\n" +
                        $"Staff experience = {e.OverTime}\nGross income: {e.GrossIncome(item)}\nTax paid : {e.Tax(item)}\n" +
                        $"Net income : {e.calculateNetIncome(item)}");
                    Console.WriteLine("========================================================================");
                }
            }
            break;

        case 6:
            Console.WriteLine("Enter id to get income");
            int idInput = Convert.ToInt32(Console.ReadLine());

            foreach (var item in HospitalDbStore.GlobalStafflist.Values)
            {
                Type t1 = item.GetType();
                Type t2 = drobj.GetType();
                Type t3 = nurse.GetType();
                Type t4 = technician.GetType();

                if (idInput == item.StaffId && Object.ReferenceEquals(t1, t2))
                {
                    var v1 = (Doctor)item;
                    // Console.WriteLine($"Staff name = {v1.StaffName}\nStaff ID = {v1.StaffId}\nStaff Eductaion = {v1.Education}\nStaff Specialization = {v1.Specialization}");
                    var income = v1.calculateNetIncome(v1);
                    Console.WriteLine($"Net income is {income}");
                }
                else if (idInput == item.StaffId && Object.ReferenceEquals(t1, t3))
                {
                    var v2 = (Nurse)item;
                    // Console.WriteLine($"Staff name = {v2.StaffName}\nStaff id = {v2.StaffId}\nStaff Experience = {v2.Experience}\nNight shift hours = {v2.nightShiftHours}");
                    var income = v2.calculateNetIncome(v2);
                    Console.WriteLine($"Net income is {income}");
                }
                else if (idInput == item.StaffId && Object.ReferenceEquals(t1, t4))
                {
                    var v3 = (Technician)item;
                    //Console.WriteLine($"Staff name = {v3.StaffName}\nStaff id = {v3.StaffId}\nStaff Experience = {v3.Exp}\nStaff experience = {v3.OverTime}");
                    var income = v3.calculateNetIncome(v3);
                    Console.WriteLine($"Net income is {income}");
                }
            }
            break;

        case 7:
            Console.WriteLine("Pass id to get income details");
            int idIncome = Convert.ToInt32(Console.ReadLine());

            foreach (var item in HospitalDbStore.GlobalStafflist.Values)
            {
                var st = item.GetType();
                var dr = drobj.GetType();
                var nu = nurse.GetType();
                var te = technician.GetType();

                if (item.StaffId == idIncome)
                {
                    if (Object.ReferenceEquals(st, dr))
                    {
                        acc.GetIncome(item.StaffId,drobj);
                    }
                    else if (Object.ReferenceEquals(st,nu))
                    {
                        acc.GetIncome(item.StaffId, nurse);
                    }
                    else if (Object.ReferenceEquals(st,te))
                    {
                        acc.GetIncome(item.StaffId, technician);
                    }
                }
            }
           // acc.GetIncome(idIncome,);
          //  acc.GetIncome(nurse);
            //acc.GetIncome(technician);
            break;
    }
    Console.WriteLine("Enter \"y\" or \"Y\" to continue to main menu");
    cont = Console.ReadLine();
    Console.Clear();
} while (cont == "y" || cont == "Y");
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

