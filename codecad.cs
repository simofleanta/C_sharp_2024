using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program works
            Author: Smith
            */


            // Let the user know that the program is starting:
            string start = "Now";
    Console.WriteLine($"program {start}!");

            // Give the Mad Lib a title:
            string title = "Mad";

            Console.WriteLine(title);
            // Define user input and variables:

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            string[] adj = { "Blue", "Lila", "Green" };
            foreach (string i in adj)
            {
                Console.WriteLine("Adj: ");
                Console.ReadLine();
            }

            string[] verbs = { "EAT", "sleep", "repeat" };
            foreach (string i in verbs)
            {
                Console.WriteLine("Verbs: ");
                Console.ReadLine();
            }

            string[] nouns = { "EAT", "sleep", "repeat" };
            foreach (string i in nouns)
            {
                Console.WriteLine("Nouns: ");
                Console.ReadLine();
            }

            // The template for the story:




            string story = $"This morning { name} woke up feeling { adj}." +
                    $" 'It is going to be a {adj} day!' Outside, a bunch of {nouns}s were protesting to keep {adj} in stores." +
                $" They began to {nouns} to the rhythm of the {nouns}, which made all the {nouns}s very {nouns}." +
                $" Concerned, {verbs} texted {verbs}, who flew {nouns} to {verbs} and dropped {verbs} in a puddle of frozen {verbs}." +
                $" woke up in the year {adj}, in a world where {nouns}s ruled the world.";


            // Print the story:`
            Console.WriteLine(story);
            // if I did not have it with for I and had it separate consoles to run the names would appear 

        }
    }
}
