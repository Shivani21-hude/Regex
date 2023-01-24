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
    }
}
