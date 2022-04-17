using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random randomNumbers = new Random();
            int frequency1 = 0;
            int frequency2 = 0;
            int frequency3 = 0;
            int frequency4 = 0;
            int frequency5 = 0;
            int frequency6 = 0;

           for (int i = 1; i < 60000000; i++)
            {
                int face = randomNumbers.Next(1,7);
                switch(face)
                {
                    case 1:
                        ++frequency1;
                        break;
                    case 2:
                        ++frequency2;
                        break;
                    case 3:
                        ++frequency3;
                        break;
                    case 4:
                        ++frequency4;
                        break;
                    case 5:
                        ++frequency5;
                        break;
                    case 6:
                        ++frequency6;
                        break;

                }
            }

            Console.WriteLine("1: " + frequency1);
            Console.WriteLine("2: " + frequency2);
            Console.WriteLine("3: " + frequency3);     
            Console.WriteLine("4: " + frequency4);
            Console.WriteLine("5: " + frequency5);
            Console.WriteLine("6: " + frequency6);
                
                

        }
    }
}
