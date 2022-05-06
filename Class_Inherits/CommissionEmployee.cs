using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inherits
{
    internal class CommissionEmployee : Object
    {
        public String FirstName { get; }
        public String LastName { get; }
        public string SocialSecurityNumber { get; }
        private decimal grossSales;
        private decimal commisionRate;

        public CommissionEmployee(string firstName, string lastName, string sicialSecurityNumber, decimal grossSales, decimal commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = sicialSecurityNumber;
            GrossSales = grossSales;
            CommisionRate = commissionRate;
        }

        public decimal GrossSales
        {
            get { return grossSales; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }

        }

        public decimal CommisionRate
        {
            get { return commisionRate; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(CommisionRate)} must be > 0 and < 1 ");
                }
                commisionRate = value;
            }
        }

        public decimal Earnings() => commisionRate * grossSales;
        public override string ToString()
        {
            return $"Commission employee: {FirstName} {LastName}\n" +
                $"Social security number: {SocialSecurityNumber}\n" +
                $"gross Sales: {grossSales:C}\n" +
                $"commision rate: {commisionRate:F2}";


        }

    }
}
