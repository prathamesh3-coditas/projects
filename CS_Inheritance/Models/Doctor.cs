using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    /// <summary>
    /// DOcer is-a Staff. Derived from Staff 
    /// </summary>
    public class Doctor : Staff
    {
     
        //Doctor drObj = new Doctor();
        private string _specialization;
        public string? Specialization { get { return _specialization; } 
            set
            {
                int count = 0;
                foreach (var character in value)
                {
                    if (Char.IsLetter(character))
                    {
                        count++;
                    }
                }
                if (count == value.Length)
                {

                }

            } }

        private int _DoctorId;
        public int DoctorId { get { return _DoctorId; }
            set {
                _DoctorId = value;
            }
        
        }

        private int _fees;
        public int Fees { get { return _fees; } 
            set {
                _fees = value;
            } }

        private int _maxPatientsPerDay;
        public int MaxPatientsPerDay { get { return _fees;} 
            set { 
                _maxPatientsPerDay = value;
            } }

        
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
            return (GetBasicPay())+(_maxPatientsPerDay * _fees);
        }

        
    }
}