using System.Runtime.CompilerServices;

interface sample
{
    public void print();
}

class implemented : sample
{
   public  void print()
    {
        Console.WriteLine("in class");
    }
}

class depend
{
    private implemented obj;
    public depend(implemented obj)
    {
        this.obj = obj;
    }

    public void print()
    {
        obj.print();
    }
}


class Caller
{
    static void Main(string[] args)
    {
        depend obj1 = new depend(new implemented());
        obj1.print();
    }
}