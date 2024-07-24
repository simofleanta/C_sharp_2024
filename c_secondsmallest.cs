using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 15, 20, 10, 4, 5 };
            int smallest = int.MaxValue;
            int secondsmallest = int.MaxValue;

            foreach (int number in num)
            {
                if (number < smallest)
                {
                    // Update second smallest first
                    secondsmallest = smallest;
                    // Update the smallest
                    smallest = number;
                }
                else
                {
                    if (number < secondsmallest && number!= smallest)
                    { 
                        secondsmallest= number;
                                            }
                }
                  
            }
            Console.WriteLine(smallest);
            Console.WriteLine(secondsmallest);
        }
    }
}
