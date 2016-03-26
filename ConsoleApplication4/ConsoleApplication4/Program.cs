using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {

            int[] ourArray = new int[] { 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            for (i = 0; i < ourArray.Length; i++)
            {
                if (ourArray[i] % 2 == 0)
                {
                    sum = sum + ourArray[i];
                }
            }
                    Console.WriteLine(+sum);

            }
    }
}
