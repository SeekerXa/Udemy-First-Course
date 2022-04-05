using System;

namespace ConsoleAppClassBasic
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Patrk");
            Account account2 = new Account("afsdfsaf");

            Console.WriteLine($"Acc1 name is : {account1.Name}");

            Console.WriteLine($"Acc2 name is : {account2.Name}");
        }
    }
}
                                                                                                                          