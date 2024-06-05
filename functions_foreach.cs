using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{ // what are your origins? Using foreach loop to enumerate origins 
    // in the main create f
    // in the execution function loop origins using foreach for strings 
    internal class Program
    {
        static void Main(string[] args) // main create the f
        { //creating the variables and passing them into the function that will be executed in the second static void function
            
            

            Ethnicity(eth1: "Eastern EU/Baltic", eth2: "North West EU/Scandinav", eth3: "Centra Asian");      

           
        }

        static void Ethnicity(string eth1, string eth2, string eth3) //execute the function that was created in the Main
        {
            
            string[] Origins = {eth3,eth2,eth3 };                           
            foreach (string i in Origins)
                Console.WriteLine(i);  //indentation needs attention "Danish", "Kazach", "Hungarian"
        }

      

    }
}







