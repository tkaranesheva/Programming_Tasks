using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] items = new int[5];
            Array.Copy(a, 0, items, 0, 5);
            Array.ForEach(items, x => Console.WriteLine(x));

        }
        
    }
}
