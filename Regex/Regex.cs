﻿using System;
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
        public Regex EmailRegex = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
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
    }
} 