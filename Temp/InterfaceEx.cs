using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public interface InterfaceEx
    {

        public virtual void Basemethod()
        {
            Console.WriteLine("Base virtual");
        }

        abstract void myMethod();
    }

    public class Child1 : InterfaceEx
    {
    
        void InterfaceEx.myMethod()
        {
            Console.WriteLine("This is method child1");
        }

       public void Basemethod()
        {
            
            Console.WriteLine("overridden child1");
        }
    }

    public class Child2 : InterfaceEx
    {


        void InterfaceEx.Basemethod()
        {
            Console.WriteLine("overridden child2");
        }
        public void myMethod()
        {
            Console.WriteLine("My method child 2");
        }
    }

    public class Caller 
    {
        static void Main(string[] args)
        {
            Child1 child1 = new Child1();//Its of no use as Child1 class doesnt own any method
            Child2 child2 = new Child2();//it can access myMethod which is owned by Child2 class

            InterfaceEx obj = new Child1();/*it can access methods present in Child1 class but 
                                            owned by interface & also methods of Child1 class  i.e. explicitely 
                                            implemented methods
                                            */


            InterfaceEx obj2 = new Child2();/*
                                             it can access methods of Child2 class and methods present in
                                             Child2 class but owned by interface i.e. explicitely implemented
                                             methods
                                             */

            child1.Basemethod();
            obj2.Basemethod();
            
        }

        
    }
}
