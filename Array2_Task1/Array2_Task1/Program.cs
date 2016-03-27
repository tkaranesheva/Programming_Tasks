using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3] {
                 { 2,7,6},
                 { 1,4,5}
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] % 2 == 0)
                        {
                            Console.Write("   " + array[i, j]);
                        }
                    Console.WriteLine();
                     }
            }
    }
}
