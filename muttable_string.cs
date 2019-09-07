using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class muttable_string
    {
        static void Main(string[] args)
        {
            StringBuilder s1 = new StringBuilder("morning");
            string ss = " friends";
            Console.WriteLine("length of {0} is {1} ", s1, s1.Length);
            Console.WriteLine("final string after adding 'friends' is {0} ", s1.Append(ss));
            Console.WriteLine("new string is " + s1.Insert(8, "good "));
            Console.WriteLine("previous string is " + s1.Remove(8,5));
            Console.WriteLine("replacing all o with @ in s1 is {0} ",s1.Replace('o','@'));
        }
    }
}