﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IUL
{
    class DbProviderFactories
    {
        /// <summary>
        /// Метод подключения к БД
        /// </summary>
        /// <param name="dataSourse">Расположение сервера</param>
        /// <param name="nameDB">Имя БД, которой осуществляется подключение</param>
        /// <returns></returns>
        public static SqlConnection GetDBConnection(string dataSourse, string nameDB)
        {
            //string connStr = @"Data Source=18.117.109.19\SQLEXPRESS,1433;Initial Catalog=lab3;User ID=root;Password=root";
            string connStr = @"Data Source=" + dataSourse + "\\SQLEXPRESS,1433;Initial Catalog=" + nameDB + ";User ID=root;Password=root";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
        public static SqlConnection GetDBConnection()
        {
            string connStr = @"Data Source=18.117.109.19\SQLEXPRESS,1433;Initial Catalog=IUL;User ID=root;Password=root";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
        public static void CheckConnection(string dataSourse, string nameDB)
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DbProviderFactories.GetDBConnection(dataSourse, nameDB);
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
        public static async Task<int> GetCountRowsAsync(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                await connection.OpenAsync();
                string query = "select count(*) from syscolumns where id = object_id('" + tableName + "');";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count =Convert.ToInt32(getchild.ExecuteScalarAsync());
                }
            }
            return count;
        }
        public static async Task<int> GetCountСolumnsAsync(string tableName)
        {
            object count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                await connection.OpenAsync();
                string query = "SELECT count(*) FROM ["+tableName+"]";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count = await getchild.ExecuteScalarAsync();
                }
            }
            return Convert.ToInt32(count);
        }
        public static int GetCountСolumns(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                string query = "SELECT count(*) FROM [" + tableName + "]";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    count = Convert.ToInt32(getchild.ExecuteScalar());
                }
            }
            return count;
        }
    }
}
