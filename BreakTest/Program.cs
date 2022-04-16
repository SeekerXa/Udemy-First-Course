using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 1; count <= 10; count++)
            {
                if (count == 5)
                {
                    break;
                }         
                Console.WriteLine(count);

            }
            Console.WriteLine  ($"\n Broke out of loop at count = {count} ");

            count = 1;
            for (count = 1; count <= 10; count++)
            {
                if (count == 5)
                {
                    continue;
                }
                Console.WriteLine(count);

            }
            Console.WriteLine($"\n used continue to skip displaying 5 ");

        }

    }
}
