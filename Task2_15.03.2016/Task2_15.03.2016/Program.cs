using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_15._03._2016
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            {
                uint n= uint.Parse(Console.ReadLine());

                int[] array = new int[n];
                array[0] = 0;
                array[1] = 1;
                for (i = 2; i < array.Length; i++)
                {
                    array[i] = array[i - 1] + array[i - 2];
                }
                {
                    Console.WriteLine("Select the lenght of the array:");
                }
                for (i = 0; i< array.Length; i++)
                     { 
                    Console.Write(array[i]);
                }
            }
        }
    }
}
