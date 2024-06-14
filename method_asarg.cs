using System;
using System.Runtime.CompilerServices;
namespace App
{
    class Program
    {
        //method to be used as second arg
    public static bool IsLong(string word) => word.Length > 8;
    
    static void Main (string[] args)
    {
        //array to be used as first arg
        string[]adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };
        // call Array.Find()
        string FLongAdjectives = Array.Find(adjectives, IsLong);
            Console.WriteLine($"The first long word is: {FLongAdjectives}.");
        }
  
    }
}
