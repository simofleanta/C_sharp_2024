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

                    // Add a new column 'new_column' to the 'artist' table
                    string addColumnQuery = "ALTER TABLE artist ADD COLUMN new_column VARCHAR(50);";

                    using (var command = new NpgsqlCommand(addColumnQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("New column 'new_column' added successfully.");
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
