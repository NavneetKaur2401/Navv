using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class fall_through2
    {
        static void Main(string[] args)
        {
            int num = 2;
            switch (num)
            {
                case 0:
                    Console.WriteLine("case 0");
                    break;
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    goto case 0;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 4:
                    goto case 5;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }
        }
    }
}
