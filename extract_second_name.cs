/* 1.The designer of C# is "Anders Hejlsberg". His first name is nice, but we want to print the second name alone.

First, find the index of the space (" ") in the string designer and store it in a variable indexOfSpace.

You’ll need to use the IndexOf() method.

2.
Use Substring() and the variable indexOfSpace to get the second name. Store the returned value in a variable secondName.

Print secondName to the console.*/

using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";
  int indexOfSpace = designer.IndexOf(" ");
      
      string secondName = designer.Substring(indexOfSpace);
      
      Console.WriteLine(secondName);
    }
  }
}
