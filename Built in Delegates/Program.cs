class MyClass
{
    public event Func<Int16, Int16, Int16> myEvent; //creating event without explicit delegate  
    public static short ActionDemo(short a, short b)
    {
        Console.WriteLine("Action demo method...!!!");
        return a;
    }



    //Predicate fn: Is a fn that takes some input and returns boolean value
    static bool LessThan5(int a)
    {
        return a < 5;
    }

    static void Main(string[] args)
    {
        //Action<Int16,Int16> obj1 = ActionDemo;        //Action<> has void return type

        Func<Int16, Int16, Int16> action = ActionDemo;  //Function<> has short return type
        action(1, 2);



        Func<Int32,bool> isLess = LessThan5;
        Console.WriteLine(isLess(4));


        //Lambda expression
        Func<int, int> square = number => number * number;
        Console.WriteLine(square(12));


        Func<int, int, int> add = (num1, num2) => num1 + num2;  //Here last int is for return type 
        Console.WriteLine(add(12, 13));


        MyClass obj = new MyClass();
        obj.myEvent += ActionDemo;//Calling event without delegate
        obj.myEvent(8, 9);

    }
}