using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;
            bool c = a<b;
            bool d = a>b;
            string result = (c && d) ? "True" : "F";
           

            switch(a)
            {
                case 21:
                    Console.WriteLine(result);
                    break;
                    default:
                    Console.WriteLine("Take me back to 20");
                    break;
            }

        }
    }
}
