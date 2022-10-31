// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

List<int> list = new List<int>();

Console.WriteLine("Enetr number of elements you want to add in list:");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    list.Add(Convert.ToInt32(Console.ReadLine()));
}


String cont = "y";
int count = 0;
do
{
    Console.WriteLine("Press 1 for printing index of even numbers.");
    Console.WriteLine("Press 2 for printing index of odd numbers.");
    Console.WriteLine("Press 3 for printing index of prime numbers.");
    Console.WriteLine("Press 4 for finding repeated numbers");


    Console.WriteLine("Enter your choice:");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.WriteLine($"Index for {list[i]} which is even is {i}");
                }
            }
            break;

        case 2:
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Console.WriteLine($"Index for {list[i]} which is odd is {i}");
                }
            }
            break;

        case 3:
            for (int i = 0; i < list.Count; i++)
            {
                count = 0;
                for (int j = 1; j <= list[i]; j++)
                {
                    if (list[i] % j == 0)
                    {
                        count++;
                    }
                }

                if (count==2)
                {
                    Console.WriteLine($"Index of {list[i]} which is prime is {i}");
                }
            }
            break;

        case 4:
            list.Sort();
            int k = 0;
            while (k<list.Count-1)
            {
                int counter = 0;
                for (int j = k+1; j < list.Count; j++)
                {
                    if (list[k] == list[j])
                    {
                        counter++;
                    }
                }
                if (counter > 0)
                    Console.WriteLine($"{list[k]} is repeated {counter+1} times.");
                
                k = k + counter + 1;
            }


            break;
    }
    Console.WriteLine("Press \"y\" or \"Y\" to continue");
    cont = Console.ReadLine();

} while (cont == "y" || cont == "Y");