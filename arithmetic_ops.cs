using System;

namespace ops
{
    public class arithmetic_ops1
    {
        public static void Main(string[] args)
        {
             // assign values to the variables
            int first=10,double second=2.3,result;
            int num1=1, int num2=5,rem;

            // addition op
            result=first+second;
            Console.WriteLine("{0}+{1}={2}", first,second,result);

            // Multiplicator
            result=first*second;
            Console.WriteLine("{0}*{1}={2}",first,second,result);

              //division
             result=first/second;
            Console.WriteLine("{0}/{1}={2}",first,second,result);

            // modulo
            rem = num1%num2;
            Console.WriteLine("{0}%{1}={2}",num1,num2,rem);
        }
    }

}
    
       


