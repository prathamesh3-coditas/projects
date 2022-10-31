//using ClassLibrary1;
using System.Diagnostics;
using(Process p = Process.GetCurrentProcess())
	p.PriorityClass = ProcessPriorityClass.High;
//class MyClass : Class1
//{

//    public Func<int, int> Add(int a,int b)
//    {
//        return x => x + a + b;
//    }

//    static void Main(string[] args)
//    {
//        Class1 obj = new Class1();
//        obj.Sum();

//        MyClass obj2 = new MyClass();
//        Func<int, int> func = obj2.Add(2, 3);
//        Console.WriteLine(func(4));
//    }
//}

async static Task Add(int a)
{
	Console.WriteLine("Inside add"+"=>"+Thread.CurrentThread.ManagedThreadId);
	//await Task.Factory.StartNew(() =>
	//{
		for (int i = 0; i < 1000; i++)
		{
			Console.WriteLine(i+"=>"+Thread.CurrentThread.ManagedThreadId);
		}
	//});

	//await Task.Run(() =>
	//{
	//       for (int i = 0; i < 1000; i++)
	//          {
	//              Console.WriteLine(i);
	//          }
	//   });
	Console.WriteLine("After for"+"=>"+Thread.CurrentThread.ManagedThreadId);
}


Console.WriteLine("before"+"=>" + Thread.CurrentThread.ManagedThreadId);
await Add(4);
Console.WriteLine("After"+"=>"+Thread.CurrentThread.ManagedThreadId);
Console.ReadLine();


