using System;

namespace hello_world
{
    class bitwise
    {
        public static void Main(string[] args)
        {
            int num1 = 60;
            int num2 = 13;
            int temp = 0;
            temp = num1 & num2;
            Console.WriteLine("bitwise and " + temp);
            temp = num1 | num2;
            Console.WriteLine("bitwise or " + temp);
            temp = num1 ^ num2;
            Console.WriteLine("bitwise xor " + temp);
            temp = ~num1;
            Console.WriteLine("bitwise compliment " + temp);
            temp = num1 << 2;
            Console.WriteLine("left shift by two " + temp);
            temp = num1 >> 2;
            Console.WriteLine("right shift by two " + temp);
        }
    }
}