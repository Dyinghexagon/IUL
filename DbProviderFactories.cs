using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace IUL
{
    class DbProviderFactories
    {
        /// <summary>
        /// Метод подключения к БД
        /// </summary>
        /// <param name="dataSourse">Расположение сервера</param>
        /// <param name="nameDB">Имя БД, которой осуществляется подключение</param>
        /// <returns></returns>
        public static SqlConnection GetDBConnection(string dataSourse, string nameDB)
        {
            string connStr = @"Data Source=" + dataSourse + "\\SQLEXPRESS,1433;Initial Catalog=" + nameDB + ";User ID=root;Password=root";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
        public static SqlConnection GetDBConnection()
        {

            string connectionString = ConfigurationManager.AppSettings["conn"];
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public static void CheckConnection()
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DbProviderFactories.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
        public static async Task<int> GetCountRowsAsync(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                await connection.OpenAsync();
                string query = "select count(*) from syscolumns where id = object_id('" + tableName + "');";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count =Convert.ToInt32(getchild.ExecuteScalarAsync());
                }
            }
            return count;
        }
        public static int GetCountRows(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                string query = "select count(*) from syscolumns where id = object_id('" + tableName + "');";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count = Convert.ToInt32(getchild.ExecuteScalarAsync());
                }
            }
            return count;
        }
        public static async Task<int> GetCountСolumnsAsync(string tableName)
        {
            object count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                await connection.OpenAsync();
                string query = "SELECT count(*) FROM ["+tableName+"]";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count = await getchild.ExecuteScalarAsync();
                }
            }
            return Convert.ToInt32(count);
        }
        public static int GetCountСolumns(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                string query = "SELECT count(*) FROM [" + tableName + "]";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count = Convert.ToInt32(getchild.ExecuteScalar());
                }
            }
            return count;
        }
    }
}
