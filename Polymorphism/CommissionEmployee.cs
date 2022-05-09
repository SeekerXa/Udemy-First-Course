using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class CommissionEmployee : Employee
    {

        public decimal grossSales;
        public decimal commissionRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }


        public decimal GrossSales
        {
            get { return grossSales; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be >0");
                }
                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get { return commissionRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be >0");
                }
                commissionRate = value;
            }
        }


        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return
                $"commision emplote: {base.ToString()}" +
                $"gross sales: {GrossSales:C}" +
                $"commision rate: {CommissionRate:F2}";
        }








    }
}
