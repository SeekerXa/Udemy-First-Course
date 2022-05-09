using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inherits
{
    internal class CommissionEmployeeTest
    {

        static void Main(string[] args)
        {
            var person1 = new PlusCommissionEmployee("Patryk", "T....", "234243242", 5000.00M, 0.01M,300.00M);
            Console.WriteLine(person1);
            Console.WriteLine(person1.Earnings());

            Console.WriteLine();    

            person1.GrossSales = 4000.00M;
            person1.CommisionRate = 0.1M;
            Console.WriteLine(person1);
            Console.WriteLine(person1.Earnings());

        }
    }
}
