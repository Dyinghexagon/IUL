using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace IUL
{
    class DbProviderFactories
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = ConfigurationManager.AppSettings.Get("conn");
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
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
        public static int GetCountСolumnsChapters(string codeProject)
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM [IUL].[dbo].[CHAPTERS] " +
    "WHERE[IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @codeProject" + ";";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter codeProjectParam = new SqlParameter("@codeProject", codeProject);
                command.Parameters.Add(codeProjectParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                }
            }
            return count;
        }
    }
}
