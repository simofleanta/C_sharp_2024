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
        public int Total_h { get; set; }
        public string Reporters { get; set; }

        public Ticket(string idName, int project, string status, int total_h, string reporters)
        {
            IdName = idName;
            Project = project;
            Status = status;
            Total_h = total_h;
            Reporters= reporters;
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

                    // SQL statement to create the table if it doesn't exist
                    string sql_table = @"
                        CREATE TABLE IF NOT EXISTS tickets (
                            id SERIAL PRIMARY KEY,
                            Id_name VARCHAR(100),
                            project INT,
                            status VARCHAR(100),
                            total_h INT,
                            reporters varchar(100)
                        );";

                    using (var command = new NpgsqlCommand(sql_table, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Table 'tickets' created successfully (if it did not exist).");
                    }

                    // Ensure the 'total_h' column exists
                    string sql_alter = @"
                        ALTER TABLE tickets
                        ADD COLUMN IF NOT EXISTS reporters varchar;";
                    

                    using (var command = new NpgsqlCommand(sql_alter, connection))
                    {
                        command.ExecuteNonQuery();
                        //Console.WriteLine("Column 'total_h' ensured to exist.");
                        Console.WriteLine("Column 'reporters' ensured to exist.");
                    }

                    // Define multiple entries
                    var tickets = new List<Ticket>
                    {
                        new Ticket("tsp_1", 1, "fin",5,"Jim"),
                        new Ticket("tsp_2", 2, "in-progress",8, "Jim"),
                        new Ticket("tsp_3", 2, "open",2, "Jim"),
                        new Ticket("tsp_4", 3, "open",6, "Jim"),
                        new Ticket("tsp_5", 3, "in-progress",6, "Jim"),
                        new Ticket("tsp_6", 3, "in-progress",9, "Jim"),
                        new Ticket("tsp_7", 3, "in-progress",4, "Jim")
                    };

                    // Add multiple entries using transaction
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
            string sql = "INSERT INTO tickets (Id_name, project, status, total_h, reporters) VALUES (@id_name, @project, @status, @total_h, @reporters)";

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (var ticket in tickets)
                    {
                        using (var command = new NpgsqlCommand(sql, connection, transaction))
                        {
                            // Bind parameters explicitly
                            command.Parameters.Add("@id_name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ticket.IdName;
                            command.Parameters.Add("@project", NpgsqlTypes.NpgsqlDbType.Integer).Value = ticket.Project;
                            command.Parameters.Add("@status", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ticket.Status;
                            command.Parameters.Add("@total_h", NpgsqlTypes.NpgsqlDbType.Integer).Value = ticket.Total_h;
                            command.Parameters.Add("@reporters", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ticket.Reporters;

                            command.ExecuteNonQuery(); // Execute the command
                        }
                        Console.WriteLine($"Entry with Id_name = {ticket.IdName} added successfully.");
                    }
                    transaction.Commit();
                    Console.WriteLine("All entries added successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"Failed to add entries: {ex.Message}");
                }
            }
        }
    }
}

//connect to db
// sa fac o logica unde iau un id de companie si sa se redea informatii despre companie 
//logic to save the filter 
