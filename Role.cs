using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace IUL
{
    class Role
    {
        private Int32 _id;
        private String _fullName;
        private String _abbreviatedName;

        public Int32 Id 
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public String FullName
        {
            get { return this._fullName; }
            set { this._fullName = value; }
        }
        public String AbbreviatedName
        {
            get { return this._abbreviatedName; }
            set { this._abbreviatedName = value; }
        }
        public Role(String roleAbbreviatedName) 
        {
            try 
            {
                this._abbreviatedName = roleAbbreviatedName;
                String query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[ROLES].[ROLE_ID]" +
                    ",[IUL].[dbo].[ROLES].[ROLE_FULL_NAME]" +
                    "FROM [IUL].[dbo].[ROLES]" +
                    "WHERE [IUL].[dbo].[ROLES].[ROLE_ABBREVIATED_NAME] = @abbreviatedName;";
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
    }
}
