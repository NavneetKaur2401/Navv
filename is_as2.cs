using System;

namespace hello_world
{
    public class cl1
    {
        public cl1()
        {
            Console.WriteLine("first class");
        }
    }

    public class cl2
    {
        public cl2()
        {
            Console.WriteLine("second class");
        }
    }

    class is_as2
    {
        public static void Main(string[] args)
        {
            object[] obj = new object[5];
            obj[0] = new cl1();
            obj[1] = new cl2();
            obj[2] = 123;
            obj[3] = "aman";
            obj[4] = 67;
            for(int i=0;i<obj.Length;i++)
            {
                string num = obj[i] as string;
                if (num == null)
                    Console.WriteLine("is not a string");
                else
                    Console.WriteLine("value is " + num);
            }
        }
    }
}

