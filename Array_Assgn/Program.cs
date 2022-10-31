Console.WriteLine("Enter the number of Strings you want to enter:");
int num = Convert.ToInt32(Console.ReadLine());  
String[] strArray = new String[num];



Console.WriteLine("Enter Elements");
for (int i = 0; i < num; i++)
{
    strArray[i] = Console.ReadLine();
}


String cont = "y", mt = String.Empty;
do
{
    Console.WriteLine("Press 1 to find strings having character a");
    Console.WriteLine("Press 2 to find strings starting A M or K");
    Console.WriteLine("Press 3 to find frequency of strings");
    Console.WriteLine("Press 4 to sort or reverse strings according to their length");


    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            foreach (var item in strArray)
            {
                if (item.Contains('a')) 
                {
                    Console.WriteLine($"{item} contains \"a\"");
                }
            }

            break;

        case 2:
            String check = "AMK";
            foreach (var item in strArray)
            {
                if (check.Contains(item[0]))
                {
                    Console.WriteLine($"{item} starts with \"{item[0]}\"");
                }
            }
            break;

        case 3:
            Array.Sort(strArray);

            int i = 0; String strI, strJ;
            while (i < strArray.Length)
            {
                int count = 0;
                for (int j = i + 1; j < strArray.Length; j++)
                {
                    strI = strArray[i].ToLower();
                    strJ = strArray[j].ToLower();
                    if (strI == strJ)
                    {
                        count++;
                    }

                }

                Console.WriteLine($"{strArray[i]} appears {count + 1} times in an Array");
                i = i + count + 1;
            }


            break;

        case 4:
            Console.WriteLine("Enter 1 for sorting");
            Console.WriteLine("Enter 2 for reversing");
            int subChoice = Convert.ToInt32(Console.ReadLine());
 
            switch (subChoice)
            {
                case 1:
                    for (int j = 0; j < strArray.Length - 1; j++)
                    {
                        for (int k = j + 1; k < strArray.Length; k++)
                        {
                            if (strArray[j].Length > strArray[k].Length)
                            {
                                mt = strArray[j];
                                strArray[j] = strArray[k];
                                strArray[k] = mt;
                            }
                        }
                    }
                    foreach (var item in strArray)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 2:
                    for (int j = 0; j < strArray.Length - 1; j++)
                    {
                        for (int k = j + 1; k < strArray.Length; k++)
                        {
                            if (strArray[j].Length > strArray[k].Length)
                            {
                                mt = strArray[j];
                                strArray[j] = strArray[k];
                                strArray[k] = mt;
                            }
                        }
                    }
                    Array.Reverse(strArray);

                    foreach (var item in strArray)
                    {
                        Console.WriteLine(item);
                    }

                    break;
            }

            break;


    }
    Console.WriteLine("Press y or Y to continue");
    cont = Console.ReadLine();
} while (cont == "y" || cont == "Y");

