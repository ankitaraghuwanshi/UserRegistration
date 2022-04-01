using System;
namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserRegexTest userRegexTest = new UserRegexTest();

            int option = 0;
            do
            {
                Console.WriteLine("select your choice");
                Console.WriteLine("1 for FirstName");
                Console.WriteLine("2 for LaststName");
                Console.WriteLine("3 for Email");
                Console.WriteLine("4 for MobileNumber");
                Console.WriteLine("5 for Password");
               
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First name");
                        string FirstName = Console.ReadLine();
                        userRegexTest.validFirstName(FirstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last name");
                        string LastName = Console.ReadLine();
                        userRegexTest.validLastName(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        userRegexTest.validEmail(Email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile Number");
                        string MobileNo = Console.ReadLine();
                        userRegexTest.validMobileNo(MobileNo);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string Password = Console.ReadLine();
                        userRegexTest.validPassword(Password);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (option != 5);
        }
    }
}      
