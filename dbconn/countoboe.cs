using System;
using Npgsql;  // Use Npgsql for PostgreSQL

namespace Chinno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Connection parameters
            string host = "localhost";
            string db = "chinook";
            string user = "postgres";
            string pass = "Tobyas22";
            string port = "5432";

            // Connection string
            string connString = $"Host={host};Database={db};Username={user};Password={pass};Port={port}";

            // Establishing the connection
            using (var connection = new NpgsqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // SQL Query to count the number of artists who play the Oboe
                    string countQuery = @"
                        SELECT COUNT(*) 
                        FROM artist a
                        JOIN album b ON b.artist_id = a.artist_id
                        WHERE musical_instrument = 'Oboe';
                    ";

                    using (var countCommand = new NpgsqlCommand(countQuery, connection))
                    {
                        var countResult = countCommand.ExecuteScalar();  // Executes a scalar query and returns a single value

                        // Display the result (number of Oboe artists)
                        Console.WriteLine($"Number of artists who play the Oboe: {countResult}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Operation failed: " + ex.Message);
                }
            }
        }
    }
}
