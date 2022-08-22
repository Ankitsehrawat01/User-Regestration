using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class User
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter First Name");
            string data = Console.ReadLine();
            string namepattern = "^[A-Z]{1}[A-Za-z]{3,}";
            Regex regexobj = new Regex(namepattern);
            if(regexobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is not valid");
                Console.ResetColor();
            }
        }
        public static void ValidLastName()
        {
            Console.WriteLine("Enter First Name");
            string data = Console.ReadLine();
            string namepattern = "^[A-Z]{1}[A-Za-z]{3,}";
            Regex regexobj = new Regex(namepattern);
            if (regexobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is not valid");
                Console.ResetColor();
            }
        }
        public static void ValidEmail()
        {
            Console.WriteLine("Enter First Name");
            string data = Console.ReadLine();
            string namepattern = "[a-zA-Z]+[.+-]+[0-9a-zA-Z]+[@][a-zA-Z]+[.]+[a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            Regex regexobj = new Regex(namepattern);
            if (regexobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is not valid");
                Console.ResetColor();
            }
        }
    }
}
