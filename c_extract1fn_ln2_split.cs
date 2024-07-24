using System;
using System.Linq;
namespace ConsoleApp49
    {
        internal class Program
        {
            static void Main(string[] args)
            { // Task: extract the first and the lastname from the names/records john doe and adam smith
             // logic used :
              /* used for each loop to display the names
               * used split function to extract fn
               * used Substring function to extract last name
               * */

                string[] name = { "John Doe", "Adam Smith" };
                foreach (string i in name)
                {
                //print the names 
                //Console.WriteLine(i);
                //extract first names
                //Console.WriteLine(i.Split(' ')[0]);
                Console.WriteLine(i.Split(' ')[1]);  //version1
                // extract ln              
                //Console.WriteLine(i.Substring(i.IndexOf(' '))); //v2
              
            }




        }
    }

}
    

