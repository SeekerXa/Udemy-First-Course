using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class PayableInterfaceTest
    {

       static void Main(string[] args)
        {
            var payableObjects = new List<IPayable>()
            {
               new Invoice("01234","seat",2,375.00M),
               new Invoice("2313","dsad",4,79.95M),
               new SalariedEmployee("John","Sat","123321321321",800.00M),
               new SalariedEmployee("Lisa","Tip","1231313@#",1200.00M),
            };

            foreach(var payable in payableObjects)
            {
                Console.WriteLine(payable);
                Console.WriteLine($"payment due: {payable.GetPaymentAmount():C}\n");
            }

        }

    }
}
