using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp66
{
    internal class Program
    {
        static void Main(string[] args)
        { //test if there are chars, digits, letters and if there are display them
          // set vars and the array
          //set the criteria 
          //assume they're all false 
          //go through the array and check if true 
          //display the chars 
            char[] vars = { 'a', 'b', '6', '2', '3', 'd','e' };

          string special = "#$";
            string digits = "1234327654";
            string letters = "abcfghjle";
            bool x_digits = false;
            bool y_letters = false;
            bool special_char = false;        
              

            foreach (char i in vars)
            {

                if (special.Contains(i))
                {
                    special_char = true;
                    Console.WriteLine(i);
                }
                if (digits.Contains(i))
                {
                    x_digits = true;
                    Console.WriteLine(i);
                }
                if (letters.Contains(i))
                {
                    y_letters = true;
                    Console.WriteLine(i);

                }



            }
        }
    }
}
