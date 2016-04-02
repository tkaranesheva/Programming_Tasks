using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_29._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];

            int a = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j]=a;
                    a++;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)

            {
                for (int j = 0; j < matrix.GetLength(1); j++)

                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
                int smallest = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        smallest = matrix[i,j];
                    }
                }

               
                    }
                    Console.WriteLine("the smallest no is {0}", smallest);
                    //Console.WriteLine("the largest no is {0}", largest);
                }
        }
    }
}
