using System;
using System.Linq;

namespace CharacterTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example character array
            char[] test = { 'a', '4', '2', 's', 'b' };

            // Call the function to test types of characters
            TestCharacterTypes(test);
        }

        // Function to test types of characters
        static void TestCharacterTypes(char[] characters)
        {
            // Criteria definition
            string digits = "0123456789";
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\";

            // Initialize counters or flags
            bool containsDigits = false;
            bool containsLetters = false;
            bool containsSpecialChars = false;

            // Iterate through the array
            foreach (char c in characters)
            {
                if (digits.Contains(c))
                {
                    containsDigits = true;
                    Console.WriteLine($"Digit found: {c}");
                }

                if (letters.Contains(c))
                {
                    containsLetters = true;
                    Console.WriteLine($"Letter found: {c}");
                }

                if (specialChars.Contains(c))
                {
                    containsSpecialChars = true;
                    Console.WriteLine($"Special character found: {c}");
                }
            }

            // Output the results
            Console.WriteLine("Contains Digits: " + containsDigits);
            Console.WriteLine("Contains Letters: " + containsLetters);
            Console.WriteLine("Contains Special Characters: " + containsSpecialChars);
        }
    }
}
