using System;
using Npgsql;  // Use Npgsql for PostgreSQL

namespace Chinno
{
    public class Kino
    {
        // Properties for artist details
        public string ArtistId { get; set; }
        public string Name { get; set; }

        // Constructor to initialize artist details
        public Kino(string artistId, string name)
        {
            ArtistId = artistId;
            Name = name;
        }
    }

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

                    // SQL query to retrieve data
                    string sqlQuery = "SELECT * FROM artist LIMIT 20;";
                    using (var command = new NpgsqlCommand(sqlQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Reading and displaying data
                            while (reader.Read())
                            {
                                // Creating a Kino object with retrieved data
                                var artist = new Kino(reader["artist_id"].ToString(), reader["name"].ToString());
                                Console.WriteLine($"{artist.ArtistId}, {artist.Name}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                }
            }
        }
    }
}
