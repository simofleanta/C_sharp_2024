using System;

// interactive program for countries
namespace functions_method
{
     class Program
    {
        static void MyMethod(string ethnicities="russiam")
        {
           
            Console.ReadLine();
            Console.WriteLine(ethnicities);

        }
        static void Main(string[] args)
        {
            MyMethod("Czech");
            MyMethod("Italian");
            MyMethod("Ukrainian");
            MyMethod();
        }
    }
}
