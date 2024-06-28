using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forwach_loop    //program that displays days of the week use foreach for strings 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            foreach (string i in days) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}


/* code steps:                                   | /* programatic/logical thinking for program that runs days of the week
* pass variable                                  |  * perform foreach loop 
* perform foreach loop                           |  * if you want to extract a day from the list/array use if to trigguer true so if day == Tue then print Tuesday else break 
* print with console writeline                   |
*/
