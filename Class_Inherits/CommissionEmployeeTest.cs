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
            var person1 = new CommissionEmployee("Patryk", "T....", "234243242", 5000, 0.01M);
            Console.WriteLine(person1);
        }
    }
}
