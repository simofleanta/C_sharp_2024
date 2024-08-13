using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class fruits
    {
        public string name;
        public string description; 
    static void Main(string[] args)
    {
        fruits f = new fruits();
            f.name = "mango";
            f.description = "red";
        Console.WriteLine($" fruit is {f.name} and it is {f.description}");

      }
    }
}
