//class myStruct //reference type
//{
//    public int Id { get; set; }

//    public string name { get; set; }
//}

struct myStruct   //value type
{
    public int Id { get; set; }

    public string name { get; set; }
}

class Caller
{


    static void Main(string[] args)
    {
        myStruct obj1 = new myStruct()
        {
            Id = 1,
            name = "abc"
        };

        myStruct obj2 = obj1;//both objects will point to same memory location in case of classes.

        obj2.Id = 2;

        Console.WriteLine(obj1.Id);
        Console.WriteLine(obj2.Id);
    }
}