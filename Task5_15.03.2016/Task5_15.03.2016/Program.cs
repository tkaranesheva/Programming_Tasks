using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_15._03._2016
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5 };
            //int[] items = new int[5];
            //Array.Copy(a, 0, items, 0, 5);
            //Array.ForEach(items, x => Console.WriteLine(x));

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[5];
           
            for (i=0;i<array.Length;i++)
            {
                array2[i] = array[i];
            }
            foreach (int i in array2)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
