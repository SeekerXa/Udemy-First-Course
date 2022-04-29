using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExeption
{
    internal class ArrayExeption
    {
        static void Main(string[] args)
        {
            int[] responses = { 1, 2, 3, 4, 5, 2, 3, 5, 1, 4, 3, 56, 2, 34, 5, 2, 3, 2, 3 };
            var frequency = new int[6];

            for(var answer = 0; answer < responses.Length; answer++)
            {
                try
                {
                    ++frequency[responses[answer]];
                }
                catch(IndexOutOfRangeException ex)
                {
                      Console.WriteLine(ex.Message);
                    Console.WriteLine($"   responses[{answer}]={responses[answer]}\n");
                }
            }

        

            for(var rating = 1; rating < frequency.Length; rating++)    
            {
                
                Console.WriteLine($"Frequency of responses {rating } is : {frequency[rating]}\n");

            }
             Console.WriteLine();
        }
    }
}
