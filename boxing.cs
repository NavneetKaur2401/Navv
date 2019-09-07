using System;

namespace hello_world
{
    class boxing
    {
        public static void Main(string[] args)
        {
            int num = 2020;
            object obj = num;
            num = 100;
            Console.WriteLine("value of num is " + num);
            Console.WriteLine("value of object is " + obj);
        }
    }
}