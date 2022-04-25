using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
namespace IUL
{
    class DbProviderFactories
    {
        public static SqlConnection GetDBConnection()
        {
            try 
            {
                String connectionString = ConfigurationManager.AppSettings.Get("conn");
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static async Task<Int32> GetCountRowsAsync(String tableName)
        {
            Int32 count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                await connection.OpenAsync();
                String query = "select count(*) from syscolumns where id = object_id('" + tableName + "');";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count =Convert.ToInt32(getchild.ExecuteScalarAsync());
                }
            }
            return count;
        }
        public static Int32 GetCountRows(String tableName)
        {
            try 
            {
                Int32 count = 0;
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    String query = "select count(*) from syscolumns where id = object_id('" + tableName + "');";
                    using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                    {
                        count = Convert.ToInt32(getchild.ExecuteScalarAsync());
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static async Task<Int32> GetCountСolumnsAsync(String tableName)
        {
            try 
            {
                object count = 0;
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    await connection.OpenAsync();
                    string query = "SELECT count(*) FROM [" + tableName + "]";
                    using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                    {
                        count = await getchild.ExecuteScalarAsync();
                    }
                }
                return Convert.ToInt32(count);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static Int32 GetCountСolumns(String tableName)
        {
            try 
            {
                Int32 count = 0;
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    String query = "SELECT count(*) FROM [" + tableName + "]";
                    using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                    {
                        count = Convert.ToInt32(getchild.ExecuteScalar());
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static Int32 GetCountСolumnsChapters(String codeProject)
        {
            try 
            {
                Int32 count = 0;
                String query = "SELECT COUNT(*) FROM [IUL].[dbo].[CHAPTERS] " +
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
       
    }
}
