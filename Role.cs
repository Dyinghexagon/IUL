using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace IUL
{
    class Role
    {
        private int _id;
        private string _fullName;
        private string _abbreviatedName;

        public int Id 
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string FullName
        {
            get { return this._fullName; }
            set { this._fullName = value; }
        }
        public string AbbreviatedName
        {
            get { return this._abbreviatedName; }
            set { this._abbreviatedName = value; }
        }
        public Role(string roleAbbreviatedName) 
        {
            try 
            {
                this._abbreviatedName = roleAbbreviatedName;
                string query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[ROLES].[ROLE_ID]" +
                    ",[IUL].[dbo].[ROLES].[ROLE_FULL_NAME]" +
                    "FROM [IUL].[dbo].[ROLES]" +
                    "WHERE [IUL].[dbo].[ROLES].[ROLE_ABBREVIATED _NAME] = @abbreviatedName; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@abbreviatedName", System.Data.SqlDbType.NChar).Value = this._abbreviatedName;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                this._id = Convert.ToInt32(reader.GetValue(0));
                                this._fullName = reader.GetValue(1).ToString().Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static void InitializeComboBoxRoles(System.Windows.Forms.ComboBox fillingComboBox)
        {
            try 
            {
                int countRoles = DbProviderFactories.GetCountСolumns("ROLES");
                string[] roles = new string[countRoles];
                string query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[ROLES].[ROLE_ABBREVIATED _NAME] " +
                    "FROM [IUL].[dbo].[ROLES]; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            for (int i = 0; reader.Read(); i++)
                            {
                                roles[i] = reader.GetValue(0).ToString().Trim();
                            }
                        }
                    }
                }
                fillingComboBox.Items.AddRange(roles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
