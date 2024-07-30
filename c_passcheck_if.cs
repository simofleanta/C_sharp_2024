using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Define the criteria
            int minLength = 5;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\";
            int score = 0;

            // Ask user to set a password 
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            // Check minimum length requirement
            if (password.Length >= minLength)
            {
                Console.WriteLine($"Password is: {password} and it has {password.Length} characters.");
            }
            else
            {
                Console.WriteLine($"Password too short, you only have {password.Length} characters.");
            }

            // Assume password does not contain the required characters
            bool containsDigits = false;
            bool containsSpecialChars = false;
            bool containsLowercase = false;
            bool containsUppercase = false;

            // Check the type of characters in the password
            foreach (char i in password)
            {
                if (digits.Contains(i))
                    containsDigits = true;
                
                if (specialChars.Contains(i))
                    containsSpecialChars = true;

                if (uppercase.Contains(i))
                    containsUppercase = true;

                if (lowercase.Contains(i))
                    containsLowercase = true;
            }

            // Calculate the score based on the types of characters found
            if (containsDigits) score++;               // If digits are found, increment score by 1
            if (containsSpecialChars) score++;          // If special characters are found, increment score by 1
            if (containsLowercase) score++;             // If lowercase letters are found, increment score by 1
            if (containsUppercase) score++;             // If uppercase letters are found, increment score by 1

            // Determine password strength
            Console.WriteLine(score == 4 ? "Strong" : "Weak");  // If score is 4, print "Strong", otherwise print "Weak"
        }
    }
}
