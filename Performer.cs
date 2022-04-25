using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class Performer
    {
        private String _chapterId;
        private Int32 _employeeId;
        private Int32 _roleId;

        public String ChapterId 
        {
            get { return _chapterId; }
            set { _chapterId = value; }
        }
        public Int32 EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        public Int32 RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        public Performer() 
        {
            _chapterId = "";
            _employeeId = 0;
            _roleId = 0;
        }
        public void Insert() 
        {
            try 
            {
                String query = "USE IUL;" +
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
                    command.Parameters.Add("@chapterId", System.Data.SqlDbType.NChar).Value = _chapterId;
                    command.Parameters.Add("@employeeId", System.Data.SqlDbType.Int).Value = _employeeId;
                    command.Parameters.Add("@roleId", System.Data.SqlDbType.Int).Value = _roleId;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
