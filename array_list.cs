using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class array_list
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(7);
            arr.Add(1);
            arr.Add("john");
            arr.Add(3);
            arr.Add("james");
            arr.Add(5);
            Console.WriteLine("arraylist below ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("total number of elements " + arr.Count);
            Console.WriteLine("capacity of arraylist is " + arr.Capacity);
            arr.RemoveAt(2);
            Console.WriteLine("arraylist after removing second element ");
            for (int i = 0; i <arr.Count; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            if (arr.Contains(3))
                Console.WriteLine("yes the element exists");
            else
                Console.WriteLine("no the element doesnot exist");
            arr.TrimToSize();
            Console.WriteLine(" new capacity of arraylist is " + arr.Capacity);
        }
    }
}