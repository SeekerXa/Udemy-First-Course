
namespace Polymorphism
{
    public abstract class Employee  : IPayable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }


        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\n";
        }

        public abstract decimal Earnings();                                      

        public decimal GetPaymentAmount()
        {
            return Earnings();
        }
    }
}
