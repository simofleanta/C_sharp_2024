using System;
using Npgsql;  // Use Npgsql for PostgreSQL
using System.IO;  // For file handling

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

            // Filter criteria to save
            string filter = "Accept"; // Example filter - can be user input or loaded from a file

            // Save the filter for future use
            SaveFilter(filter);

            // Establishing the connection
            using (var connection = new NpgsqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // Retrieve saved filter (you can also prompt the user to input a filter here)
                    string savedFilter = LoadFilter();

                    // SQL query to retrieve filtered data using the saved filter
                    string sqlQuery = $@"
                        SELECT a.artist_id, a.name, am.title
                        FROM artist a
                        JOIN album am ON am.artist_id = a.artist_id
                        WHERE a.name = @Filter
                        LIMIT 5;";

                    using (var command = new NpgsqlCommand(sqlQuery, connection))
                    {
                        // Adding parameter to avoid SQL injection
                        command.Parameters.AddWithValue("@Filter", savedFilter);

                        using (var reader = command.ExecuteReader())
                        {
                            // Reading and displaying data
                            while (reader.Read())
                            {
                                // Creating a Kino object with retrieved data
                                var artist = new Kino(reader["artist_id"].ToString(), reader["name"].ToString());
                                Console.WriteLine($"Artist ID: {artist.ArtistId}, Name: {artist.Name}, Album Title: {reader["title"]}");
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

        // Method to save filter criteria to a file
        static void SaveFilter(string filter)
        {
            try
            {
                File.WriteAllText("filter.txt", filter);
                Console.WriteLine("Filter saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving filter: " + ex.Message);
            }
        }

        // Method to load filter criteria from a file
        static string LoadFilter()
        {
            try
            {
                return File.ReadAllText("filter.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading filter: " + ex.Message);
                return string.Empty; // Return a default value or handle it appropriately
            }
        }
    }
}
