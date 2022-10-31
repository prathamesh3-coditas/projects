//Func<string, int> method = Work;
//IAsyncResult cookie = method.BeginInvoke("abc",Done,method);
////
//// ... here's where we can do other work in parallel...
////
//int result = method.EndInvoke(cookie);j
//Console.WriteLine("String length is: " + result);



//static int Work(string s) { return s.Length; }

//static void Done(IAsyncResult cookie)
//{
//    var target = (Func<string, int>)cookie.AsyncState;
//    int result = target.EndInvoke(cookie);
//    Console.WriteLine("String length is: " + result);
//}

using System.Data.SqlClient;
using System.Data;
using Dapper;

using System.Collections.Concurrent;
using System.Collections.Generic;

class MyClass
{
    public readonly int i;
    public const int xy = 3;




    Dictionary<int, char> dict = new Dictionary<int, char>();
     void print()
    {
        for (int i = 0; i < 1000000000; i++)
        {
            new MyClass().dict.TryAdd(i, 'z');

            foreach (var item in new MyClass().dict.Keys)
            {
                Console.WriteLine(item);
            }

        }
    }
    static void Main(string[] args)
    {
        //MyClass obj = new MyClass();
        //obj.dict.TryAdd(1,'a');
        //obj.dict.TryAdd(2,'b'); 
        //obj.dict.TryAdd(3,'c');
        //obj.dict.TryAdd(4,'d');
        //obj.dict.TryAdd(5,'e');

        ////new Thread(obj.print).Start();
        ////new Thread(obj.print).Start();

        //Task.Factory.StartNew(() =>
        //{
        //    obj.dict[1] = 'z';
        //    obj.dict[2] = 'x';

        //});

        //Task.Factory.StartNew(() =>
        //{
        //    obj.dict[2] = 'x';
        //});

        //foreach (var item in obj.dict.Values)
        //{
        //    Console.WriteLine(item);
        //}

        Parallel.For(0, 10, i =>
        {
            Console.WriteLine(i);
        });

        Parallel.For(0, 10, delegate (int i){

        });

        
    }
}

