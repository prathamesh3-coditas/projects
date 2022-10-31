abstract class myAbstract
{
   public virtual void VirtualMethod()
    {
        Console.WriteLine("virtual base");
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal base");
    }
}

class Concrete : myAbstract
{
    public override void VirtualMethod()
    {
        Console.WriteLine("virtual child");
    }

    public new void NormalMethod()
    {
        Console.WriteLine("Normal child");
    }
}

class Caller
{
    static void Main(string[] args)
    {
        myAbstract obj1 = new Concrete();


        obj1.NormalMethod();
        obj1.VirtualMethod();
    }
}