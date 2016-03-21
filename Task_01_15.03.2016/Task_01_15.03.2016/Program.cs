using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[5];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = i;

            foreach (int x in nums)
            { 
                  if (i % 2 == 0)
                    {
                    Console.WriteLine("The value of the element is:" + x);
                    sum += x;
                }
            }
            Console.WriteLine("The sum of elements is:" + sum);
   
        }
    }
}
