using CS_Basic_Class;

//Console.WriteLine("Simple Class");

Staff staff = new Staff();


StaffLogic logic = new StaffLogic();
var staffs = logic.GetAllStaff();


String cont = "y";
do
{
    Console.WriteLine("Press 1 to insert records");
    Console.WriteLine("Press 2 to view list of all staff");
    Console.WriteLine("Press 3 to update existing record");
    Console.WriteLine("Press 4 to delete a record");
    Console.WriteLine("Press 5 to get the record using ID");

    Console.WriteLine("Enter choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter detils");
            staff = new Staff()
            {
                StaffId = Convert.ToInt32(Console.ReadLine()),
                StaffName = Console.ReadLine(),
                Email = Console.ReadLine(),
                DeptName = Console.ReadLine(),
                Gender = Console.ReadLine(),
                DateOfBirth = DateTime.Parse(Console.ReadLine()),
                StaffCategory = Console.ReadLine(),
                Education = Console.ReadLine(),
                ContatNo = Convert.ToInt32(Console.ReadLine())
            };

            logic.RegisterNewStaff(staff);
            break;

          case 2:
            foreach (var item in staffs)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"ID:{item.StaffId} \n" +
                    $"Name:{item.StaffName} \n" +
                    $"E-mail:{item.Email} \n" +
                    $"Dept-Name:{item.DeptName} \n" +
                    $"Gender:{item.Gender} \n" +
                    $"DOB:{item.DateOfBirth} \n" +
                    $"Catagory:{item.StaffCategory} \n" +
                    $"Education:{item.Education} \n" +
                    $"Contact number:{item.ContatNo}");
            }
            break;


        case 3:
            Console.WriteLine("====================================================");
            Console.WriteLine("Enter id to update a record");
            int id = Convert.ToInt32(Console.ReadLine());

                staffs = logic.UpdateStaffInfo(id, staff);
     
            break;

        case 4:
            Console.WriteLine("====================================================");
            Console.WriteLine("Enter id to delete a record.");
            int idDelete = Convert.ToInt32(Console.ReadLine());

            staffs = logic.DeleteStaff(idDelete);

            break;

        case 5:
            Console.WriteLine("====================================================");
            Console.WriteLine("Enter the ID to get record:");
            int idToGet = Convert.ToInt32(Console.ReadLine());

            staff = logic.GetStaffById(idToGet);


            
           Console.WriteLine($"ID:{staff.StaffId} \n" +
                             $"Name:{staff.StaffName} \n" +
                             $"E-mail:{staff.Email} \n" +
                             $"Dept-Name:{staff.DeptName} \n" +
                             $"Gender:{staff.Gender} \n" +
                             $"DOB:{staff.DateOfBirth} \n" +
                             $"Catagory:{staff.StaffCategory} \n" +
                             $"Education:{staff.Education} \n" +
                             $"Contact number:{staff.ContatNo}"); 
            break;
    }

    Console.WriteLine("Press y or Y to go back to main menu");
    cont = Console.ReadLine(); 
} while (cont=="Y" || cont =="y");


Console.ReadLine();


/*
12
pratham
p@gmail.com
eye
male
2001 03 03
doctor
be
705748




13
dhirva
d@gmail.cpm
organs
female
2000 12 01
nurse
be
937354
 */