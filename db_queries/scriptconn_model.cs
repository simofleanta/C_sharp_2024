using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    internal class Program_Conn
    {
        static void Main(string[] args)
        { // I in the main set db, server, user and pass variablles
            string server = "";
            string database = "";  // Replace with your database name
            string user = "";  // Replace with your user ID
            string password = "";  // Replace with your password
         

            // call the db function 
            string connectionserver = db(server, database, user, password);
            Console.WriteLine("the server is  " + server);


            // estabblishing the connection via an object 
            using (SqlConnection connection = new SqlConnection(connectionserver))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // sql query reading 
                   string sql_q= "select top(20) * from ex x" ;
                    SqlCommand command = new SqlCommand(sql_q, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                     {
                        Console.WriteLine($"{reader[0]}, {reader[1]}");
                    }


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
