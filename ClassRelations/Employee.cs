using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRelations
{
    internal class Employee
    {
        public string FisrtName { get; }
        public string LastName { get; }
        public Date BirthDate { get; }
        public Date HireDate { get; }

        public Employee(string firstName, string lastName, Date birthDate, Date hireDate)
        {
            FisrtName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            HireDate = hireDate;
        }
        public override string ToString() =>  $"{FisrtName} {LastName} \nHired: {HireDate} \nBirthday: {BirthDate} \n";

    }
}
