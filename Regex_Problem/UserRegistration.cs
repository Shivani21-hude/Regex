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
                Console.WriteLine("-> Name  : " + firstname);
            }
            else
            {
                Console.WriteLine("Your entered name is in invalid pattern");
            }
        }
        //Uc2

        public static void ValidLastName()
        {
            Regex LastName = new Regex("^[A-Z]{1}[a-z]{3,}$");
            Console.Write("Enter your Last Name :");
            string lastname = Console.ReadLine();
            if (LastName.IsMatch(lastname))
            {
                Console.WriteLine("-> Name  : " + lastname);
            }
            else
            {
                Console.WriteLine("Your entered name is invalid pattern");
            }
        }
    }
}
