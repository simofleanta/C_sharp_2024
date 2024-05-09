/*1.
In this exercise, we’re going to use built-in methods to determine which number is smaller between the square roots of two different numbers.

First, find the square root of numberOne and round the answer down so it doesn’t have a decimal. Save this value to a new double variable numberOneSqrt.

using System;    round e rounding up and  floor rounding down*/

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
double numberOneSqrt=Math.Round(Math.Sqrt(numberOne));
Console.WriteLine(numberOneSqrt);

/*Inside of a Console.WriteLine() statement, use a built-in method that returns the smallest of two numbers, using the values numberOneSqrt and numberTwoSqrt.

Which value gets printed to the console? 

2.
Do the same process to variable numberTwo and save this value to a new double variable numberTwoSqrt. */


      using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
double numberOneSqrt=Math.Floor(Math.Sqrt(numberOne));
Console.WriteLine(numberOneSqrt);



      // Use built-in methods and save to variable 
double numberTwoSqrt = Math.Floor(Math.Sqrt(numberTwo));
Console.WriteLine(numberTwoSqrt);

      // Print the lowest number
      
      Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt));


    }
  }
}


      /* Did NaN get printed to the console? NaN stands for “Not a Number” in C#. So what happened?

The built-in method Math.Sqrt() can only take a positive number as a value, but the value of numberTwo is negative. But we can fix it. The method Math.Abs() will find the absolute value of a number. A good reminder that when we use built-in methods, to check the documentation so we know how to use them!

Inside of the Math.Sqrt() method, add the Math.Abs() method, so it takes the variable numberTwo as a value. Re-run the code and see what gets printed to the console this time! */

using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
double numberOneSqrt=Math.Floor(Math.Sqrt(numberOne));
Console.WriteLine(numberOneSqrt);



      // Use built-in methods and save to variable 
double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
Console.WriteLine(numberTwoSqrt);

      // Print the lowest number
      
      Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt));


    }
  }
}
