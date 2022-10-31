using CS_Gen_App.Models;
using CS_Gen_App.Entities;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;

Staff staff = new Staff();

Doctor dr = new Doctor();
IDbOperations<Doctor,int> drdbOperations = new DoctorLogic();


Nurse nr = new Nurse();
IDbOperations<Nurse,int> nursedbOperations = new NurseLogic();

Driver drv = new Driver();
IDbOperations<Driver,int> driverdbOperations = new DriverLogic();

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


                        void jasonSerialize()
                        {
                            Stream fs = new FileStream($@"C:\.net Training\Solution\Employee data\{dr.StaffId}_{dr.StaffName}", FileMode.CreateNew);
                            JsonSerializer.Serialize(fs, dr);
                            fs.Close();
                            fs.Dispose();
                        }

                        jasonSerialize();
                        //  drdbOperations.Create(dr);
                        break;
                            
                    case 2:
                        Console.WriteLine("Enter id to get a record of Doctor:");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        String staffName = String.Empty;

                        string path = @$"C:\.net Training\Solution\Employee data\{dr.StaffId}_{dr.StaffName}";

                        if (File.Exists(path))
                        {

                            void jasonDeserialize(int id)
                            {
                                Stream fs = new FileStream($@"C:\.net Training\Solution\Employee data\{id}_{dr.StaffName}", FileMode.Open);
                                Doctor st = JsonSerializer.Deserialize<Doctor>(fs);
                                Console.WriteLine($"Staff name:{st.StaffName}\nStaff id:{st.StaffId}");

                                fs.Close();
                                fs.Dispose();
                            }
                            jasonDeserialize(id1);

                        }
                        else
                        {
                            Console.WriteLine("Record not found !!");
                        }




                        break;

                    case 3:
                        Console.WriteLine("Enter id of doctor to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        foreach (var v in Doctor.drList)
                        {
                            if(v.StaffId == id)
                            {
                                drdbOperations.Delete(id);
                                break;
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id to update:");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());
                        drdbOperations.Update(idToUpdate,dr);
                        break;

                    case 5:
                       drdbOperations.GetAll();
                        //var getAlphabetically = from record in Doctor.drList
                        //                        orderby record.StaffName select record;

                        //foreach (var item in getAlphabetically)
                        //{
                        //    Console.WriteLine($"Doctor id: {item.StaffId}");
                        //    Console.WriteLine($"Doctor name: {item.StaffName}");
                        //    Console.WriteLine($"Doctor education: {item.Education}");
                        //    Console.WriteLine($"Doctor specialization: {item.Specilization}");
                        //    Console.WriteLine("===============================================================");
                        //}
                        break;
                }
                Console.WriteLine("Press y to continue with doctor");
                contDr = Console.ReadLine();
                Console.Clear();
            } while (contDr=="y");

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
                        void jasonSerialize()
                        {
                            Stream fs = new FileStream($@"C:\.net Training\Solution\Employee data\{nr.StaffId}_Nurse", FileMode.CreateNew);
                            JsonSerializer.Serialize(fs, nr);
                            fs.Close();
                            fs.Dispose();
                        }

                        jasonSerialize();
                        //nursedbOperations.Create(nr);
                        break;

                    case 2:
                        Console.WriteLine("Enter id to get a record of Nurse:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        string path = @$"C:\.net Training\Solution\Employee data\{nr.StaffId}_{nr.StaffName}";

                        if (File.Exists(path))
                        {
                            void jasonDeserialize(int id)
                            {
                                Stream fs = new FileStream($@"C:\.net Training\Solution\Employee data\{id}_{nr.StaffName}", FileMode.Open);
                                Nurse st = JsonSerializer.Deserialize<Nurse>(fs);
                                Console.WriteLine($"Staff name:{st.StaffName}\nStaff id:{st.StaffId}");

                                fs.Close();
                                fs.Dispose();
                            }
                            jasonDeserialize(id1);

                        }
                        else
                        {
                            Console.WriteLine("Record not found !!");
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
                        break;

                    case 4:
                        Console.WriteLine("Enter id to update:");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());
                        nursedbOperations.Update(idToUpdate, nr);
                        break;

                    case 5:
                        nursedbOperations.GetAll();
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
                        void jasonSerialize()
                        {
                            Stream fs = new FileStream($@"C:\.net Training\Solution\Employee data\{drv.StaffId}_{drv.StaffName}", FileMode.CreateNew);
                            JsonSerializer.Serialize(fs, drv);
                            fs.Close();
                            fs.Dispose();
                        }

                        jasonSerialize();
                        //driverdbOperations.Create(drv);
                        break;

                    case 2:
                        Console.WriteLine("Enter id to get a record of Driver:");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        string path = $@"C:\.net Training\Solution\Employee data\{drv.StaffId}_{drv.StaffName}";

                        if (File.Exists(path))
                        {
                            void jasonDeserialize(int id)
                            {
                                Stream fs = new FileStream($@"C:\.net Training\Solution\Employee data\{id}_{drv.StaffName}", FileMode.Open);
                                Driver st = JsonSerializer.Deserialize<Driver>(fs);
                                Console.WriteLine($"Staff name:{st.StaffName}\nStaff id:{st.StaffId}");

                                fs.Close();
                                fs.Dispose();
                            }
                            jasonDeserialize(id1);

                        }
                        else
                        {
                            Console.WriteLine("Record not found !!");
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
                        break;

                    case 4:
                        Console.WriteLine("Enter id to update:");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());
                        driverdbOperations.Update(idToUpdate, drv);
                        break;

                    case 5:
                        driverdbOperations.GetAll();
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
            } while (wish == "y");
            break;

    }
    Console.WriteLine("Press y to continue to main menu");
    cont = Console.ReadLine();

} while (cont == "y");