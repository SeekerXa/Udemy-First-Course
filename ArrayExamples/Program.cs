using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 0, 0, 0, 0, 5, 6, 4, 2, 3 };
            Console.WriteLine("grade distribution: ");

            for (var counter = 0; counter < array.Length; counter++)
            {
                if (counter == 10) 
                    Console.Write($"  {100:D2}:");
                else 
                    Console.Write($"{counter * 10:D2}-{counter * 10 + 9:D2}:");

                for(var stars =0; stars < array[counter]; stars++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
                                                                    
        }
    }
}
