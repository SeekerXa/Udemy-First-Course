﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BasePlusCommissionEmployee : CommissionEmployee
    {

        private decimal baseSalary;
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
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
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be >0");
                }
                baseSalary = value;
            }
        }

        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }

        public override string ToString()
        {
            return $"Worker {base.ToString()}" +
                $"base Salary: {baseSalary:C}";
        }

    }
}
