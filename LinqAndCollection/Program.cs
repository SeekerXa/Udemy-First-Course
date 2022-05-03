using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var items = new List<string>();
            //items.Add("aQua");
            //items.Add("RusT");
            //items.Add("yElLow");
            //items.Add("rEd");
            var items = new List<string> { "aQua", "RusT", "yElLow", "rEd" };

            Console.WriteLine($"Starting value of list : ");
            foreach (var i in items)
                Console.WriteLine(i);

            Console.WriteLine();

            var startsWithR = from item in items
                              let uppercaseString = item.ToUpper()
                              where uppercaseString.StartsWith("R")
                              orderby uppercaseString
                              select uppercaseString;
            Console.WriteLine($"value after uppercase : ");
            foreach (var i in startsWithR)
                Console.WriteLine(i);

            items.Add("rUby");
            items.Add("SaFfRon"); 

            Console.WriteLine();

            Console.WriteLine($"Items scontains : ");
            foreach (var i in items)
                Console.WriteLine(i);

            Console.WriteLine();

            foreach (var i in startsWithR)
                Console.WriteLine(i);

        }
    }
}
