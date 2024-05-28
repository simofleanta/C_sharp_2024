using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App
{
     class Program
    {
        static void Main(string[] args)
        {
            Travel(country1: "Norway", country2: "Portugal");
            Visits(numberofvisits : 1); //to specify the number of 

            
        }
        static void Travel(string country1, string country2)
        {
            Console.WriteLine($"It was nice in  {country2} and {country2}!");
            
        }

        static void Visits(int numberofvisits)
        {
            Console.WriteLine($"I visited {numberofvisits} time 2 countries");
        }
       

       }
}
