// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number:");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter second number:");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

//=============ADDITION=========================================
decimal addition;
void Add(decimal num1,decimal num2)
{
    addition= num1+num2;
    Console.WriteLine($"Addition of {num1}+{num2} is {addition}");

}


//=============SUBSTRACTION=========================================

decimal subs;
void Subs(decimal num1,decimal num2)
{
    if(num1 > num2)
    {
        subs = num1-num2;
        Console.WriteLine($"Substraction of {num1}-{num2} is {subs}");
    }
    else
    {
        subs = num1-num2;
        Console.WriteLine($"Substraction of {num2}-{num1} is {subs}");
    }
}


//=============MULTIPLICATION=========================================
decimal mul;
void Mul(decimal num1,decimal num2)
{
    mul = num1 * num2;
    Console.WriteLine($"multiplication of {num1}*{num2} is {mul}");
}


//=============DIVISION=========================================

decimal div;
void Div(decimal num1, decimal num2)
{
    if (num1 >= 0 && num2 >= 0)
    {
        if (num1 > num2)
        {
            div = num1 / num2;
            Console.WriteLine($"Division of {num1}/{num2} is {div}");
        }
        else
        {
            div = num2 / num1;
            Console.WriteLine($"Division of {num2}/{num1} is {div}");

        }

    }
    else
    {
        Console.WriteLine("Division by \"0\" is not possible");

    }
}

Add(num1,num2);
Subs(num1,num2);
Mul(num1,num2);
Div(num1,num2);

//=============SQUARE=========================================
Console.WriteLine("Enter a number to find square:");
int num = Convert.ToInt32(Console.ReadLine());
decimal square;
Sq(num);
void Sq(int num)
{
    square = num * num;
    Console.WriteLine($"Square of {num} is {square}");
}

//=============SQUARE ROOT=========================================
Console.WriteLine("Enter a number to find square root:");
decimal inputNum = Convert.ToDecimal(Console.ReadLine());
decimal answer;
Sqrt(inputNum);
void Sqrt(decimal num)
{
    if (inputNum>0)
    {
        for (int i = 1; i <= inputNum; i++)
        {
            answer = i * i;
            //prevSq = (i-1)*(i-1);
            //if(answer > inputNum)
            //{
            //    for (decimal j = inputNum; j >=1; j--)
            //    {
            //        if (j == prevSq)
            //        {
            //            Console.WriteLine($"Square root of {inputNum} is {i-1}");
            //        }
            //    }
            //}
            if (answer > inputNum)
            {
                Console.WriteLine($"Square root of {inputNum} is {i - 1}");
                break;
            }
            if (inputNum == answer)
            {
                Console.WriteLine($"Square root of {answer} is {i}");
            }
        }
    }
    else
    {
        Console.WriteLine("Enter a positive number");
    }
}



//=============POWER=========================================

Console.WriteLine("Enter 2 numbers to find power:");
decimal num3 = Convert.ToDecimal(Console.ReadLine());
decimal num4 = Convert.ToDecimal(Console.ReadLine());
decimal power=1; 

void Power(decimal num3,decimal num4)
{
    for (int i = 0; i < num4; i++)
    {
        power = power * num3;
    }
    Console.WriteLine($"Power of {num3} is to {num4} is {power}");

}

Power(num3,num4);