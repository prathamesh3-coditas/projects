using System.Collections.Generic;
public class ProdFib
{
    public static ulong[] productFib(ulong number)
    {
        ulong[] finalArr = new ulong[3];


        List<ulong> list = new List<ulong>();
        ulong c = 0; ulong a = 0, b = 1;
        list.Add(a);
        list.Add(b);

        while (c <= number)
        {
            c = a + b;
            a = b;
            b = c;
            list.Add(c);
        }

        ulong product = 0;
        for (int i = 0; i < list.Count - 1; i++)    //traversing fibonacci series in list
        {
            product = list[i] * list[i + 1];

            if (product == number)
            {
                finalArr[0] = list[i];
                finalArr[1] = list[i + 1];
                finalArr[2] = 1;
                break;
            }

            if (product > number)
            {
                finalArr[0] = list[i];
                finalArr[1] = list[i + 1];
                finalArr[2] = 0;
                break;
            }
        }
        return finalArr;
    }



    static void Main(string[] args)
    {
        ulong[] answer = productFib(800);

        foreach (var item in answer)
        {
            Console.WriteLine(item);
        }
    }
}



/*
 
 * ==============================================================================
 * F(8) means fibonacci series of 8 numbers 
 * 1 denotes true and 0 denotes false
 * ==============================================================================
productFib(714) # should return (21, 34, true), 
                # since F(8) = 21, F(9) = 34 and 714 = 21 * 34 
Here 714 is passed.Now 21 and 34 are consecutive numbers in fibonacci series.And product of 21*34 is 714
so return 21 34 1
------

productFib(800) # should return (34, 55, false), 
                # since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55
Here 800 is passed.Now 21 and 34 are consecutive numbers in fibonacci series.And product of 21*34 is 714
next number of 34 in series is 55 and product of 34*55 is 1870 which is greater than 800
so return 34 55 0

-----
productFib(714) # should return [21, 34, true], 
productFib(800) # should return [34, 55, false], 
-----
productFib(714) # should return {21, 34, 1}, 
productFib(800) # should return {34, 55, 0},        
-----
productFib(714) # should return {21, 34, true}, 
productFib(800) # should return {34, 55, false},  
 */