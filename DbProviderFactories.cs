using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
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
        public static string GetPathMainFolder(string codeProject) 
        {
            string path="";
            string query = "SELECT [IUL].[dbo].[PROJECTS].[PROJECT_PATH_FOLDER] " +
                "FROM [IUL].[dbo].[PROJECTS] " +
                "WHERE [IUL].[dbo].[PROJECTS].[PROJECT_ID] = @codeProject" + ";";
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
                            path = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            return path;
        }
        public static List<KeyValuePair<string, string>> GetIdAndNameProject() 
        {
            List<KeyValuePair<string, string>> idAndNameProject = new List<KeyValuePair<string, string>>();
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[PROJECTS].[PROJECT_ID]," +
                "[IUL].[dbo].[PROJECTS].[PROJECT_NAME]" +
                "FROM [IUL].[dbo].[PROJECTS];";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader.GetValue(0).ToString().Trim();
                            string projectName = reader.GetValue(1).ToString().Trim();
                            idAndNameProject.Add(new KeyValuePair<string, string>(id, projectName));
                        }
                    }
                }
            }
            return idAndNameProject;
        }
        public static void UpdateImageSignEmployee(string path, int id) 
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);
            byte[] signData = reader.ReadBytes((int)fileStream.Length);       
            string query = "USE IUL;" +
                "UPDATE [IUL].[dbo].[EMPLOYEES]" +
                "SET [EMPLOYEE_SIGN] = @sign " +
                "WHERE [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID] = @id;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@sign", System.Data.SqlDbType.Image, signData.Length).Value = signData;
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
            fileStream.Close();
            reader.Close();
        }
    }
}
