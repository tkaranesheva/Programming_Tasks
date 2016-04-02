using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_29._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 9 };
            int[] b = new int[] { 5, 6, 1, 2, 7, 8 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.WriteLine(a[i]);
                        Console.WriteLine(b[j]);
                    }
                }
            }
        }
    }
}
