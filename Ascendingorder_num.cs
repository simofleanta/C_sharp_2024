using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 15, 20, 10, 4, 5 };            
            Array.Sort(num); //ascending sorting 
           
           
            foreach (int number in num)
            {
                Console.Write(number + " ");
            }
          
        }
    }
}
