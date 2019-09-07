using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class immutable_string
    {
        static void Main(string[] args)
        {
            string s1 = "good";
            string s2 = "morning";
            string temp;
            int diff;
            int index;
            Console.WriteLine("length of {0} and {1} is {2} and {3} respectively ", s1, s2, s1.Length, s2.Length);
            diff = String.Compare(s1, s2);
            if(diff == 0)
                Console.WriteLine("{0} and {1} are equal", s1, s2);
            else if(diff<0)
                Console.WriteLine("{0} comes before {1} in sort order ", s1, s2);
            else
                Console.WriteLine("{0} comes after {1} in sort order ", s1, s2);
            index = s2.IndexOf('i');
            Console.WriteLine("index of i in {0} is {1} ", s2,index);
            temp = String.Concat(s1, s2);
            Console.WriteLine("concatenates string is {0} ", temp);
            Console.WriteLine("substring of {0} from 2 to 4 is {1} ",s2,s2.Substring(2,4));


        }
    }
}