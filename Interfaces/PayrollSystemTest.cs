using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PayrollSystemTest
    {

        //static void Main(string[] args)
        //{

        //    var salariedEmployee = new SalariedEmployee("John", "Smitch", "123-321-23-23", 800.00M);

        //    var hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-222-22-22", 16.75M, 40.0M);

        //    var commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-333-33-33", 10000.00M, 0.06M);

        //    var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Swager", "444-444-44-44", 5000.00M, 0.04M, 300.00M);


        //    Console.WriteLine("Employees processed individiually\n");
        //    Console.WriteLine(
        //        $"{salariedEmployee}\nearned: " +
        //        $"{salariedEmployee.Earnings():C}\n");

        //    Console.WriteLine(
        //        $"{hourlyEmployee}\nearned: " +
        //         $"{hourlyEmployee.Earnings():C}\n");

        //    Console.WriteLine(
        //       $"{commissionEmployee}\nearned: " +
        //        $"{commissionEmployee.Earnings():C}\n");

        //    Console.WriteLine(
        //       $"{basePlusCommissionEmployee}\nearned: " +
        //        $"{basePlusCommissionEmployee.Earnings():C}\n");


        //    var employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };

        //    Console.WriteLine("Employees processed polymorphically\n");

        //    foreach (var currentEmployee in employees)
        //    {
        //        Console.WriteLine(currentEmployee);
        //        if (currentEmployee is BasePlusCommissionEmployee)
        //        {
        //            var employee =(BasePlusCommissionEmployee)currentEmployee;
        //            employee.BaseSalary *= 1.10M;
        //            Console.WriteLine($"New base salary with 10% increase is: " +
        //                $"{employee.BaseSalary:C}");
        //        }  
        //        Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");

        //    }

        //    for (int i = 0; i < employees.Count; i++)
        //    {

        //        Console.WriteLine($"employees[{i}] is a{employees[i].GetType()}");

        //    }


        //}


    }
}
