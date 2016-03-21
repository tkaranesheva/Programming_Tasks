using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] teddy = new int[10];
            for (int i = 0; i <10; i++)
                teddy[i] = i;
            foreach (int i in teddy)
            {
                Console.WriteLine(i*10);
         

            }
        }
    }
}
