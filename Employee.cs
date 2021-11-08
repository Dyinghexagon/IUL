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
        public static string[] GetSurnameEmployees() 
        {
            int countEmployees = DbProviderFactories.GetCountСolumns("EMPLOYEES");
            string[] surnameEmployees = new string[countEmployees];
            string query = "SELECT [EMPLOYEES].[EMPLOYEE_SURNAME]" +
                "FROM [EMPLOYEES];";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        for(int i = 0; reader.Read(); i++) 
                        {
                            surnameEmployees[i] = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            return surnameEmployees;
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
