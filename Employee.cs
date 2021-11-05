using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
namespace IUL
{
    class Employee
    {
        private int _id;
        private string _surname;
        private string _name;
        private string _patromic;
        private byte[] _sign;
        public int Id
        {
            get { return this._id; }
        }
        public string Surname
        {
            get { return this._surname; }
        }
        public string Name
        {
            get { return this._name; }
        }
        public string Patromic
        {
            get { return this._patromic; }
        }
        public System.Drawing.Image Sign 
        {
            get 
            { 
                using(System.IO.MemoryStream ms = new System.IO.MemoryStream(this._sign)) 
                {
                    System.Drawing.Image imgSign = System.Drawing.Image.FromStream(ms);
                    return imgSign;
                }
            }
        }
        public Employee(string surname) 
        {
            this._surname = surname;
            Initialization();
        }
        private static string GetFname(int id)
        {
            string fname = "";
            string query = "SELECT [EMPLOYEES].[EMPLOYEE_SURNAME]" +
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
        public static string[] GetSurnameEmployees() 
        {
            int countColumns = DbProviderFactories.GetCountСolumns("EMPLOYEES");
            List<string> FIOList = new List<string>(countColumns);
            for(int i=1;i<= countColumns; i++) 
            {
                FIOList.Add(Employee.GetFname(i));
            }
            return FIOList.ToArray();
        }
        private void Initialization() 
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]," +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_NAME]," +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_PATROMIC]," +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SIGN]" +
                "FROM [IUL].[dbo].[EMPLOYEES] " +
                "WHERE [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME] = @surname;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@surname", System.Data.SqlDbType.VarChar).Value = this._surname;
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
