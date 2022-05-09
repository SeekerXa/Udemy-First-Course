using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class SalariedEmployee: Employee
    {
        private decimal weeklySalary;
        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber)
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set
            {
                if (value < 0)
                {
                   throw new ArgumentOutOfRangeException(nameof(value),value,$"{nameof(WeeklySalary)} need to be >= 0");
                }
                weeklySalary = value;   
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return $"salaried employee: {base.ToString()}" +
                $"weekly salary: {WeeklySalary:C} ";
        }
    }
}
