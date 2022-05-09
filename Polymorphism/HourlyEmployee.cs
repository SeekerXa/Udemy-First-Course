using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class HourlyEmployee : Employee
    {
        private decimal hourlyWage;
        private decimal hoursWorked;

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, decimal hourlyWage, decimal hoursWorked)
            : base(firstName, lastName, socialSecurityNumber)
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }
                                                                                                                       


        public decimal HourlyWage
        {
            get { return hourlyWage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HourlyWage)} must be >=0");
                }
                hourlyWage = value;
            }

        }
        public decimal HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value < 0 || value > 168)
                {

                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HoursWorked)} must be >=0 and <= 168");
                }
                hoursWorked = value;
            }

        }

        public override decimal Earnings()
        {
            if (HoursWorked <= 40)
            {
                return HourlyWage * HoursWorked;
            }
            else
                return (40 * HourlyWage) + ((HoursWorked - 40) * HourlyWage * 1.5M);
        }

        public override string ToString()
        {
            return $"hourly employee: {base.ToString()}" +
                $"hourly wage: {HourlyWage:C}" +
                $"hours worked: {HoursWorked:F2}";
        }


    }

   


}

