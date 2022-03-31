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

        }
    }
}