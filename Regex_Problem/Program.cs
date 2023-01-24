using System;
namespace Regex_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ****  User Registration Process  ****\n");
            UserRegistration.ValidFirstName();
            UserRegistration.ValidLastName();   
            UserRegistration.ValidEmail();
            UserRegistration.ValidEmail();
            UserRegistration.MobileNumber();
            UserRegistration.Password();
        }
    }
}