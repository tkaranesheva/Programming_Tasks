using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix2 = new int[4, 4];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.WriteLine("Enter element for {0}:{1}", i, j);
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        for (int j =0; j<matrix2.GetLength(1);j++ )
                        if (matrix2[i, j] % 2 == 1)
                        {
                            matrix2[i, j] *= 2;
                        }
                    }

                }
                }
            }
    }
}
