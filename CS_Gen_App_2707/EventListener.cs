using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
using CS_Gen_App.Models;



namespace CS_Gen_App.Entities
{
    /// <summary>
    /// ------------------- Declare a delegate -------------------
    /// </summary>

    public delegate void OperationHandeller(string msg);

    
    public class EventListener
    {
        //------------------- Create events assosiacted with delegate -------------------
       public  event OperationHandeller staffAdd;
       public event OperationHandeller staffRemove;
       public event OperationHandeller staffUpdate;
        public EventListener()
        {
            /*
             Here we are specifying that events are assosiated with which method
            means when that particular event is raised the method assosiated with it is executed
             */
            staffAdd += addEmp;
            staffRemove += deleteEmp;
            staffUpdate += updateEmp;
        }



        /*
        => Here we are raising an event by calling Added() in program.cs. As soon as Added() is called
        "staffAdd" event is raised.When staffAdd event is raised,a method to which staffAdd is assosiated is 
        executed{i.e.  addEmp()}
        =>   As its an event of delegate "OperationHandeller" which takes "string" as argument,we provide string 
        msg that we want to print as argument for staffAdd(). 
        =>   Now as this event is assosiated with addEmp(),a method addEmp() is called and arguments "msg" is 
        passed to it.
        =>   This "msg" comes from argument passed to event i.e. staffAdd(msg);
        */
        public void Added(string msg)
        {
            staffAdd(msg);
        }



        public virtual void Removed(string msg)
        {
            staffRemove(msg);   
        }

        public virtual void Updated(string msg)
        {
            staffUpdate(msg);
        }


        //This method will will be executed when staffAdd event is raised
        public void addEmp(string msg)
        {
            Console.WriteLine(msg);
        }

        //This method will will be executed when staffRemove event is raised
        public void deleteEmp(string msg)
        {
            Console.WriteLine(msg);
        }

        //This method will will be executed when staffUpdate event is raised
        public void updateEmp(string msg)
        {
            Console.WriteLine(msg);
        }
    }

}
