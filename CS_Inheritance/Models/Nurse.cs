using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    public class Nurse : Staff
    {
        //public Nurse()
        //{
        //    Console.WriteLine("This is Nurse constructor");
        //}

        private string _specialization;
        public String? Specialization { get { return _specialization; }
            set {
                _specialization = value;
            } }

        
        
        private int _nurseId;
        public int NurseId { get { return _nurseId; } set { _nurseId = value; } }





        private int _shiftStartTimings;
        public int ShiftTimings { get { return _shiftStartTimings; } 
            set {
                _shiftStartTimings = value;
            } }

       
        
        
        
        
        private int _shiftEndTimings;
        public int ShiftEndTimings
        {
            get { return _shiftEndTimings; }
            set
            {
                _shiftEndTimings = value;
            }
        }
       
        
        
        
        
        
        
        private int _extraHours;
        public int ExtraHours { get { return _extraHours; } set { _extraHours = value; } }


       
        public void SetBasicPay(int pay)
        {
            this.BasicPay = pay;
        }
        public int GetBasicPay()
        {
            return this.BasicPay;
        }

        public int NetPay(int BasicPay)
        {
            return GetBasicPay() + (ExtraHours*100);
        }


    }
}
