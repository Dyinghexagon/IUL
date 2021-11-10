﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class Performer
    {
        private string _chapterId;
        private int _employeeId;
        private int _roleId;

        public string ChapterId 
        {
            get { return this._chapterId; }
            set { this._chapterId = value; }
        }
        public int EmployeeId
        {
            get { return this._employeeId; }
            set { this._employeeId = value; }
        }
        public int RoleId
        {
            get { return this._roleId; }
            set { this._roleId = value; }
        }

        public Performer(string chapterId, int employeeId, int roleId) 
        {
            this._chapterId = chapterId;
            this._employeeId = employeeId;
            this._roleId = roleId;
        }
        public Performer() 
        {
            this._chapterId = "";
            this._employeeId = 0;
            this._roleId = 0;
        }
        public bool InsertNewPerformer() 
        {
            string query = "USE IUL;" +
                "INSERT INTO[IUL].[dbo].[PERFORMERS]" +
                "([PERFORMER_CHAPTER_ID]" +
                ",[PERFORMER_EMPLOYEE_ID]" +
                ",[PERFORMER_ROLE_ID]) " +
                "VALUES" +
                "(@chapterId" +
                ",@employeeId" +
                ",@roleId);";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@chapterId", System.Data.SqlDbType.NChar).Value = this._chapterId;
                command.Parameters.Add("@employeeId", System.Data.SqlDbType.Int).Value = this._employeeId;
                command.Parameters.Add("@roleId", System.Data.SqlDbType.Int).Value = this._roleId;
                command.ExecuteNonQuery();
            }
            return true;
        }
    }
}