//using System.ComponentModel.Design;

//class MyClass
//{
//    public async static void Add(int i)
//    {
//        //await Task.Factory.StartNew(() => {
//        //    for (int i = 0; i < 1000; i++)
//        //    {
//        //        Console.WriteLine(i);

//        //    }
//        //    Console.WriteLine("After for");
//        //});

//        //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//    }

//    public void demo(out int a)
//    {
//        a = 0;
//        Console.WriteLine(a);
//    }

//    static void Main(string[] args)
//    {
//        //    Task t = new Task(() =>
//        //    {
//        //        Add(1);
//        //    });

//        //    t.Start();


//        //    Task.Factory.StartNew(() =>{
//        //        Add(2);
//        //        Add(2);
//        //        Add(2);
//        //    });



//        //    Task.Factory.StartNew(() => {
//        //        Add(2);
//        //    });

//        //    Console.ReadLine();

//        // Thread t = new Thread(() =>
//        // {
//        //     Add(1);
//        //     Add(1);
//        //     Add(1);
//        //     Add(1);
//        // });

//        // t.Start(); 

//        // Thread t1 = new Thread(() =>
//        // {
//        //     Add(1);
//        //     Add(1);
//        //     Add(1);
//        //     Add(1);
//        // });

//        // t1.Start();

//        // List<int> list = new List<int>();
//        // list.Add(1);
//        // list.Add(2);
//        // list.Add(3);


//        // Console.WriteLine(list.Sum(x=>Convert.ToInt32(x))+"Result");

//        //var numbers =  list.Where(a => a >1);
//        // Console.WriteLine("-------------------");
//        // foreach (var item in numbers)
//        // {
//        //     Console.WriteLine(item);
//        // }

//        // Console.WriteLine("-------------------");
//        // MyClass obj = new MyClass();
//        // int a = 4;
//        // obj.demo(out a);


//        Console.WriteLine("Before");
//        Add(1);
//        Console.WriteLine("After");
//        Console.WriteLine("After1");
//        Console.ReadLine();

//    }
//}

class MyClass
{

    static void add()
    {
        Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i+"=>"+Thread.CurrentThread.ManagedThreadId);
            }
        });

        Console.WriteLine("after for");
    }

<<<<<<< HEAD
        static void Main(string[] args)
        {
            Console.WriteLine("In main thread =>"+Thread.CurrentThread.ManagedThreadId);
=======

  
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();


        Task t2 = new Task(async () =>
        {
<<<<<<< HEAD
            obj.Add(2, 3);

            Console.WriteLine("Add inside 2");

        });


=======
            await obj.Add(2, 3);

            Console.WriteLine("Add 2");

        });

        
>>>>>>> 4afbc814181028fcf304d8b1dfadfe4488bf4a6c
        t2.Start();
        Task.WaitAll(t2);

        //obj.Add(1, 2);
        //Thread.Sleep(0);

        Console.WriteLine("Add 2");

        //Parallel.Invoke(() =>
        //{
        //    obj.Add(1, 2);
        //    Thread.Sleep(0);

        //    Console.WriteLine("add 2");
        //});
        Console.ReadLine();

    }
}


>>>>>>> 065f77254bfb14e0772b17c6934259807026ad8b

            add();
        Console.WriteLine("After add");
            Console.ReadLine();
        }
        }