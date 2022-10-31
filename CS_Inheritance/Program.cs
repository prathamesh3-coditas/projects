using CS_Inheritence.Models;
using CS_Inheritence.Logic;
using CS_Inheritance.Logic;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("DEMO Inheritence");


DoctorLogic logic = new DoctorLogic();
var doctor = new Doctor();
var Doctor = logic.Get();

var nurse = new Nurse();
NurseLogic nurseLogic = new NurseLogic();
var Nurse = nurseLogic.Getnurse();

var technician = new Technician(); 
TechnicianLogic technicianLogic = new TechnicianLogic();
var Technician = technicianLogic.GetTechnician();


String cont = "y";
do
{
    Console.WriteLine("whose details you want to enter");
    Console.WriteLine("press 1 for doctor");
    Console.WriteLine("press 2 for nurse");
    Console.WriteLine("press 3 for technician");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            String cont1 = "y";

            do
            {
                Console.WriteLine("Enter choice for CRUD operations");
                Console.WriteLine("press 1 for Registration");
                Console.WriteLine("press 2 for updation");
                Console.WriteLine("press 3 for deletion");
                int subchoice = Convert.ToInt32(Console.ReadLine());

                switch (subchoice)
                {
                    case 1:

                        doctor = new Doctor();

                        Console.WriteLine("Enter ID:");
                        doctor.StaffId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Staff Name:");
                        doctor.StaffName = Console.ReadLine();

                        Console.WriteLine("Enter Doctor Id:");
                        doctor.DoctorId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter email:");
                        doctor.Email = Console.ReadLine();

                        Console.WriteLine("Enter Contact Number:");
                        doctor.ContactNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Education:");
                        doctor.Education = Console.ReadLine();

                        Console.WriteLine("Enter Shift start time:");
                        doctor.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Shift end time:");
                        doctor.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Basic Pay:");
                        doctor.SetBasicPay(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Enter specialization:");
                        doctor.Specialization = Console.ReadLine();

                        Console.WriteLine("Enter fees:");
                        doctor.Fees = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Max patients handelled by doctor:");
                        doctor.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());

                        logic.Register(doctor);

                        foreach (var d in Doctor.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"Doctor Name:{d.StaffName}");
                            Console.WriteLine($"Doctor ID :{d.DoctorId}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Doctor Specialization:{d.Specialization}");
                            Console.WriteLine($"Doctor fees: {d.Fees}");
                            Console.WriteLine($"Maximum number of patients :{d.MaxPatientsPerDay}");
                            Console.WriteLine("=====================================================================");

                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter doctor ID for update");
                        int enteredId = Convert.ToInt32(Console.ReadLine());

                        foreach (var DrId in Doctor.Values)
                        {
                            if (enteredId == DrId.DoctorId)
                            {
                                logic.UpdateDoctorInfo(enteredId, DrId);
                                break;
                            }
                                                   //else
                            //{

                            //    while (enteredId != DrId.DoctorId)
                            //    {
                            //        Console.WriteLine("Enter valid id:");
                            //        enteredId = Convert.ToInt32(Console.ReadLine());
                            //    }

                            //    logic.UpdateDoctorInfo(enteredId, Doctor);

                            //}
                        }


                            foreach (var d in Doctor.Values)
                            {
                                Console.WriteLine($"Doctor ID : {d.StaffId}");
                                Console.WriteLine($"Doctor Name:{d.StaffName}");
                                Console.WriteLine($"Doctor ID :{d.DoctorId}");
                                Console.WriteLine($"Email :{d.Email}");
                                Console.WriteLine($"Education: {d.Education}");
                                Console.WriteLine($"Start time: {d.ShiftStartTime}");
                                Console.WriteLine($"End time:{d.ShiftEndTime}");
                                Console.WriteLine($"Doctor Specialization:{d.Specialization}");
                                Console.WriteLine($"Doctor fees: {d.Fees}");
                                Console.WriteLine($"Maximum number of patients :{d.MaxPatientsPerDay}");
                            Console.WriteLine("=====================================================================");


                        }

                        break;

                    case 3:

                        Console.WriteLine("Enter doctor id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());

                        logic.DeleteDoctor(id);
                        foreach (var d in Doctor.Values)
                        {
                            Console.WriteLine($"Doctor ID : {d.StaffId}");
                            Console.WriteLine($"Doctor Name:{d.StaffName}");
                            Console.WriteLine($"Doctor ID :{d.DoctorId}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Doctor Specialization:{d.Specialization}");
                            Console.WriteLine($"Doctor fees: {d.Fees}");
                            Console.WriteLine($"Maximum number of patients :{d.MaxPatientsPerDay}");
                            Console.WriteLine("=====================================================================");


                        }
                        break;
                }

                Console.WriteLine("Press Y or y to continue");
                cont1 = Console.ReadLine();
            } while (cont1=="y" || cont1=="Y");

            break;


        case 2:
            String cont2 = "y";

            do
            {
                Console.WriteLine("Enter choice for CRUD operations");
                Console.WriteLine("press 1 for Registration");
                Console.WriteLine("press 2 for updation");
                Console.WriteLine("press 3 for deletion");

                int subchoice = Convert.ToInt32(Console.ReadLine());

                switch (subchoice)
                {
                    case 1:
                        nurse = new Nurse();

                        Console.WriteLine("Enter ID:");
                        nurse.StaffId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Staff Name:");
                        nurse.StaffName = Console.ReadLine();

                        Console.WriteLine("Enter Nurse Id");
                        nurse.NurseId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Extra hours:");
                        nurse.ExtraHours = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter email:");
                        nurse.Email = Console.ReadLine();

                        Console.WriteLine("Enter Contact Number:");
                        nurse.ContactNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Education:");
                        nurse.Education = Console.ReadLine();

                        Console.WriteLine("Enter specialization:");
                        nurse.Specialization = Console.ReadLine();

                        Console.WriteLine("Enter Shift start time:");
                        nurse.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Shift end time:");
                        nurse.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Basic Pay:");
                        nurse.SetBasicPay(Convert.ToInt32(Console.ReadLine()));

                        nurseLogic.Register(nurse);

                        foreach (var d in Nurse.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"Doctor Name:{d.StaffName}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Nurse Specialization:{d.Specialization}");
                            Console.WriteLine("=====================================================================");

                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Nurse id to update:");
                        int enteredId = Convert.ToInt32(Console.ReadLine());

                        foreach (var nurseId in Nurse.Values)
                        {
                            if (enteredId == nurseId.NurseId)
                            {
                                nurseLogic.UpdateNurseInfo(enteredId,nurseId);
                                break;
                            }
                        }

                        foreach (var d in Nurse.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"Nurse Name:{d.StaffName}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Nurse Specialization:{d.Specialization}");
                            Console.WriteLine("=====================================================================");

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Nurse id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());

                        nurseLogic.DeleteNurse(id);

                        foreach (var d in Nurse.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"Nurse Name:{d.StaffName}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Nurse Specialization:{d.Specialization}");
                            Console.WriteLine("=====================================================================");

                        }
                        break;
                }
                Console.WriteLine("Press Y or y to continue");
                cont2 = Console.ReadLine();

            } while (cont2 == "y" || cont2 == "Y");
            break;


        case 3:
            String cont3 = "y";

            do
            {
                Console.WriteLine("Enter choice for CRUD operations");
                Console.WriteLine("press 1 for Registration");
                Console.WriteLine("press 2 for updation");
                Console.WriteLine("press 3 for deletion");

                int subchoice = Convert.ToInt32(Console.ReadLine());

                switch (subchoice)
                {
                    case 1:
                        technician = new Technician();

                        Console.WriteLine("Enter ID:");
                        technician.StaffId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Staff Name:");
                        technician.StaffName = Console.ReadLine();

                        Console.WriteLine("Enter Technician Id");
                        technician.TechId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter email:");
                        technician.Email = Console.ReadLine();

                        Console.WriteLine("Enter Contact Number:");
                        technician.ContactNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Education:");
                        technician.Education = Console.ReadLine();

                        Console.WriteLine("Enter specialization:");
                        technician.Specialization = Console.ReadLine();

                        Console.WriteLine("Enter Shift start time:");
                        technician.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Shift end time:");
                        technician.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Basic Pay:");
                        technician.SetBasicPay(Convert.ToInt32(Console.ReadLine()));

                        technicianLogic.RegisterTechnician(technician);

                        foreach (var d in Technician.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"technician Name:{d.StaffName}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Technician Specialization:{d.Specialization}");
                            Console.WriteLine("=====================================================================");

                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Nurse id to update:");
                        int enteredId = Convert.ToInt32(Console.ReadLine());

                        foreach (var techId in Technician.Values)
                        {
                            if (enteredId == techId.TechId)
                            {
                                technicianLogic.UpdateTechnicianInfo(enteredId,techId);
                                   // UpdateNurseInfo(enteredId, techId);
                                break;
                            }
                        }

                        foreach (var d in Technician.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"technician Name:{d.StaffName}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"Technician Specialization:{d.Specialization}");
                            Console.WriteLine("=====================================================================");

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter technician id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());

                        technicianLogic.DeleteTechnician(id);

                        foreach (var d in Technician.Values)
                        {
                            Console.WriteLine($"Staff ID : {d.StaffId}");
                            Console.WriteLine($"Technician Name:{d.StaffName}");
                            Console.WriteLine($"Email :{d.Email}");
                            Console.WriteLine($"Education: {d.Education}");
                            Console.WriteLine($"Start time: {d.ShiftStartTime}");
                            Console.WriteLine($"End time:{d.ShiftEndTime}");
                            Console.WriteLine($"technician Specialization:{d.Specialization}");
                            Console.WriteLine("=====================================================================");

                        }
                        break;
                }
                Console.WriteLine("Press Y or y to continue");
                cont3 = Console.ReadLine();

            } while (cont3 == "y" || cont3 == "Y");
            break;

    }
    Console.WriteLine("Enter \"y\" or \"Y\" to continue");
} while (cont == "y" || cont == "Y");



