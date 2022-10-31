using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assign_2909_Banking_App_Dict
{
    public class Banking_operation
    {
        Bank_Transactions transactions = new Bank_Transactions();
        //Banking banking = new Banking();
        public void RandomTransaction()
        {

            //Task t1 = Task.Factory.StartNew(async () =>
            //{
            //    foreach (var item in Banking.list)
            //    {
            //        await transactions.Deposit(item);
            //        //Console.WriteLine(obj.accName+" "+obj.netBalance);
            //    }
            //});

            ////Task.WaitAll(t1);
            //t1.Wait();
            //Task t2 = Task.Factory.StartNew(async () =>
            //    {
            //        foreach (var item in Banking.list)
            //        {
            //            await transactions.Withdraw(item);
            //            //Console.WriteLine(obj.accName + " " + obj.netBalance);
            //        }
            //    });

            //t2.Wait();




            Task t1 = new Task(() =>
            {
                foreach (var item in Banking.list.Values)
                {
                    transactions.Deposit(item);

                }
            });

            Task t2 = new Task(() =>
            {
                foreach (var item in Banking.list.Values)
                {
                    transactions.Withdraw(item);
                }
            });



            Random r = new Random();
            int caller = r.Next(1, 101);
            if (caller >= 1 && caller <= 50)
            {
                //Parallel.Invoke(() =>
                //{
                //    t1.Start();
                //    t2.Start();
                //});

                t1.Start();
                t2.Start();
                Task.WaitAll(t1, t2);
            }
            else if (caller >= 50 && caller <= 75)
            {
                t1.Start();
            }
            else
            {
                t2.Start();
            }
        }
    }
}