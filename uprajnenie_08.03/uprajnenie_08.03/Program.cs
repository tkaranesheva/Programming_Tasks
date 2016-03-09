using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie_08._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int numInt = int.Parse(Console.ReadLine());

            if ((numInt >=1) && (numInt<=5))
            {
                if (numInt % 2 == 0)
                {
                    Console.WriteLine("Chetno");
                }
                else
                {
                    Console.WriteLine("Nechetno");
                }
                if ((numInt >=6)&&(numInt<=15))
                {
                    if (numInt%3==0)
                    {
                        Console.WriteLine("Deli se na 3");
                        }
              if ((numInt<1)&& (numInt>15))

                }
            }
        }
    }
