using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_10._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            //int counter = 1;
            //while (counter <= 100)
            //{
            //    if (counter % 7 == 0 || counter % 11 == 0)
            //    {
            //        Console.WriteLine(counter);
            //    }
            //    counter++;
            //}

            //DO-WHILE
            int counter = 1;
            do
            {
                if (counter % 7 == 0 || counter % 11 == 0)
                {
                    Console.WriteLine(counter);
                }
                {
                    counter++;
                }
            }
            while (counter <= 100);
                    
            //FOR

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 7 == 0 || i % 11 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }    
    }
}
