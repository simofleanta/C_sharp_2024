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
