using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family(child1: "Sam", child2: "John");

        }
        static int fam_age (int x)
        { 
            return x + 10; 
        }
        static void Family(string child1, string child2) 
        {
            Console.WriteLine($"The youngest one is: {child1}");
            Console.WriteLine("The eldest one is:",child1);
            Console.WriteLine("The eldest one is:" + child2); //if there's no interpolation like above, best to plut plus 
            Console.WriteLine($"all together they are: {fam_age(5)}");
        }
    }
}

