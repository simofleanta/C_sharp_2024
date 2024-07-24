using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        { //set array
            int[] numbers = { 15, 10, 24, 4, 5 };
            int small = numbers[0]; //assume 0 is the smallest
            // go through the list
            foreach (int number in numbers)
            { // if the assumpption is true 
                if (number < small)
                {//pass small to numbers
                    small = number;
                    
                }
                
            } //print it 
            Console.WriteLine(small);



        }
    }
}
