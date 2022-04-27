using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square of integer 7 is {Square(7)}");
            Console.WriteLine($"Square of double 7.5 is {Square(7.5)}");
        }

            static int Square( int intValue)
        {
            return intValue * intValue;
        }

        static double Square(double intValue)
        {
            return intValue * intValue;
        }

      

    }
}
