using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 15, 10, 24, 4, 5 };
            int s = numbers.Min();
            Console.WriteLine("the smalest is :"+ s);
        }
    }
}
