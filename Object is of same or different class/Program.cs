class Staff
{

}
class Doctor : Staff
{

}
class Nurse : Staff
{

}

class Technician : Staff
{

}

class MyClass
{
    static void Main(string[] args)
    {

        Staff dr = new Doctor();
        Staff nr = new Nurse();
        Staff tc = new Technician();




        if (dr is Staff)
        {
            /*var d = dr as Doctor;     We're telling to treat dr as object of Doctor.
             and assign the reference to d so that d will be an object of Doctor 
            */
            Console.WriteLine("Is of same type");
        }
        else
        {
            Console.WriteLine("Is of diff types");
        }





        if (nr is Nurse)
        {
            Console.WriteLine("Is of same type");
        }
        else
        {
            Console.WriteLine("Is of diff types");
        }






        if (Object.ReferenceEquals(dr, nr))
        {
            Console.WriteLine("same type");
        }
        else
        {
            Console.WriteLine("diff type");
        }

    }
}