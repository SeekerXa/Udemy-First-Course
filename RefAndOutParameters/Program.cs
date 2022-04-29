using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 5;
            int z;
            Console.WriteLine($"Orginal value of y : {y}");
            Console.WriteLine($"Orginal value of z : uninitialized");
            SquareRef(ref y);
            SquareOut(out z);
            Console.WriteLine($"Value y after SquareRef : {y}");
            Console.WriteLine($"Value z after SquareRef : {z}");

            Square(y);
            Square(z);

            Console.WriteLine($"Value y after Square : {y}");
            Console.WriteLine($"Value z after Square : {z}"); ;

            ModifyProductsByReference();
        }

         static void SquareRef(ref int x)
        {
            
            x = x * x;
        }

        static void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }

        static void Square(int x )
        {
            x = x * x;

        }

        private static void ChangeByReference(ref Product itemRef)
        {
            // Change the address that is stored in the itemRef parameter.
            itemRef = new Product("Stapler", 99999);

            // You can change the value of one of the properties of
            // itemRef. The change happens to item in Main as well.
            itemRef.ItemID = 12345;
        }
        private static void ModifyProductsByReference()
        {
            // Declare an instance of Product and display its initial values.
            Product item = new Product("Fasteners", 54321);
            System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            // Pass the product instance to ChangeByReference.
            ChangeByReference(ref item);
            System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);
        }



    }



}
