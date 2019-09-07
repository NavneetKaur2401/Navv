using System;

namespace hello_world
{
    public class c1
    {
       public c1()
        {
            Console.WriteLine("first class");
        }
    }

    public class c2
    {
        public c2()
        {
            Console.WriteLine("second class");
        }
    }

    class is_as
    {
        public static void Main(string[] args)
        {
            c1 obj1 = new c1();
            c2 obj2 = new c2();
            Console.WriteLine(obj1 is c1);
            Console.WriteLine(obj2 is c2);
            Console.WriteLine(obj1 is Object);
            Console.WriteLine(obj2 is Object);
            Console.WriteLine(obj1 is c2);
            Console.WriteLine(obj2 is c1);
        }
    }
}

