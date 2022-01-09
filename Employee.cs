using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
namespace IUL
{
    class Employee
    {
        private Int32 _id;
        private String _surname;
        private String _name;
        private String _patromic;
        private Byte[] _sign;
        public Int32 Id
        {
            get { return this._id; }
        }
        public String Surname
        {
            get { return this._surname; }
        }
        public String Name
        {
            get { return this._name; }
        }
        public String Patromic
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
        public Employee(String surname) 
        {
            try 
            {
                this._surname = surname;
                String query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]," +
                    "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_NAME]," +
                    "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_PATROMIC]," +
                    "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SIGN]" +
                    "FROM [IUL].[dbo].[EMPLOYEES] " +
                    "WHERE [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME] = @surname;";
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
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        } 
    }
}
