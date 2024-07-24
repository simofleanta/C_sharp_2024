using System;
namespace fn_to_multiply
{
    class Functionmethod
    {
        //define the function 
        static int method_multiply(int a, int b)
        { return a * b;
        }


        static void Main(string[] args)
        {
            //call function
            int result = method_multiply(50, 2);
            //print
    Console.WriteLine(result);
        }
    }
}



