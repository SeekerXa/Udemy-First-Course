
namespace Polymorphism
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }


        public Employee(string fisrtName, string lastName, string socialSecurityNumber)
        {
            FirstName = fisrtName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString()
        {
            return $"[{FirstName} {LastName}\n";
        }

        public abstract decimal Earnings();                                      

    }
}
