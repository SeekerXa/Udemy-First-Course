using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructOverload
{
    internal class Time2Test
    {
        static void Main(string[] args)
        {
            var t1 = new Time2();
            var t2 = new Time2(2);
            var t3 = new Time2(21, 34);
            var t4 = new Time2(12, 25, 42);
            var t5 = new Time2(t4);



            Console.WriteLine("\nConstructed with t1: All arguments defaulted");
            Console.WriteLine(t1.ToUniwersalString());
            Console.WriteLine(t1.ToString());


            Console.WriteLine("\nConstructed with t2: minute and second defaulted");
            Console.WriteLine(t2.ToUniwersalString());
            Console.WriteLine(t2.ToString());


            Console.WriteLine("\nConstructed with t3: second defaulted");
            Console.WriteLine(t3.ToUniwersalString());
            Console.WriteLine(t3.ToString());


            Console.WriteLine("\nConstructed with t4: All arguments choosen");
            Console.WriteLine(t4.ToUniwersalString());
            Console.WriteLine(t4.ToString());

            Console.WriteLine("\nConstructed with t5: by other obiect Time2");
            Console.WriteLine(t5.ToUniwersalString());
            Console.WriteLine(t5.ToString());

            try
            {
               var t6 = new Time2(63, 11, 2);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while declaring t6\nGoodBaY! ");
            }
         
        }
    }
}
