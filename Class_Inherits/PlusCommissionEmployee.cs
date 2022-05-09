using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inherits
{
    internal class PlusCommissionEmployee : CommissionEmployee
    {

        private decimal baseSalary;


        public PlusCommissionEmployee(string firstName, string lastName, string sicialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
            : base(firstName, lastName, sicialSecurityNumber, grossSales, commissionRate)
        {
             BaseSalary = baseSalary;
        } 
        


        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(BaseSalary)} must be > 0 ");
                }
                baseSalary = value;
            }
        }



        public decimal Earnings() => BaseSalary + base.Earnings();
        public override string ToString()
        {
            return $"Commission employee: {FirstName} {LastName}\n" +
                $"Social security number: {SocialSecurityNumber}\n" +
                $"gross Sales: {grossSales:C}\n" +
                $"commision rate: {commisionRate:F2}\n" +
                $"base salary: {baseSalary:C}";





        }
    }
}
