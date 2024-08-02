using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int result = method_multiply(2, 3);
            Console.WriteLine(result);
        }

        static int method_multiply(int a, int b)
        {
            return a * b;
        }


    }
}
