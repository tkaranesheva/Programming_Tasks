using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_29._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 45, 66, 23, 44, 19, 85, 64, 1, 11, 14 };
            int smallest = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] % 2 == 0&&array[i] < smallest)
                {
                    smallest = array[i];
                }
            }

            {
                int largest = array[9];
                for (int i = 0; i < 10; i++)
                {

                    if (array[i]%2!=0&&array[i] > largest)
                    {
                        largest = array[i];

                    }
                }
                Console.WriteLine("the smallest no is {0}", smallest);
                Console.WriteLine("the largest no is {0}", largest);

            }
        }
    }
}

