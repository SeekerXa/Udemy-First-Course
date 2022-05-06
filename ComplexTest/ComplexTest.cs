using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTest
{
    internal class ComplexTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a real part of complex x");
            double realPart = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the imaginary part od complex number x:");
            double imaginaryPart = double.Parse(Console.ReadLine());
            var x = new ComplexNumber(realPart, imaginaryPart);

            Console.WriteLine("Enter a real part of complex x");
            realPart = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the imaginary part od complex number x:");
            imaginaryPart = double.Parse(Console.ReadLine());
            var y = new ComplexNumber(realPart, imaginaryPart);

     
            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");

        }
    }
}
