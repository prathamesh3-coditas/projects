// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

List<string> list = new List<string>();

Console.WriteLine("How many strings you want to add in list:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter element:");
for (int i = 0; i < num; i++)
{
    list.Add(Console.ReadLine());
}

String cont = "y";

do
{

    Console.WriteLine("Press 1 to find strings having character a");
    Console.WriteLine("Press 2 to find strings starting A M or K");
    Console.WriteLine("Press 3 to find count of reprated strings");
    Console.WriteLine("Press 4 to sort or reverse strings according to their length");

    Console.WriteLine("Enter your choice:");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            foreach (var item in list)
            {
                if (item.Contains('a'))
                {
                    Console.WriteLine(item);
                }
            }
            break;

        case 2:
            String checker = "AMK";
            foreach (var item in list)
            {
                if (checker.Contains(item[0]))
                {
                    Console.WriteLine($"{item} starts with \"A\",\"M\" or \"K\".");
                }
            }
            break;

        case 3:
            list.Sort();
            int p = 0,counter=0;
            while (p<list.Count-1)
            {
                counter = 0;
                for (int i = p+1; i < list.Count; i++)
                {
                    if (list[p] == list[i])
                    {
                        counter++;
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine($"{list[p]} is repeated {counter+1} times");
                }

                p = p + counter + 1;
            }
            break;

        case 4:
            Console.WriteLine("Enter 1 for sorting");
            Console.WriteLine("Enter 2 for reversing");
            int subchoice = Convert.ToInt32(Console.ReadLine());

            switch (subchoice)
            {
                case 1:
                    String temp = String.Empty;
                    for (int i = 0; i < list.Count-1; i++)
                    {
                        for (int j = i+1; j < list.Count; j++)
                        {
                            if (list[i].Length > list[j].Length)
                            {
                                temp = list[i];
                                list[i] = list[j];
                                list[j] = temp;
                            }
                        }
                    }

                    Console.WriteLine("Sorted according to string lenght");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 2:
                    String temp1 = String.Empty;
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        for (int j = i + 1; j < list.Count; j++)
                        {
                            if (list[i].Length > list[j].Length)
                            {
                                temp1 = list[i];
                                list[i] = list[j];
                                list[j] = temp1;
                            }
                        }
                    }
                    list.Reverse();

                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
            break;
    }

    Console.WriteLine("Press \"y\" or \"Y\" to continue.");
    cont = Console.ReadLine();
} while (true);
