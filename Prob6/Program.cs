// See https://aka.ms/new-console-template for more information
using Prob6.Models;

String[] nums = { "one","two","three","four","five","six","seven","eight","nine"};
String[] arrTens = {"ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninty" };


Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());


int reverse(int num)
{
    int rev = 0, rem = 0 ;
    while (num>0)
    {
        rem = num % 10;
        num = num / 10;
        rev = rev * 10 + rem;
    }

    
    return rev;
}

int reversed = reverse(num);
int temp = num;
while (reversed > 10)
{
    int ans = reversed / 10;
    int mod = (reversed) % 10;
    Console.Write(arrTens[mod - 1]);

    Console.Write(nums[ans-1]);
    reversed = reversed / 10;
}

//int temp = num, rem = 0; String word = "";

//void someMethod(int num)
//{
//    int reversed = reverse(num);

//    while (reversed > 0)
//    {
//        rem = reversed % 10;
//        reversed = reversed / 10;

//        switch (rem)
//        {

//            case 1:
//                word = "One";
//                break;
//            case 2:
//                word = "Two";
//                break;
//            case 3:
//                word = "Three";
//                break;
//            case 4:
//                word = "Four";
//                break;
//            case 5:
//                word = "Five";
//                break;
//            case 6:
//                word = "Six";
//                break;
//            case 7:
//                word = "Seven";
//                break;
//            case 8:
//                word = "Eight";
//                break;
//            case 9:
//                word = "Nine";
//                break;
//        }
//    }
//}





//int size = Convert.ToString(num).Length;
//switch (size)
//{
//    case 1:
//        someMethod(num);
//        Console.WriteLine(word);
//        break;

//    case 2:

//        break;

//    case 3:
//        break;
//    case 4:
//        break;
//    case 5:
//        break;
//    case 6:
//        break;
//    case 7:
//        break;
//}
