﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_10._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter first number");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number");
            num2 = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num1 == 0 && num2 == 0)
            {
                Console.WriteLine(num1 + num2);
                Console.ReadLine();
            }
            if (num1 != 0 && num2 != 0);
            {
                break;
            }

        }
    }
}
