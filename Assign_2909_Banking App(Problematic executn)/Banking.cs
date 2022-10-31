using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2909_Banking_App
{
    public class Banking
    {

        public static ConcurrentBag<Account> list = new ConcurrentBag<Account>();
        static decimal number = 1000;
        public void createAcc(Account acc, decimal opening, string accName)
        {
            acc.accName = accName;
            acc.initialBalance = opening;
            acc.netBalance = acc.initialBalance;
            acc.accNumber = number++;
            acc.pastAmnt = acc.netBalance;
            if (!list.Contains(acc))
            {
                list.Add(acc);
            }
        }


        public async Task<Account> createPassbook(Account acc, int DepoWith)
        {
            try
            {
                string path = @$"C:\.net Training\Solution\Employee data\Banking project\Passbook\{acc.accName}";

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    if (acc.pastAmnt > acc.netBalance)
                    {
                        sw.WriteLine("--------------------------------------------------------------------");
                        await sw.WriteLineAsync($"Withdrawn amount: {DepoWith} && Net balance: {acc.netBalance}");
                        sw.WriteLine("--------------------------------------------------------------------");
                    }
                    else if (acc.pastAmnt < acc.netBalance)
                    {
                        sw.WriteLine("--------------------------------------------------------------------");
                        await sw.WriteLineAsync($"Deposited amount: {DepoWith} && Net balance: {acc.netBalance}");
                        sw.WriteLine("--------------------------------------------------------------------");
                    }
                    else
                    {
                        sw.WriteLine("--------------------------------------------------------------------");
                        await sw.WriteLineAsync("Transaction failed...!!!");
                        sw.WriteLine("--------------------------------------------------------------------");
                    }
                }


            }
            catch (Exception ex)
            {

                //Console.WriteLine(ex.Message);
            }
            return acc;
        }
    }
}