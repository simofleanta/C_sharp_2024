/*.
You want to build a simple movie recommender that gives the top movie in a particular genre.

First, create a string variable named genre and save the value "Horror" to it.
2.
Create a switch statement using genre. Don’t add any cases to the code block yet.

Next, add the following movie genres as cases to the switch statement. Make sure to also add a default case. Add a break statement to each case.

Genres:

Drama
Comedy
Adventure
Horror
Science Fiction

4.
Next, add Console.WriteLine() statements to each case in the switch statement so that the program prints out different movie titles based on the selected genre. For the default case, print “No movie found”.

Take a look at the following table to see the top movie for five different genres:

Genre	Movie
Drama	Citizen Kane
Comedy	Duck Soup
Adventure	King Kong
Horror	Psycho
Science Fiction	2001: A Space Odyssey

5.
Let’s turn this into something a user can make use of. Swap out "Horror" for Console.ReadLine() to get the user’s response and save it to genre. Before that, add a Console.WriteLine() that prompts the user to pick a genre.

Type dotnet run into the terminal to see the program in action. */



using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      // Code from Checkpoint 1
      // string genre = "Horror";

      // Code from Checkpoint 5
      Console.WriteLine("Choose a movie genre: ");
      string genre = Console.ReadLine();

      switch (genre)
      {
        case "Drama":
          Console.WriteLine("Citizen Kane");
        break;

        case "Comedy":
          Console.WriteLine("Duck Soup");
        break;

        case "Adventure":
          Console.WriteLine("King Kong");
        break;

        case "Horror":
          Console.WriteLine("Psycho");
        break;

        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
        break;

        default:
          Console.WriteLine("No movie found");
        break;
      }

    }
  }
}
