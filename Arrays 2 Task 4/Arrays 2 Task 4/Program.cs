using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 6];
            int y = 30;
            for (int i = 0; i < matrix.GetLength(0); i++)

            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = y;
                    y--;
                }
            }
                for (int i = 0; i < matrix.GetLength(0); i++)

                {
                for (int j = 0; j < matrix.GetLength(1); j++)

                {
                    Console.Write(" " + matrix[i, j]);
                }
                    Console.WriteLine();
                }
                
        }
    }
}
