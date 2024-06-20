using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {// define vars
            int minLength = 5;
            string uppercase = "";
            string lowercase = "";
            string digits = "";
            string specialChars = "";
            //ask user to input pass using the above criteria
            Console.WriteLine("Pass: ");
            Console.ReadLine();
            //starting point to scores
            int score = 0;
            // check if that is strong 
            if (score <= 7)
            {
                Console.WriteLine("strong");
            }
            else 
            { //if not > 5, check length of pass 1 set pass 2 print length
                string pass = "@Cats3*";
                int len = pass.Length;
                Console.WriteLine("pass length is: "+len);
            }
            



        }
    }
}
