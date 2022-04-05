using System;

namespace ConsoleAppClassBasic
{
    internal class Account
    {
        public string Name { get; set; }
        private string name;

        public Account(string accountName)
        {
            Name = accountName;
        }
 
    }
}
