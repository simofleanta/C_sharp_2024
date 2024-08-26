using System;
using System.Collections.Generic;
using Npgsql;

namespace new_conn
{
    public class Ticket
    {
        public string IdName { get; set; }
        public int Project { get; set; }
        public string Status { get; set; }

        public Ticket(string idName, int project, string status)
        {
            IdName = idName;
            Project = project;
            Status = status;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining connection parameters
            string host = "localhost";
            string db = "test_dev";
            string user = "postgres";
            string pass = "Tobyas22";
            string port = "5432";

            string conn = $"Host={host};Database={db};Username={user};Password={pass};Port={port}";

            // Establishing connection
            using (var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // SQL statement to create the table
                    string sql_table = @"
                        CREATE TABLE IF NOT EXISTS tickets (
                            id SERIAL PRIMARY KEY,
                            Id_name VARCHAR(100),
                            project int,
                            status VARCHAR(100)
                        );";

                    using (var command = new NpgsqlCommand(sql_table, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Table 'tickets' created successfully.");
                    }

                    // Define multiple entries
                    var tickets = new List<Ticket>
                    {
                        new Ticket("tsp_1", 1, "fin"),
                        new Ticket("tsp_2", 2, "in-progress"),
                        new Ticket("tsp_3", 2, "open"),
                        new Ticket("tsp_4", 3, "open"),
                        new Ticket("tsp_5", 3, "in-progress"),
                        new Ticket("tsp_6", 3, "in-progress"),
                        new Ticket("tsp_7", 3, "in-progress")

                    };

                    // Add multiple entries
                    AddEntries(connection, tickets);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Connection failed: {ex.Message}");
                }
            }
        }

        static void AddEntries(NpgsqlConnection connection, List<Ticket> tickets)
        {
            // Define the SQL INSERT statement
            string sql = "INSERT INTO tickets (Id_name, project, status) VALUES (@id_name, @project, @status)";

            foreach (var ticket in tickets)
            {
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    // Bind parameters correctly
                    command.Parameters.AddWithValue("@id_name", ticket.IdName);
                    command.Parameters.AddWithValue("@project", ticket.Project);
                    command.Parameters.AddWithValue("@status", ticket.Status);

                    int rowsAffected = command.ExecuteNonQuery(); // Execute the command
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Entry with Id_name = {ticket.IdName} added successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"No entry was added for Id_name = {ticket.IdName}.");
                    }
                }
            }
        }
    }
}
