using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxminFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter first value: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write(" Enter secound value: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write(" Enter third value: ");
            double number3 = double.Parse(Console.ReadLine());


            Console.WriteLine($"Bigest value is : {Maximum(number1, number2, number3)} ");
        }

        static double Maximum(double x, double y, double z)
        {
           
           return Math.Max(x, Math.Max(y, z));
        }


    }
}
