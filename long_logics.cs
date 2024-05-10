using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if___logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;
            bool c = a > b;
            bool d = a < b;
            bool e = a != b;
            bool f = b == a;
            if (a > b && a != b) // && retunr false True ===> false
            {
                Console.WriteLine("Good Morning");

            }
            else if (a<b || b==a) // true false unde  || reutns true daca aveam and ma ducea la ultimul statement 
            {
                Console.WriteLine("a<b");

            }
            else
            {
                Console.WriteLine("None of them True");
            }
        }
    }
}
