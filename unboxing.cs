using System;

namespace hello_world
{
    class unboxing
    {
        public static void Main(string[] args)
        {
            int num = 2020;
            object obj = num;
            int i = (int)obj;
            Console.WriteLine("value of object is " + obj);
            Console.WriteLine("value of i is " + i);
        }
    }
}