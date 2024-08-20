using System;
using System.Data.SqlClient;

namespace ConsoleApp72
{
    internal class Program_Conn
    {
        static void Main(string[] args)
        {
            // Set db, server, user, and password variables
            string server = "researchappsqdt-ondemand.sql.azuresynapse.net";
            string database = "dataverse_irtesting_unq15c9740ab42fee118475000d3a486";
            string user = "sqladminuser";
            string password = "ResearchApps!";

            // Call the db function
            string connectionserver = db(server, database, user, password);
            Console.WriteLine("the server is  " + server);

            // Establishing the connection via an object
            using (SqlConnection connection = new SqlConnection(connectionserver))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // SQL query to update statecode from 1 to 0
                    string sqlUpdate = "UPDATE mrst_sfdrresearch SET statecode = 10 WHERE statecode = 0";
                    SqlCommand command = new SqlCommand(sqlUpdate, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"{rowsAffected} rows updated successfully!");
                }
                catch (Exception errors)
                {
                    Console.WriteLine("Connection failed: " + errors.Message);
                }
            }
        }

        static string db(string server, string database, string user, string password)
        {
            // Build the connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = server;
            builder.InitialCatalog = database;
            builder.UserID = user;
            builder.Password = password;
            builder.Encrypt = true;
            builder.TrustServerCertificate = false;

            return builder.ConnectionString;
        }
    }
}
