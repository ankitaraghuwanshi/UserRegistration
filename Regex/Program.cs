using System;
namespace UserRegistration
{
    class UserRegistration
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First name");
            string Firstname = Console.ReadLine();
            UserRegexTest userRegexTest = new UserRegexTest();
            string FirstName = Firstname;
            userRegexTest.validFirstName(FirstName);

            Console.WriteLine("Enter Last name");
            string LastName = Console.ReadLine();
            userRegexTest.validLastName(LastName);

            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            userRegexTest.validEmail(Email);


        }
    }        
}