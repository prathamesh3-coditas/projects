using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    /// <summary>
    /// Class with Auto-Impmented Properties C# 3.0
    /// </summary>
    public class Staff
    {
        //public Staff()
        //{
        //    Console.WriteLine("CTOR for Staff");
        //}

 
       private int _staffId;
        public int StaffId { get { return _staffId; }
            set
            {
                if (value<0)
                {
                    while (value<0)
                    {
                        Console.WriteLine("Enter a valid number");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    _staffId = value;

                }
            } } 
//=================================================================================================
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

            if (countChar==name.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string StaffName { get { return _staffName; } 
            set {
                while (validation(value)==false)
                {
                    Console.WriteLine("Enter valid name:");
                    value = Console.ReadLine();
                }

                _staffName = value;
            } }
        //=================================================================================================

        private String _deptName;

        public String DeptName { get { return _deptName; } 
            set { 
                    DeptName = value;
            } }
        //=================================================================================================


        private string _email;
        public string Email { get { return _email; } 
            
            set { 
            _email = value; 
            } }
//=================================================================================================

        private int _contactNo;

        public int ContactNo { get { return _contactNo; }
            set {
                _contactNo = value;
            } }
//=================================================================================================

        private string _education;
        public string? Education { get { return _education; }
            set {
                _education = value;
            } }
//=================================================================================================

        private int _shiftStartTime;  
        public int ShiftStartTime { get { return _shiftStartTime; }
            set {
                _shiftStartTime = value;
            } }
//=================================================================================================

        private int _shiftEndTime;
        public int ShiftEndTime { get { return _shiftEndTime; } 
            set {
                _shiftEndTime = value;
            } }
//=================================================================================================

        private int _basicPay;
        protected int BasicPay { get { return _basicPay; } 
            set {
                _basicPay = value;
            } }
    }
}