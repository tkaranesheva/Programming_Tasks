using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_02
{
    class Program
    {
        private static object input;

        static void Main(string[] args)
        {
            //task 1
            int x = 6;
            int y = 84;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x + y);
            //taks 2
            string str1;
            str1 = "Hello";
            Console.WriteLine(str1);
            bool boolstr1 = true;
            Console.WriteLine("Hello=" + boolstr1);

            //task 3 
            int a = 5;
            int b = 7;
            // S=?
            Console.WriteLine(a * b);

            //Task 4 po-pravilno li e s %?
            decimal z = 22;
            decimal w = 7;
            Console.WriteLine(z);
            Console.WriteLine (z/w);

            //Task  5 - two strings and concatinate
            string str3 = "Hello";
            string str4 = " Teodora";
            Console.WriteLine (str3 + str4);

            //Task 6 
            float f1 = 8.575678f;
            int int1 = 6;
            Console.WriteLine(f1);
            Console.WriteLine(int1);
            Console.WriteLine(f1 / int1);

            //Task 7 - string in another string
            string str5 = "Hello my name is Teodora";
            string str6 = "Teodora";
            Console.WriteLine(str5);
           
            bool contains = str5.Contains(str6);
            Console.Write("Contains 'str6': ");
            Console.WriteLine(contains);

            //Task 8 to display n-th symbol (l) from a string
            string str7 = "Welcome to my webpage";
            char c1 = str7[2];
            Console.WriteLine(c1);
          
        }
    }
}
