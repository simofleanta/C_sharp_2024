using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool answerone = 500 > 24;
            Console.WriteLine(answerone);
        }
    }
}


////////////////////////////////////////////ex
/*1.You are driving to your family’s house for a holiday and want to see if you’ll get there before dinner. 
Dinner will begin at 6:00 PM and the house is 95 miles away. If you leave at 2:00PM and drive an average of 30 miles per hour, will you get there early (before 6:00pm)?

2.Create a double variable named timeToDinner and save the difference in hours between 2:00pm and 6:00pm.*/

/*breaking down the ex 

3. Save the value 95 to a double variable named distance.

Save the value 30 to a double variable named rate.

4.We can calculate how long it will take us by dividing the distance variable by the rate variable.

Write out the expression and save it to the variable tripDuration.

5.Print answer to the console. Will you arrive before dinner begins?*/


using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      double timeToDinner = 4;
      double distance = 95;
      double rate = 30;
      double tripDuration = distance / rate;
      bool answer = tripDuration <= timeToDinner;
      Console.WriteLine(answer);



    }
  }
}


