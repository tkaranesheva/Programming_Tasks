using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08._03._2016_02task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your result:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt >= 1 && numInt <= 9)
            {
                Console.WriteLine("The number is in the interval [1;9]");
            }
            if (numInt >= 1 && numInt <= 3)
            {
                Console.WriteLine(numInt * 5);
            }
            if (numInt >= 4 && numInt <= 6)
            {
                Console.WriteLine(numInt * 10);
            }
            if (numInt >= 7 && numInt <= 9)
            {
                Console.WriteLine(numInt * 50);
            }
            else
            {
                Console.WriteLine("The number is out of the interval");
            }
        }
    }
    
}
