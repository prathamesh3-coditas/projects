using Assign_2909_Banking_App_Dict;

Banking b = new Banking();

Banking_operation op = new Banking_operation();

string wish = "y";
do
{
    Console.WriteLine("Enter Account name");
    string name = Console.ReadLine();

    int flag = 0;
    decimal amount = 0;

    if (Banking.list.Count == 0)
    {
        Console.WriteLine("Enter initial amount");
        amount = Convert.ToDecimal(Console.ReadLine());
    }
    else
    {
        foreach (var item in Banking.list.Values)
        {
            if (item.accName.Equals(name))
            {
                Console.WriteLine($"Welcome {item.accName}");
                //Console.WriteLine($@"Your current balance is: {item.netBalance}");
                flag = 1;
                b.createAcc(item, item.netBalance, item.accName);

                op.RandomTransaction();
                break;
            }

        }

        if (flag == 0)
        {
            Console.WriteLine("Enter initial amount");
            amount = Convert.ToDecimal(Console.ReadLine());
        }

    }


    if (flag == 0)
    {
        b.createAcc(new Account(), amount, name);

        op.RandomTransaction();
    }
    Console.WriteLine("Do you want to add another account?");
    wish = Console.ReadLine();
    Console.Clear();

} while (wish == "y" || wish == "Y");



//foreach (var item in b.list)
//{
//    JsonSerializer.Serialize(item);
//}90