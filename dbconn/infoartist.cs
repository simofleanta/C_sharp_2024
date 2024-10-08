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

                    // Step 1: SQL Query to display all about artist with artist_id = 50
                    string selectQuery = @"
                        SELECT a.*, b.* 
                        FROM artist a
                        JOIN album b ON b.artist_id = a.artist_id
                        WHERE a.artist_id = 50;
                    ";

                    using (var selectCommand = new NpgsqlCommand(selectQuery, connection))
                    {
                        using (var reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Display artist info (adjust as per your columns)
                                Console.WriteLine($"Artist ID: {reader["artist_id"]}, Name: {reader["name"]}");

                                // Display album info (adjust as per your columns)
                                Console.WriteLine($"Album ID: {reader["album_id"]}, Title: {reader["title"]}");
                            }
                        }
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
