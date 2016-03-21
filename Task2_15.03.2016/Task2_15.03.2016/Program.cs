using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                long firstAddend = 0;
                long secondAddend = 1;
                long sum = 0;
                Console.Write("0, 1, ");
                for (int i = 1; i <= n; i++)
                {
                    sum = firstAddend + secondAddend;
                    firstAddend = secondAddend;
                    secondAddend = sum;
                    Console.Write(sum + ", ");
                }
            }
        }
    }
}
