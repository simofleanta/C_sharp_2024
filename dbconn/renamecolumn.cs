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

                    // Set all values in 'new_column' to NULL
                    string renameQuery = @"
                         ALTER TABLE artist 
                        RENAME COLUMN new_column TO musical_intrument;
                    ";

                    using (var command = new NpgsqlCommand(renameQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
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
