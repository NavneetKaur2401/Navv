using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class array_func
    {
        static void show(int[] temp)
        {
            foreach (int i in temp)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 34, 23, 90, 67, 56, 89, 9, 1 };
            int[] arr1 = new int[9];
            int index;
            Console.WriteLine("length of the array " + arr.Length);
            Console.WriteLine("the sorted array ");
            Array.Sort(arr);
            show(arr);
            Console.WriteLine("index position of 90 is " + Array.IndexOf(arr, 90));
            Array.Copy(arr, arr1, arr.Length);
            Console.WriteLine("second array elements ");
            show(arr1);
            Array.Reverse(arr);
            Console.WriteLine("first array elements in reverse order ");
            show(arr);
            index = Array.BinarySearch(arr, 2);
            if (index > 0)
                Console.WriteLine("the element is found");
            else
                Console.WriteLine("the element is not found");
        }
    }
} 