
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2909_Banking_App_Dict
{
    public class Bank_Transactions
    {
        Banking b = new Banking();
        public static object locker = new object();
        public static object locker2 = new object();


        public Account Deposit(Account acc)
        {
            try
            {
                Monitor.Enter(locker);
                Random random = new Random();
                int temp1 = random.Next(500, 1000);
                acc.pastAmnt = acc.netBalance;
                acc.netBalance += temp1;
                b.createPassbook(acc, temp1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(locker);
            }

            return acc;
        }




        public Account Withdraw(Account acc)
        {
            try
            {
                Monitor.Enter(locker2);
                acc.pastAmnt = acc.netBalance;
                Random random = new Random();
                int temp2 = random.Next(300, 600);

                try
                {
                    if (temp2 > acc.netBalance)
                    {
                        b.createPassbook(acc, temp2);
                        throw new Exception("Insufficient Balance...!!!");
                    }
                    acc.pastAmnt = acc.netBalance;
                    acc.netBalance -= temp2;
                    b.createPassbook(acc, temp2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(locker2);
            }



            return acc;
        }


    }
}