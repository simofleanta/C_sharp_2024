using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test_object
{
    internal class Program
    {
               
        static void Main(string[] args)
        {
            var myanimal = new { Name = "Wolf" };
            Console.WriteLine(myanimal);

        }
    }
}
