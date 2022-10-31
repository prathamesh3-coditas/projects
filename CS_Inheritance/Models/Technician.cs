using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    public class Technician : Staff
    {


        private string _education;
        public string Education { get {return _education; } set { _education = value; } }

        private int _techId;
        public int TechId { get { return _techId; } set { _techId = value; } }

        private string _specialization;
        public string Specialization { get {return _specialization; } set { _specialization = value; } }
        public int GetBasicPay()
        {
            return this.BasicPay;
        }

        public void SetBasicPay(int pay)
        {
            this.BasicPay = pay;
        }
        public int NetPay(int BasicPay)
        {
            return GetBasicPay();
        }
    }
}
