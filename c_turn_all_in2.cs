using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        { //task, make these statuses =2 
            //first print them without 2
            //print them all equal 2 
            //pseudocode: make an array, use for loop to see what are those without 2 and then print them all =2 
            int [] status = { 1, 2, 2, 2, 3, 3, 1, 1, 4, 2, 3 };
            for (int i = 0; i < status.Length; i++)
            {


                if (status[i] != 2)
                {
                    // Console.WriteLine(status[i] + "");
                    Console.WriteLine(status[i] = 2);

                }
                else 
                {
                    Console.WriteLine( status[i]);
                }
              
               
            }
        }
    }
}
