using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conn_obj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "";
            string database = "";
            string username = "";
            string pass = "";

            string serverconnn = db(server, username, pass, database);
            Console.WriteLine(serverconnn);

            SqlConnection sqldbc = new SqlConnection(serverconnn);
            try
            {
                sqldbc.Open();
                Console.WriteLine("Connection opened successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ops not good"+ ex.Message);
            }
            finally 
            { 
                sqldbc.Close(); 
            }
        }
        static string db(string server, string username, string password, string database)
        {
            return $"Server={server};Database={database};User Id={username};Password={password};";
        }

    }
}
