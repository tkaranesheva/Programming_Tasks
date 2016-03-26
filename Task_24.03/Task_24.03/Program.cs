using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24._03
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 4;
            int c = 2;
            int sum = CalculateSum(a, b, c);
            Console.WriteLine(sum);

        }
        private static int CalculateSum(int a, int b, int c)
        {
            int CalculateSum = a - b * c;
            return CalculateSum;
            }
    }
}
