using System;
using System.ComponentModel;
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

            //go through each char and check it has all the above variables
            //set ranks the pass containing all initialized chars.

            for (int i = 0; i < password.Length; i++)
            {
                if (password.Contains(digits) && password.Contains(specialChars) && password.Contains(lowercase) && password.Contains(uppercase)) //@kazachusS22#
                {
                    Console.WriteLine("Strong");
                }
                else if (!password.Contains(digits))//password.Contains(uppercase),password.Contains(specialChars)) //
                {
                    Console.WriteLine("Medium...try again");
                }

                else
                {
                    Console.WriteLine("weak");
                }             
             }


          ps:
          /*
          set the password min length
          set the variables          
          go through each caharacter of the password
          set conditions with points of strength of password depending if has all chars !Qa2
          */
