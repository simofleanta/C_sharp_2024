using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {// define vars

            int minLength = 5;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\";
            int score = 0;


            //ask user to set a password 
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();


            //make sure the minimum of chars is 5
            if (password.Length >= minLength)
            {
                Console.WriteLine($"password is: {password} and it has {password.Length} letters");
            }
            else
            {
                Console.WriteLine($"pass too short, you only have {password.Length} letters");
            }

            //assume pass does not contain the required using set of bools

            bool containsDigits = false;
            bool containsSpecialChars = false;
            bool containslowercase = false;
            bool containsuppercase = false;

            // go through the password and check the type of chars contain the required
            foreach (char i in password)
            {
                containsDigits = digits.Contains(i) ? true : containsDigits;
                containsSpecialChars = specialChars.Contains(i) ? true : containsSpecialChars;
                containslowercase = lowercase.Contains(i)? true: containslowercase;
                containsuppercase=uppercase.Contains(i)? true:containsuppercase;          
            }

            if (containsDigits) score++;
            if (containsSpecialChars) score++;
            if (containslowercase) score++;
            if (containsuppercase) score++;
            Console.WriteLine(score == 4 ? "Strong" : "Weak");
            
          
        } 
    }
}


