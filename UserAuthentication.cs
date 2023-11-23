using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    internal class UserAuthentication
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=FinanceDB;Trusted_Connection=True";

        public static int FindUserId(string login, string password)
        {
            int userId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id FROM Users WHERE Login = @login AND Password = @password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();
                userId = Convert.ToInt32(result);
            }
            return userId;
        }

        public static string FindUser(string login, string password)
        {
            string name = "";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Users WHERE Login = @login AND Password = @password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();
                name = result.ToString();
            }

            return name;
        }
    }
}
