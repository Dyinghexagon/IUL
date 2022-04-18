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
            get { return _id; }
            set { _id = value; }
        }
        public String Surname
        {
            get { return _surname; }
            set { _surname = value; }

        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public String Patromic
        {
            get { return _patromic; }
            set { _patromic = value; }

        }
        public System.Drawing.Image Sign 
        {
            get 
            { 
                using(System.IO.MemoryStream ms = new System.IO.MemoryStream(_sign)) 
                {
                    System.Drawing.Image imgSign = System.Drawing.Image.FromStream(ms);
                    return imgSign;
                }
            }
            set 
            {
                using(var ms = new MemoryStream()) 
                {
                    value.Save(ms, value.RawFormat);
                    _sign = ms.ToArray();
                }
            }
        }
        public Employee(String surname) 
        {
            try 
            {
                _surname = surname;
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
                    command.Parameters.Add("@surname", System.Data.SqlDbType.VarChar).Value = _surname;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                _id = Convert.ToInt32(reader.GetValue(0));
                                _name = reader.GetValue(1).ToString().Trim();
                                _patromic = reader.GetValue(2).ToString().Trim();
                                _sign = (byte[])reader.GetValue(3);
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
        public Employee(Int32 id)
        {
            try
            {
                _id = id;
                String query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME]," +
                    "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_NAME]," +
                    "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_PATROMIC]," +
                    "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SIGN]" +
                    "FROM [IUL].[dbo].[EMPLOYEES] " +
                    "WHERE [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID] = @id;";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = _id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                _surname = reader.GetValue(0).ToString().Trim();
                                _name = reader.GetValue(1).ToString().Trim();
                                _patromic = reader.GetValue(2).ToString().Trim();
                                _sign = (byte[])reader.GetValue(3);
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
        public Employee(Employee employee) 
        {
            _id = employee.Id;
            _name = employee.Name;
            _surname = employee.Surname;
            _patromic = employee.Patromic;
            using (var ms = new MemoryStream())
            {
                employee.Sign.Save(ms, employee.Sign.RawFormat);
                _sign = ms.ToArray();
            }
        }
    }
}
