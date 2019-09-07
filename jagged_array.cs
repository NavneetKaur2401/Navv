using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class jagged_array
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4 };
            arr[1] = new int[] { 5, 6, 7 };
            arr[2] = new int[] { 8, 9 };
            Console.WriteLine("the array is - ");
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
