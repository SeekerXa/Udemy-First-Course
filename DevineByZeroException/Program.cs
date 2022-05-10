using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevineByZeroException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var state = true;

            do
            {
                try
                {


                    Console.Write("Please enter an intege: ");
                    var i = int.Parse(Console.ReadLine());
                    Console.Write("Please enter an intege: ");
                    var y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{i} / {y} = {i / y}");
                    state = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                    Console.WriteLine("yoy must enter an integers. Try Again ! ");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine(divideByZeroException.Message);
                    Console.WriteLine("yoy must enter an integers != 0. Try Again ! ");
                }

            }
            while (state);




        }
    }
}
