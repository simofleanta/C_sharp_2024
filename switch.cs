using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int day =4;
            switch(day)
            {
                case 6:
         
                    Console.WriteLine("Wed");
                    break;
                    case 7:
                    Console.WriteLine("Thu");
                    break;
                    default:   //if you have day 6/7 it would not return anything so then by putting default it shoult take to the beginning day 4 and say nice weekend 
                    Console.WriteLine("Nice week");
                    break;              

                          

            }

         
        }
        
    }
}