//var staff = new Staff()
//{
//    StaffId = Convert.ToInt32(Console.ReadLine()),
//    StaffName = Console.ReadLine(),
//    Email = Console.ReadLine(),
//    ContactNo = Convert.ToInt32(Console.ReadLine()),
//    Education = Console.ReadLine(),
//    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
//    ShiftEndTime = Convert.ToInt32(Console.ReadLine())
    
//};


//var doctor = new Doctor();

//Console.WriteLine("Enter ID:");
//doctor.StaffId = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Staff Name:");
//doctor.StaffName = Console.ReadLine();

//Console.WriteLine("Enter Doctor Id:");
//doctor.DoctorId = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter email:");
//doctor.Email = Console.ReadLine();

//Console.WriteLine("Enter Contact Number:");
//doctor.ContactNo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Education:");
//doctor.Education = Console.ReadLine();

//Console.WriteLine("Enter Shift start time:");
//doctor.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Shift end time:");
//doctor.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Basic Pay:");
//doctor.SetBasicPay(Convert.ToInt32(Console.ReadLine()));

//Console.WriteLine("Enter specialization:");
//doctor.Specialization = Console.ReadLine();

//Console.WriteLine("Enter fees:");
//doctor.Fees = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Max patients handelled by doctor:");
//doctor.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());

//logic.Register(doctor);


//foreach (var d in Doctor)
//{
//    Console.WriteLine($"Staff ID : {d.StaffId}");
//    Console.WriteLine($"Staff Name:{d.StaffName}");
//    Console.WriteLine($"Staff Doctor ID :{d.DoctorId}");
//    Console.WriteLine($"Staff Email :{d.Email}");
//    Console.WriteLine($"Staff Education: {d.Education}");
//    Console.WriteLine($"Staff Start time: {d.ShiftStartTime}");
//    Console.WriteLine($"Staff End time:{d.ShiftEndTime}");
//    Console.WriteLine($"Doctor Specialization:{d.Specialization}");
//    Console.WriteLine($"Doctor fees: {d.Fees}");
//    Console.WriteLine($"Maximum number of patients :{d.MaxPatientsPerDay}");

//}