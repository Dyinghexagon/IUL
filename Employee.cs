using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace IUL
{
    class Employee
    {
        private int _id;
        private string _fname;
        private string _name;
        private string _patromic;
        private byte[] _sign;
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
        public Employee(string fname) 
        {
            this._fname = fname;
            Initialization();
        }
        private static string GetFname(int id)
        {
            string fname = "";
            string query = "SELECT [EMPLOYEES].[EMPLOYEE_FNAME]" +
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
                            fname = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            return fname;
        }
        public static List<string> GetFIOList() 
        {
            int countColumns = DbProviderFactories.GetCountСolumns("EMPLOYEES");
            List<string> FIOList = new List<string>(countColumns);
            for(int i=1;i<= countColumns; i++) 
            {
                FIOList.Add(Employee.GetFname(i));
            }
            return FIOList;
        }
        private void Initialization() 
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]," +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_NAME]," +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_PATROMIC]," +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SIGN]" +
                "FROM [IUL].[dbo].[EMPLOYEES] " +
                "WHERE [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME] = @fname;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@fname", System.Data.SqlDbType.VarChar).Value = this._fname;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this._id = Convert.ToInt32(reader.GetValue(0));
                            this._name = reader.GetValue(1).ToString().Trim();
                            this._patromic = reader.GetValue(2).ToString().Trim();
                            this._sign = (byte[])reader.GetValue(3);
                        }
                    }
                }
            }
        }
    }
}
