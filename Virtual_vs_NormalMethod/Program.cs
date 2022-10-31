class Base
{
    //public abstract void method1();

    public virtual void VirtualMethod()
    {
        Console.WriteLine("Virtual method from base");
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal method from base");
    }
}

class Derived : Base
{
    public void NormalMethod()
    {
        Console.WriteLine("Normal method from derived");
    }

    public override void VirtualMethod()
    {
        Console.WriteLine("Virtual method from derived");
        //base.Implement();
    }

    static void Main(String[] args)
    {
        Derived derived = new Derived();
        Base baseObj = new Derived();

        /* 
         Here we are calling normal methods 
        i.e. base class method & overridden method in child class.
        Both will be called according to their respective objects.
         */
        derived.NormalMethod();
        baseObj.NormalMethod();

        /* 
         Here we are calling virtual method from base class
        and ovverridden virtual method of child class

        although we are creating reference of base class it will call overridden method in child 
        class only.Cz method was virtual in base class.
         */
        derived.VirtualMethod();
        baseObj.VirtualMethod();

    }

}

