using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegexTest
    {
        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex EmailRegex = new Regex("^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNoRegex = new Regex("^[0-9]{2}[ ][5-9]{1}[0-9]{9}$");
        public Regex PasswordRegex = new Regex("^[a-zA-Z0-9]{8,}$");
        public Regex PasswordRegex_2 = new Regex("^(?=.*[A-Z])[a-zA-Z0-9]{8,}$");
        public void validFirstName(string FirstName)
        {
            Console.WriteLine("\nFirst Name:" + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("First name is valid");
            }
            else
            {
                Console.WriteLine("First name is invalid");
            }
        }
        public void validLastName(string LastName)
        {

            if (FirstNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("{0} Last Name is valid", LastName);
            }
            else
            {
                Console.WriteLine("{0} Last Name is not valid", LastName);
            }
        }
        public void validEmail(string Email)
        {

            if (EmailRegex.IsMatch(Email))
            {
                Console.WriteLine(" Email is valid", Email);
            }
            else
            {
                Console.WriteLine(" Email is not valid", Email);
            }
        }
        public void validMobileNo(string MobileNo)
        {

            if (MobileNoRegex.IsMatch(MobileNo))
            {
                Console.WriteLine(" Mobile Number is valid", MobileNo);
            }
            else
            {
                Console.WriteLine(" Mobile Number is not valid", MobileNo);
            }
        }
        public void validPassword(string Password)
        {

            if (PasswordRegex.IsMatch(Password))
            {
                Console.WriteLine(" Password is valid", Password);
            }
            else
            {
                Console.WriteLine(" Password is not valid", Password);
            }
        }
        public void validPassword_2(string Password_2)
        {

            if (PasswordRegex_2.IsMatch(Password_2))
            {
                Console.WriteLine(" Password is valid", Password_2);
            }
            else
            {
                Console.WriteLine(" Password is not valid", Password_2);
            }
        }
    }
}