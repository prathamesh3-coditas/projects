using Assign_0408.Logic;
using Assign_0408.Entity;
using System.Security.Cryptography;

Operations op = new Operations();

///////////////////////////////////////////////////////////////////////////////////////////////////////////////


//op.GetDetailsByCatagory("Nurse");


//op.getDetailsById(1032);

//op.getDetailsByCount(6);

//op.DeleteStaff(1001);

//op.UpdateByStaffId(1029);
string wish = "y";

do
{

    Console.WriteLine("Press 1 to register all existing records or reset records in file");
    Console.WriteLine("Press 2 to get record based on staff catagory");
    Console.WriteLine("Press 3 to get record based on staff id");
    Console.WriteLine("Press 4 to get record based on count");
    Console.WriteLine("Press 5 to delete a record based on staff id");
    Console.WriteLine("Press 6 to update a record based on staff id");
    Console.WriteLine("Enter your choice");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            op.RegisterStaff();
            break;

        case 2:
            Console.WriteLine("Enter a catagory to get records");
            string Cat = Console.ReadLine();
            op.GetDetailsByCatagory(Cat);
            break;

        case 3:
            Console.WriteLine("Enter an id to get record");
            int IdToGetRecord = Convert.ToInt32(Console.ReadLine());
            op.getDetailsById(IdToGetRecord);
            break;

        case 4:
            Console.WriteLine("Enter a count to get records");
            int CountToGetRecord = Convert.ToInt32(Console.ReadLine());
            op.getDetailsByCount(CountToGetRecord);
            break;

        case 5:
            Console.WriteLine("Enter an id to delete a record");
            int IdToDeleteRecord = Convert.ToInt32(Console.ReadLine());
            op.DeleteStaff(IdToDeleteRecord);
            break;

        case 6:
            Console.WriteLine("Enter an id to update a record");
            int IdToUpdateRecord = Convert.ToInt32(Console.ReadLine());
            op.UpdateByStaffId(IdToUpdateRecord);
            break;
    }
    Console.WriteLine("Enter \"y\" or \"Y\" to continue operations");
    wish = Console.ReadLine();
    Console.Clear();

} while (wish == "y" || wish == "Y");