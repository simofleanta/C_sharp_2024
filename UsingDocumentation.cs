/*We introduced you to a few common built-in methods, but there are many more out there! Now’s a good time to practice your documentation search skills. Take a moment to look up the following built-in methods to understand their usage:

Math.Pow()
Math.Max()
Math.Ceiling() */

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {

      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne,numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Round(numberOne));

      // Find the larger number between numberOne and numberTwo
     
 Console.WriteLine(Math.Ceiling(numberOne));

   Console.WriteLine(Math.Ceiling(Math.Max(numberOne,numberTwo)));


    }
  }
}
