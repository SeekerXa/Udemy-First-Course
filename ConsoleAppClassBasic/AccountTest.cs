using System;

namespace ConsoleAppClassBasic
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Patrk",50.00m);
            Account account2 = new Account("afsdfsaf",-7.42m);

            Console.WriteLine($"{account1.Name}'s balance is: {account1.Balance:C} ");

            Console.WriteLine($"{account2.Name}'s balance is: {account2.Balance:C} ");

            Console.Write("\nEnter depopsit amount for account1: ");
            decimal depostiAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {depostiAmount:C} to account1 balance\n");
            account1.Deposit(depostiAmount);

            Console.WriteLine($"{account1.Name}'s balance is: {account1.Balance} ");


            Console.Write("\nEnter depopsit amount for account2: ");
            depostiAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {depostiAmount:C} to account2 balance\n");
            account2.Deposit(depostiAmount);

            Console.WriteLine($"{account2.Name}'s balance is: {account2.Balance} ");
        }
    }
}
                                                                                                                          