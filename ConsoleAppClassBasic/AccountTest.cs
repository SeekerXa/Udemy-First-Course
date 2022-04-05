using System;

namespace ConsoleAppClassBasic
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is : {myAccount.Name}");

            Console.Write("Enter the name: ");
            string theName = Console.ReadLine();
            myAccount.Name = theName;

            Console.WriteLine($"myAccount name is : {myAccount.Name}");
        }
    }
}
                                                                                                                          