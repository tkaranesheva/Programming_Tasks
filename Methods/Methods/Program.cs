using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    using System;

    class EvenOrNot
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("Even");
            if (number % 2 != 0) Console.WriteLine("Not even");
        }
    }

}

