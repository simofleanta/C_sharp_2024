/*My Home
Syllabus

Fork
Get Unstuck
Tools

Avatar
Money Maker
Project Brief
Objective
LEARN C#
Money Maker
You have three types of coins:

A bronze coin is worth 1 cent
A silver coin is worth 5 cents
A gold coin is worth 10 cents
What is the minimum number of coins that equals 98 cents?

It’s a hard question to answer in your head, but it’s a fun problem to solve with programming. In this project you’ll use C# to build a Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value.

For example, 16 cents could be:

16 bronze coins,
3 silver coins and 1 bronze coin, or
1 gold coin, 1 silver coin, 1 bronze coin
16 cents, divided three ways

We’d like the last option because it uses the fewest coins.

This project will get you comfortable with division (/), rounding down (Math.Floor()), and modulo (%): You can find how many coins “fit” into an amount by dividing the amount by the coin value, rounding down, and finding the remainder. Let’s walk through an example:

The user enters 15 cents. A gold coin is 10 cents, so 1.5 gold coins fit into the total.
goldCoinsIn15Cents = 15 / 10; // equals 1.5

But we can’t divide coins in half, so instead, we round down to the nearest whole number:
actualGoldCoins = Math.Floor( 15 / 10 ); // equals 1

You can find the remainder using modulo:
double remainder = 15 % 10; // equals 5

Using the remainder, repeat the process with the smaller coins.
Tasks
12/12 complete
Mark the tasks as complete by checking them off
Capture Input
1.
Run the code once to understand the starting code. Use dotnet run in the terminal.

2.
Use Console.WriteLine() and Console.ReadLine() to ask the user for the amount to convert and capture the value in a variable.

3.
Convert the captured value (a string) to a number.

You can convert a value using Convert.ToDouble().

4.
Before we get to calculating, let the user know what you are about to do. For example, if the user entered 16, the program should write to the console:

16 cents is equal to...

5.
Run the code to check your work so far. At this point you should see something like:

Welcome to Money Maker!
Enter an amount to convert to coins:

Once you enter a number — say 16 — and press Enter you should see something like:

16 cents is equal to...

Convert To Coins
6.
To convert to coins, we need to know the value of each type of coin! Define two variables that hold those values.

A gold coin is worth 10 cents
A silver coin is worth 5 cents
Don’t worry about bronze coins for now.

Define two int variables with the values 10 and 5. You can name them goldValue and silverValue.

7.
To find the maximum number of gold coins that “fit” into the amount (e.g. one gold coin fits into 11 cents):

Divide the amount by the value of a gold coin
Round down to the nearest integer
Store the result in a double variable called goldCoins
Like the example in the project description, you’ll need to use the division operator (/) and Math.floor().

For example, 10 “fits” into 21 two times:

double howMany10sIn21 = Math.Floor(21 / 10); 
// howMany10sIn21 equals 2

8.
Use the modulo (%) operator to find the remaining amount and store it in a double variable.

For example, one gold coin fits into 11 cents and the remainder is 1:

double leftOver = 11 % 10 // equals 1

9.
Find the maximum number of silver coins that “fit” into the remainder:

Divide the remainder by the value of a silver coin
Round down to the nearest integer
Store the result in a double variable called silverCoins
10.
Use the modulo (%) operator to find the remaining amount and store it in the existing remainder variable.

remainder = remainder % silverValue;

11.
Print out all of the coins! If your input was 16, your output should look something like:

16 cents is equal to...
Gold coins: 1
Silver coins: 1
Bronze coins: 1

We didn’t need to do extra work to find the number of bronze coins because it’s just the remainder!

12.
Test your application to make sure it works! Some test cases are provided in the hint.

Here are two optional challenges:

The program doesn’t work if the user enters a decimal, like 16.2 cents. Using type conversion or a Math method, round down their input to the nearest whole cent.
Use another currency that has different coin amounts. For example, the US uses 1, 5, 10, and 25 cent coins called pennies, nickels, dimes, and quarters, respectively.
*/


using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter amount to convert to coins...");
      string totalAsString = Console.ReadLine();
      double myAgeAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"16 cents is equal to... {myAgeAsDouble}");

  int goldvalue = 10;
  int silvervalue = 5;
  int bronzvalue = 3;

  double goldcoins = 20 / 10;
  double silvercoin = 20/ 5;
  double bronzcoin = 20 / 25;
  double leftOver = 11 % 10;
  Console.WriteLine($"20 cents is equal to... {goldcoins}");
  Console.WriteLine($"20 cents is equal to...{goldvalue}");
  Console.WriteLine(silvercoin);
  Console.WriteLine(bronzcoin); 
  Console.WriteLine(leftOver);;
      





   
      
    }
  }
}
