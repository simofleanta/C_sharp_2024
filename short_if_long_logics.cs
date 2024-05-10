using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_if_long_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;
            bool c = a > b;
            bool d = a < b; //t
            bool e = a != b; //t
            bool f = b == a; //f

            string result = (d||e && e||f) ? "True" : "False";
            Console.WriteLine(result);
        }
    }
}
