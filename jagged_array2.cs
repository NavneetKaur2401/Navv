using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class jagged_array2
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4 };
            arr[1] = new int[] { 5, 6, 7 };
            arr[2] = new int[] { 8, 9 };
            Console.WriteLine("the array is - ");
            foreach(int[] temp in arr)
            {
                foreach(int num in temp)
                {
                    Console.Write(num + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
