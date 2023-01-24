using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problem
{
    internal class UserRegistration
    {
        //Uc1
        public static void ValidFirstName()
        {
            Regex FirstName = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.Write("Enter your first Name :");
            string firstname = Console.ReadLine();
            if (FirstName.IsMatch(firstname))
            {
                Console.WriteLine("-> FirstName  : " + firstname);
            }
            else
            {
                Console.WriteLine("Your entered name is in invalid pattern");
            }
        }
        //Uc2

        public static void ValidLastName()
        {
            Regex LastName = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.Write("Enter your Last Name :");
            string lastname = Console.ReadLine();
            if (LastName.IsMatch(lastname))
            {
                Console.WriteLine("-> LastName  : " + lastname);
            }
            else
            {
                Console.WriteLine("Your entered name is invalid pattern");
            }
        }
        //Uc3

        public static void ValidEmail()
        {
            Regex Email = new Regex("^[a-z]{1,}[0-9]{0,}[@][a-z]{1,}[.][a-z]{1,3}[.]{0,}[a-z]{0,2}$");
            Console.Write("Enter your E-mail :");
            string email = Console.ReadLine();
            if (Email.IsMatch(email))
            {
                Console.WriteLine("-> Email  : " + email);
            }
            else
            {
                Console.WriteLine("Your entered Email is invalid ");
            }
        }
        //Uc4

        public static void MobileNumber()
        {
            Regex Mo_no = new Regex("^[0-9]{10}$");
            Console.Write("Enter your Mobile number :");
            string mobilenum = Console.ReadLine();
            if (Mo_no.IsMatch(mobilenum))
            {
                Console.WriteLine("-> MobileNumber  : " + mobilenum);
            }
            else
            {
                Console.WriteLine("Your entered Mobile number is invalid ");
            }
        }
        //Uc5

        public static void Password()
        {
            Regex Password = new Regex("^[A-Z]{1,}[a-z]{7,}$");
            Console.Write("Enter Password :");
            string password = Console.ReadLine();
            if (Password.IsMatch(password))
            {
                Console.WriteLine("-> Password : " + password);
            }
            else
            {
                Console.WriteLine("Should have first upeer case character and have minimum 8 characters ");
            }
        }
    }
}
