using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 0;
            double intrestProcent= 0;
            int yearsOfInvest= 0;
            

            Console.Write("Enter your Balance: ");
            principal = decimal.Parse(Console.ReadLine());

            Console.Write("\nEnter account interest(%): ");
            intrestProcent = double.Parse(Console.ReadLine());
            intrestProcent /= 100;
            Console.Write("\nEnter deposit time(Years): ");
            yearsOfInvest = int.Parse(Console.ReadLine());

             for(int i =1; i<=yearsOfInvest; i++)
            {
                 decimal amount = principal *
                    ((decimal)Math.Pow(1.0 + intrestProcent,i));
                Console.WriteLine($"{i,4}{amount,20:C}");
            }




            //Console.WriteLine($"Final balance is: {}");
        }
    }
}
