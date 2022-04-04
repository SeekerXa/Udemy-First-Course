using System;

namespace CreatingConsoleApp
{
    internal class Welcome1
    {
        

        static void Main(string[] args)
        {
            
            string person = "Paul";
            Console.WriteLine($"Welcome to C# course, {person}.");

            //NumberAddition();
            OperatorsAndIF();

        }







        static void NumberAddition()
        {
            int number1;
            int number2;
            int sum;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Eneter first integer: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            number1 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Eneter secound integer: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            number2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            sum = number1 + number2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Sum = {sum} \n");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void OperatorsAndIF()
        {
            int number1;
            int number2;
            

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Eneter first integer: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            number1 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Eneter secound integer: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            number2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            

            Console.ForegroundColor = ConsoleColor.Magenta;
            if (number1 == number2) Console.WriteLine($"{number1} == {number2}");
            if (number1 != number2) Console.WriteLine($"{number1} != {number2}");
            if (number1 < number2) Console.WriteLine($"{number1} < {number2}");
            if (number1 > number2) Console.WriteLine($"{number1} > {number2}");
            if (number1 <= number2) Console.WriteLine($"{number1} <= {number2}");
            if (number1 >= number2) Console.WriteLine($"{number1} >= {number2}");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
