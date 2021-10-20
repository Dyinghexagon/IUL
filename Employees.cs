using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace IUL
{
    class Employees
    {
        private int _id;
        private string _fname;
        private string _name;
        private string _patromic;

        public int Id
        {
            get { return _id; }
        }
        public string Fname
        {
            get { return _fname; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Patromic
        {
            get { return _patromic; }
        }

        private static string GetFIO(int id)
        {
            string FIO = "";
            string query = "SELECT [EMPLOYEES].[EMPLOYEE_FNAME]" +
                ",[EMPLOYEES].[EMPLOYEE_NAME]" +
                ",[EMPLOYEES].[EMPLOYEE_PATROMIC]" +
                "FROM [EMPLOYEES]" +
                "WHERE [EMPLOYEES].[EMPLOYEE_ID] = @id;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter idParam = new SqlParameter("@id", id);
                command.Parameters.Add(idParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string fname = reader.GetValue(0).ToString().Trim();
                            string name = reader.GetValue(1).ToString().Trim();
                            string patromic = reader.GetValue(2).ToString().Trim();
                            FIO = fname + " " + name[0] + ". " + patromic[0] + ".";
                        }
                    }
                }
            }
            return FIO;
        }
        public static List<string> GetFIOList() 
        {
            int countColumns = DbProviderFactories.GetCountСolumns("EMPLOYEES");
            List<string> FIOList = new List<string>(countColumns);
            for(int i=1;i<= countColumns; i++) 
            {
                FIOList.Add(Employees.GetFIO(i));
            }
            return FIOList;
        }

    }
}
