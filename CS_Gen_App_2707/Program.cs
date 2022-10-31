using CS_Gen_App.Models;
using CS_Gen_App.Entities;
using System.Text.Json;



EventListener eventListener;

        Staff staff = new Staff();

        Doctor dr = new Doctor();
        IDbOperations<Doctor, int> drdbOperations = new DoctorLogic();
        DoctorLogic dl = new DoctorLogic();


        Nurse nr = new Nurse();
        IDbOperations<Nurse, int> nursedbOperations = new NurseLogic();
        NurseLogic nl = new NurseLogic();

        Driver drv = new Driver();
        IDbOperations<Driver, int> driverdbOperations = new DriverLogic();
        DriverLogic drl = new DriverLogic();

        //Declaring operational handeller
        //And passing method to it for we want declare an event
        //OperationHandeller createHandeller = new OperationHandeller(DoctorLogic.msgNotification);


        String cont = "y";
        do
        {
            Console.WriteLine("Press 1 for doctor");
            Console.WriteLine("Press 2 for nurse");
            Console.WriteLine("Press 3 for driver");
            Console.WriteLine("Press 4 for searching a staff");
            Console.WriteLine("===============================================================");


            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    String contDr = "y";
                        do
                        {
                            Console.WriteLine("Press 1 for registration:");
                            Console.WriteLine("Press 2 for getting a record of doctor:");
                            Console.WriteLine("Press 3 for deleting a record of doctor:");
                            Console.WriteLine("Press 4 for updating a record:");
                            Console.WriteLine("Press 5 for getting all records:");
                            Console.WriteLine("Press 6 to create salary slip:");
                            Console.WriteLine("===============================================================");

                            int subChoice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("===============================================================");

                            switch (subChoice)
                            {
                                case 1:
                                    dr = new Doctor();
                                    Console.WriteLine("Enter Doctor attributes");
                                    //Console.WriteLine("Doctor Id:");
                                    dr.StaffId = ++Staff.id;//Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Doctor name:");
                                    dr.StaffName = Console.ReadLine(); ;
                                    Console.WriteLine("Doctor education:");
                                    dr.Education = Console.ReadLine();
                                    Console.WriteLine("Doctor specialization:");
                                    dr.Specilization = Console.ReadLine();
                                    Console.WriteLine("Enter Basic pay:");
                                    dr.Basicpay = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter max patients handelled by doctor:");
                                    dr.MaxPatients = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter fees taken by doctor:");
                                    dr.fees = Convert.ToInt32(Console.ReadLine());
                        
                        drdbOperations.Create(dr);
                        //void addJson()
                        //{
                        //    Stream fs = new FileStream($@"C:\.net Training\Solution\Assignment 0308\{dr.StaffId}_{dr.StaffName}.txt",FileMode.CreateNew);
                        //    JsonSerializer.Serialize(fs,dr);

                        //    fs.Close();
                        //    fs.Dispose();
                        //}
                        //addJson();
                                    eventListener = new EventListener();
                                    eventListener.Added("Staff added successfully !!");

                                    break;

                                case 2:
                                    Console.WriteLine("Enter id to get a record of doctor:");
                                    int id1 = Convert.ToInt32(Console.ReadLine());

                                    foreach (var item in Doctor.drList)
                                    {
                                        if (item.StaffId == id1)
                                        {
                                            Console.WriteLine($"Doctor id: {drdbOperations.Get(id1).StaffId}");
                                            Console.WriteLine($"Doctor name: {drdbOperations.Get(id1).StaffName}");
                                            Console.WriteLine($"Doctor education: {drdbOperations.Get(id1).Education}");
                                            Console.WriteLine($"Doctor specialization: {drdbOperations.Get(id1).Specilization}");
                                            Console.WriteLine("===============================================================");


                                        }

                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Enter id of doctor to delete:");
                                    int id = Convert.ToInt32(Console.ReadLine());

                                    foreach (var v in Doctor.drList)
                                    {
                                        if (v.StaffId == id)
                                        {
                                            drdbOperations.Delete(id);
                                            break;
                                        }
                                    }
                                    eventListener = new EventListener();
                                    eventListener.Removed("Staff deleted successfully !!");
                                    break;

                                case 4:
                                    Console.WriteLine("Enter id to update:");
                                    int idToUpdate = Convert.ToInt32(Console.ReadLine());
                                    drdbOperations.Update(idToUpdate, dr);

                                    break;

                                  case 5:
                        // drdbOperations.GetAll();
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
                                break;

                    case 6:
                        Console.WriteLine("Enter an id to generate salary slip:");
                        int idToGetSalary = Convert.ToInt32(Console.ReadLine());

                        dl.getSalary(idToGetSalary);

                        break;
                            }
                            Console.WriteLine("Press y to continue with doctor");
                            contDr = Console.ReadLine();
                            Console.Clear();
                        } while (contDr == "y");

                    break;
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                case 2:
                    String contNurse = "y";
        do
        {
            Console.WriteLine("Press 1 for registration:");
            Console.WriteLine("Press 2 for getting a record of nurse:");
            Console.WriteLine("Press 3 for deleting a record of nurse:");
            Console.WriteLine("Press 4 for updating a record:");
            Console.WriteLine("Press 5 for getting all records:");
            Console.WriteLine("Press 6 to create salary slip:");

                int subChoice = Convert.ToInt32(Console.ReadLine());

            switch (subChoice)
            {
                case 1:
                    nr = new Nurse();
                    Console.WriteLine("Enter Nurse attributes");
                    //Console.WriteLine("Nurse Id:");
                    nr.StaffId = ++Staff.id;//Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nurse name:");
                    nr.StaffName = Console.ReadLine(); ;
                    Console.WriteLine("Nurse experience:");
                    nr.Experience = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Doctor specialization:");
                        //dr.Specilization = Console.ReadLine();
                    Console.WriteLine("Enter extra hours:");
                    nr.ExtraHours = Convert.ToInt32(Console.ReadLine()); ;
                        
                    nursedbOperations.Create(nr);
                    eventListener = new EventListener();
                    eventListener.Added("Nurse added successfully !!");
                    break;

                case 2:
                    Console.WriteLine("Enter id to get a record of Nurse:");
                    int id1 = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in Nurse.nurseList)
                    {
                        if (item.StaffId == id1)
                        {
                            Console.WriteLine($"Nurse id: {nursedbOperations.Get(id1).StaffId}");
                            Console.WriteLine($"Nurse name: {nursedbOperations.Get(id1).StaffName}");
                            //Console.WriteLine($"Doctor education: {nursedbOperations.Get(id1).Education}");
                            Console.WriteLine($"Nurse experience: {nursedbOperations.Get(id1).Experience}");
                            Console.WriteLine("===============================================================");
                        }

                    }
                    break;

                case 3:
                    Console.WriteLine("Enter id of nurse to delete:");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (var v in Nurse.nurseList)
                    {
                        if (v.StaffId == id)
                        {
                            nursedbOperations.Delete(id);
                            break;
                        }
                    }
                    eventListener = new EventListener();
                   eventListener.Removed("Nurse record removed successfully !!");
                    break;

                case 4:
                    Console.WriteLine("Enter id to update:");
                    int idToUpdate = Convert.ToInt32(Console.ReadLine());
                    nursedbOperations.Update(idToUpdate, nr);
                    break;

                case 5:
                    nursedbOperations.GetAll();
                    break;

                case 6:
                    Console.WriteLine("Enter an id to generate salary slip:");
                    int idToGetSalary = Convert.ToInt32(Console.ReadLine());

                    nl.getSalary(idToGetSalary);

                    break;
                }
            Console.WriteLine("Press y to continue with Nurse");
            contNurse = Console.ReadLine();
            Console.Clear();
        } while (contNurse == "y");
        break;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        case 3:
            
            String contDriver = "y";
        do
        {
            Console.WriteLine("Press 1 for registration:");
            Console.WriteLine("Press 2 for getting a record of driver:");
            Console.WriteLine("Press 3 for deleting a record of driver:");
            Console.WriteLine("Press 4 for updating a record:");
            Console.WriteLine("Press 5 for getting all records:");
            Console.WriteLine("Press 6 to create salary slip:");

                int subChoice = Convert.ToInt32(Console.ReadLine());

            switch (subChoice)
            {
                case 1:
                    drv = new Driver();
                    Console.WriteLine("Enter Driver attributes");
                    //Console.WriteLine("Nurse Id:");
                    drv.StaffId = ++Staff.id;//Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Driver name:");
                    drv.StaffName = Console.ReadLine(); ;
                    Console.WriteLine("Driver vehicle type:");
                    drv.VehicleType = Console.ReadLine();
                        //Console.WriteLine("Doctor specialization:");
                        //dr.Specilization = Console.ReadLine();
                    Console.WriteLine("Enter bonus:");
                    drv.Bonus = Convert.ToInt32(Console.ReadLine());
                    
                        driverdbOperations.Create(drv);
                        eventListener = new EventListener();
                        eventListener.Added("Driver added successfully !!");
                    break;

                case 2:
                    Console.WriteLine("Enter id to get a record of Nurse:");
                    int id1 = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in Driver.driverList)
                    {
                        if (item.StaffId == id1)
                        {
                            Console.WriteLine($"Driver id: {driverdbOperations.Get(id1).StaffId}");
                            Console.WriteLine($"Driver name: {driverdbOperations.Get(id1).StaffName}");
                            //Console.WriteLine($"Doctor education: {nursedbOperations.Get(id1).Education}");
                            Console.WriteLine($"Driver vehicle: {driverdbOperations.Get(id1).VehicleType}");
                            Console.WriteLine("===============================================================");
                        }

                    }
                    break;

                case 3:
                    Console.WriteLine("Enter id of nurse to delete:");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (var v in Driver.driverList)
                    {
                        if (v.StaffId == id)
                        {
                            driverdbOperations.Delete(id);
                            break;
                        }
                    }
                    eventListener = new EventListener();
                        eventListener.Removed("Driver removed successfully !!");
                    break;

                case 4:
                    Console.WriteLine("Enter id to update:");
                    int idToUpdate = Convert.ToInt32(Console.ReadLine());
                    driverdbOperations.Update(idToUpdate, drv);
                    break;

                case 5:
                   // driverdbOperations.GetAll();
                        var getAlphabetically = from record in Driver.driverList
                                                orderby record.StaffName
                                                select record;

                        foreach (var item in getAlphabetically)
                        {
                            Console.WriteLine($"Driver id: {item.StaffId}");
                            Console.WriteLine($"Driver name: {item.StaffName}");
                            Console.WriteLine($"Vehicle type: {item.VehicleType}");
                        }
                    break;

                case 6:
                    Console.WriteLine("Enter an id to generate salary slip:");
                    int idToGetSalary = Convert.ToInt32(Console.ReadLine());

                    drl.getSalary(idToGetSalary);

                    break;
                }
            Console.WriteLine("Press y to continue with Driver");
            contDriver = Console.ReadLine();
            Console.Clear();
        } while (contDriver == "y");
        break;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        case 4:
            string wish = "y";
        do
        {
            Console.WriteLine("Press 1 for searching based on name");
            Console.WriteLine("Press 2 for searching based on ID");
            Console.WriteLine("===============================================================");

            int sub_choice = Convert.ToInt32(Console.ReadLine());

            switch (sub_choice)
            {
                case 1:
                    Console.WriteLine("Enter a name to search:");
                    string name = Console.ReadLine();

                    Staff.searchedName(name);
                    break;

                case 2:
                    Console.WriteLine("Enter an ID to search");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Staff.searchedId(id);
                    break;
            }

            Console.WriteLine("Do you want to continue search\nPress \"y\" to continue");
            wish = Console.ReadLine();
            Console.Clear();
        } while (wish == "y");
        break;

        }
            Console.WriteLine("Press y to continue to main menu");
        cont = Console.ReadLine();

        } while (cont == "y") ;



