// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("How many numbers you want to put in array:");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num];


Console.WriteLine("Enter numbers:");
for (int i = 0; i < num; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

//int[] arr = new int[6] {17,43,65,71,32,54};

String continueExecution = "y";
do
{
    Console.WriteLine("===============================================================");
    Console.WriteLine("Press 1 for printing indexes of even numbers:");
    Console.WriteLine("Press 2 for printing indexes of odd numbers:");
    Console.WriteLine("Press 3 for printing indexes of prime numbers:");
    Console.WriteLine("Press 4 for finding repeated numbers:");


    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("===============================================================");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine($"Index for {arr[i]} which is even number is {i}");
                }
            }
            break;

        case 2:
            Console.WriteLine("===============================================================");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine($"Index for {arr[i]} which is odd is {i}");
                }
            }
            break;

        case 3:
            Console.WriteLine("===============================================================");
            int count;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.WriteLine($"Index for {arr[i]} which is a prime number is {i}");
                }
            }

            break;

        case 4:
            Array.Sort(arr);

            int k = 0;
            while (k<arr.Length-1)
            {
                count = 0;
                for (int j = k + 1; j < arr.Length; j++)
                {
                    if (arr[k] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > 0)
                    Console.WriteLine($"{arr[k]} repeats {count+1} times");

                k = k + count + 1;
            }

            
            break;
    }

    Console.WriteLine("Press y or Y to continue");
    Console.WriteLine("===============================================================");
    continueExecution = Console.ReadLine();
} while (continueExecution == "y" || continueExecution == "Y");
