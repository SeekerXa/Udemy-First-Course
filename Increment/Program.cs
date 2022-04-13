using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 5;
            Console.WriteLine($"c before postincrement : {c}");
            Console.WriteLine($"c postincrement : {c++}");
            Console.WriteLine($"c after postincrement : {c}");

            c = 5;
            Console.WriteLine($"c before preincrement : {c}");
            Console.WriteLine($"c  preincrement : {++c}");
            Console.WriteLine($"c after preincrement : {c}");

           




        }
    }
}
