using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRelations
{
    internal class EmployeeTest
    {
        static void Main(string[] args)
        {
            var birthDay = new Date(24, 7, 1949);
            var hireDate = new Date(12, 3, 1988);
            var employee = new Employee("Bob", "Swager", birthDay, hireDate);
            Console.WriteLine(employee);
        }
    }
}
