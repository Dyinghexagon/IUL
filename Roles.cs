using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace IUL
{
    class Roles
    {
        private int _id;
        private string _fullName;
        private string _abbreviatedName;

        public int Id 
        {
            get { return _id; }
        }
        public string FullName
        {
            get { return _fullName; }
        }
        public string AbbreviatedName
        {
            get { return _abbreviatedName; }
        }
        private static string GetFullOrAbbreviatedNameRole(int id, bool fullOrAbbreviated)
        {
            string rowName = (fullOrAbbreviated) ? "ROLE_FULL_NAME" : "ROLE_ABBREVIATED_NAME";
            string fullNameRole = "";
            string query = "SELECT [ROLES].[" + rowName + "] FROM [ROLES] WHERE [ROLES].[ROLE_ID] = @id;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter idParam = new SqlParameter("id", id);
                command.Parameters.Add(idParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            fullNameRole = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }

            }
            return fullNameRole;
        }
        public static List<string> GetFullOrAbbreviatedNameRoles(bool fullOrAbbreviated) 
        {
            int countColumns = DbProviderFactories.GetCountСolumns("ROLES");
            List<string> roles = new List<string>(countColumns);
            for (int i = 1; i <= countColumns; i++) 
            {
                roles.Add(GetFullOrAbbreviatedNameRole(i, fullOrAbbreviated));
            }
            return roles;
        }

    }
}
