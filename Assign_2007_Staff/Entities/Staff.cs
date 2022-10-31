using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2007_Staff.Entities
{
    public abstract class Staff
    {


        public static int id = 1;

        public String Catagory { get; set; }
        public int StaffId { get; set; }

        private string _staffName;
        public bool validation(String name)
        {
            int countChar = 0;
            foreach (var character in name)
            {
                if (Char.IsLetter(character))
                {
                    countChar++;
                }
            }

            if (countChar == name.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string? StaffName { get { return _staffName; }
            set 
            {
                while (validation(value) == false)
                {
                    Console.WriteLine("Enter valid name:");
                    value = Console.ReadLine();
                }

                _staffName = value;
            } }

        private int _basicPay;
        public int BasicPay { get { return _basicPay; }
            set 
            { 
                if(BasicPay >= 0 )
                {
                    _basicPay = value;
                }
                else
                {
                    Console.WriteLine("Enter valid pay:");
                    value = Convert.ToInt32(Console.ReadLine());
                }
            } }

        public abstract int calculateNetIncome(int BasicPay);

    }

}
