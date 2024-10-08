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

                    // Step 1: Rename the column
                    string renameQuery = @"
                        ALTER TABLE artist 
                        RENAME COLUMN new_column TO musical_instrument;
                    ";

                    using (var renameCommand = new NpgsqlCommand(renameQuery, connection))
                    {
                        renameCommand.ExecuteNonQuery();
                        Console.WriteLine("Column renamed successfully.");
                    }

                    // Step 2: Update the renamed column for specific artist_ids
                    string updateQuery = @"
                        UPDATE artist 
                        SET musical_instrument = 'Oboe' 
                        WHERE artist_id IN (1, 2, 3, 4, 20, 36);
                    ";

                    using (var updateCommand = new NpgsqlCommand(updateQuery, connection))
                    {
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
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
