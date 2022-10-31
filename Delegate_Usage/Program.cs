namespace DelegateAndEvents
{

    public delegate int FirstDelegate(int x, int y);

    public delegate void SecondDelegate();

    public delegate void ThirdDelegate();
    public class DelegateDemo
    {

        public event SecondDelegate FirstEvent;

        public DelegateDemo()
        {
            FirstEvent += Meassage;
            FirstEvent += Meassage1;//we can associate one event for multiple methods

        }
        //Methods for which we are creating delegate should be static in order to call it without object
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int mul(int x, int y)
        {
            return x * y;
        }

        static void Meassage()
        {
            Console.WriteLine("Event is raised");
        }

        static void Meassage1()
        {
            Console.WriteLine("Event is raised");
        }
        //Anonymus delegate
        ThirdDelegate anonymous = delegate ()
        {
            Console.WriteLine("Anonymous Delegate");
        };


<<<<<<< HEAD
        Action anonymous1 = delegate ()
        {
            Console.WriteLine("Anonymous Action Delegate");
        };

=======
>>>>>>> 4afbc814181028fcf304d8b1dfadfe4488bf4a6c
        //Delegate as a paramt to method
        static void MethodWithDelegateParameter(FirstDelegate obj)
        {
            int finalMultiplication = obj(7, 8);
            Console.WriteLine($"Result of passing delegate as a parameter: {finalMultiplication}");
        }
        static void Main(string[] args)
        {
            /*Create delegate object and assign it a method so that we can directly pass 
            parameters to delegate reference */
            FirstDelegate obj1 = new FirstDelegate(Add);
            Console.WriteLine(obj1(12, 13));


            /*
             Create an array of delegate to assign multiple methods to a single delegate
             */
            FirstDelegate[] newObj = new FirstDelegate[]
            {
                new FirstDelegate(Add),
                new FirstDelegate(mul)
            };

            for (int i = 0; i < newObj.Length; i++)
            {
                Console.WriteLine(newObj[i](9, 8));
            }

            //Raising event assosiated with delegate
            DelegateDemo obj = new DelegateDemo();
            obj.FirstEvent();


            //calling anonymous delegate
            obj.anonymous();
            obj.anonymous1();

            //Delegate as a paramt to method
            FirstDelegate first = new FirstDelegate(mul);
            MethodWithDelegateParameter(first);


<<<<<<< HEAD
=======
            //Delegate as a paramt to method
            FirstDelegate first = new FirstDelegate(mul);
            MethodWithDelegateParameter(first);
>>>>>>> 4afbc814181028fcf304d8b1dfadfe4488bf4a6c
        }
    }
}