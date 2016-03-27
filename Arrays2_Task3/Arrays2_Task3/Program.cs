using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max number:");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min number:");
            int min = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter max number:");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min number:");
            int min = int.Parse(Console.ReadLine());


            string[,] matrix2 = new string[max, min];
            for (int i = max; i < matrix2.GetLength(0); i++)
            {
                for (int j = min; j < matrix2.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if (i % 3 == 0 && j % 3 == 0)
                        {
                            int[] result = new int[] { };
                            int a = i;
                            int b = j;
                            {

                            }
       
    }
}
