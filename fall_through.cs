using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class fall_through
    {
        static void Main(string[] args)
        {
            char grade = 'b';
            switch (grade)
            {
                case 'a':
                    Console.WriteLine("excellent");
                    break;
                case 'b':
                case 'c':
                    Console.WriteLine("well done");
                    break;
                case 'd':
                    Console.WriteLine("passed");
                    break;
                case 'f':
                    Console.WriteLine("better luck next time");
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    break;
            }
        }
    }
}
