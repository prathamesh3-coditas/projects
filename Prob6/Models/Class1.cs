using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob6.Models
{
    public abstract class Class1
    {
        public abstract void dummy();
    }

    public class derived : Class1
    {

        public override void dummy()
        {
            Console.WriteLine("Derived");
        }
    }
}
