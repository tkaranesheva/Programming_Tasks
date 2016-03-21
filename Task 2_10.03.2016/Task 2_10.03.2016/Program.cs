using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_10._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInt = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0||i%7==0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            }
    }
}
