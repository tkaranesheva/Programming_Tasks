using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 4, 5, 6, 7, 8, 9 };
            { 
                for (int i = 6 - 1; i < array.Length; i--)
             
                Console.WriteLine(array[i]);
            }
        }
    }
}
