using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
namespace IUL
{
    public enum Tables 
    {
        ROLES,
        PROJECTS,
        EMPLOYEES
    }
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
        public static void InitializeComboBox(ComboBox fillingComboBox, Tables table)
        {
            try
            {
                String query = String.Empty;
                String nameTable = String.Empty;
                switch (table) 
                {
                    case Tables.ROLES: 
                        {
                            query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[ROLES].[ROLE_ABBREVIATED_NAME] " +
                    "FROM [IUL].[dbo].[ROLES]; ";
                            nameTable = "ROLES";
                            break;
                        }
                    case Tables.PROJECTS:
                        {
                            query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[PROJECTS].[PROJECT_NAME] " +
                    "FROM [IUL].[dbo].[PROJECTS]; ";
                            nameTable = "PROJECTS";

                            break;
                        }
                    case Tables.EMPLOYEES:
                        {
                            query = "SELECT  [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME]" +
                    "FROM [IUL].[dbo].[EMPLOYEES];";
                            nameTable = "EMPLOYEES";

                            break;
                        }
                    default: 
                        {
                            throw new Exception("Error selected table!");
                        }
                }
                Int32 count = DbProviderFactories.GetCountСolumns(nameTable);
                String[] valuesFromSelectedTable = new string[count];
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            for (Int32 i = 0; reader.Read(); i++)
                            {
                                valuesFromSelectedTable[i] = reader.GetValue(0).ToString().Trim();
                            }
                        }
                    }
                }
                fillingComboBox.Items.AddRange(valuesFromSelectedTable);
            }
            catch (Exception ex)
            {
                throw new Exception("InitializeComboBox(DbProviderFactories) "+ex.Message, ex);
            }
        }

        public static void ComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var text = lbox.Items[e.Index].ToString();
            var width = lbox.ClientSize.Width;
            var size = e.Graphics.MeasureString(text, lbox.Font, width);
            e.ItemHeight = (int)size.Height;
        }

        public static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var color = SystemColors.Window;
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(lbox.Items[e.Index].ToString(), e.Font, SystemBrushes.WindowText, e.Bounds);
            }
        }
    }
}
