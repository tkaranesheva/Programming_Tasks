using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[] { 2, 3, 0, 3, 2 };
            for (int i = 0; i < arr1.Length; i++)
            {
                bool isSymetric = true;

                Console.WriteLine("The array is symetric: " + isSymetric);
            }
        }
    }
}
