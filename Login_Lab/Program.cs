using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            while (runP == true)
            {
                string userEmail = validEmail();
                string userPassword = validPassword();
                runP = Continue();
            }
        }
        public static string validEmail()
        {
            List<string> validEmails = new List<string>();
            bool validResponse = true;
            string userEmail = "";
            while (validResponse)
            {
                Console.WriteLine("Welcome, Please enter your email address to sign-up for a premium account!!!!");
                userEmail = Console.ReadLine();

                if (!Regex.IsMatch(userEmail, @"^[A-z0-9]{3,}(@)[A-z0-9]{3,}(.+)[A-z0-9]{2,3}$"))
                {
                    Console.WriteLine("I'm sorry, you did not enter a valid email address, please try again");
                }
                else
                {
                    Console.WriteLine("Congrats, you entered a valid email address:");
                    validEmails.Add(userEmail);
                    break;
                }
            }
            return userEmail;
        }
        public static string validPassword()
        {
            List<string> validPasswords = new List<string>();
            bool responseValid = true;
            string uPassword = "";
            while (responseValid)
            {
                Console.WriteLine("Password rules\n1) First character is a capitalized letter\n2)Second character must be a number\n3)Password must be at least 5 characters in length\nPlease enter your password:");
                uPassword = Console.ReadLine();

                if (!Regex.IsMatch(uPassword, @"^[A-Z]+[0-9]+[A-z0-9]{3,}$"))
                {
                    Console.WriteLine("I'm sorry, you did not enter a valid password, please try again");
                }
                else
                {
                    Console.WriteLine("Congrats, you entered a valid password");
                    validPasswords.Add(uPassword);
                    break;
                }
            }
            return uPassword;
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool doAgain;
            if (input == "y")
            {
                doAgain = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                doAgain = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                doAgain = Continue();
            }
            return doAgain;
        }
    }
}
