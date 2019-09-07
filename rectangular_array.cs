using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    class rectangular_array
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 1, 2, 3, 4 } }; 
            Console.WriteLine("the array is - ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
