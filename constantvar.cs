// Assigning a constant to variable
using System;

namespace Operators
{
	class AssignmentOperators
	{
		public static void Main(string[] args)
		{
			int firstNumber, secondNumber;
			// Assigning a constant to variable
			firstNumber = 10;
			Console.WriteLine("First Number = {0}", firstNumber);
            			// Assigning a variable to another variable
			secondNumber = firstNumber;
			Console.WriteLine("Second Number = {0}", secondNumber);
		}
	}
}


        
