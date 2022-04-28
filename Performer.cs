using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class Performer
    {
        private Int32 _id;
        private String _chapterId;
        private Int32 _employeeId;
        private Int32 _roleId;

        public Int32 Id 
        {
            get { return _id; }
            set { _id = value; }
        }
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
            ChapterId = "";
            EmployeeId = 1;
            RoleId = 1;
        }
        public Performer(Int32 id) 
        {
            Id = id;
            try
            {
                String query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID], " +
                    "[IUL].[dbo].[PERFORMERS].[PERFORMER_EMPLOYEE_ID], " +
                    "[IUL].[dbo].[PERFORMERS].[PERFORMER_ROLE_ID] " +
                    "FROM[IUL].[dbo].[PERFORMERS] " +
                    "WHERE[IUL].[dbo].[PERFORMERS].[PERFORMER_ID] = @id; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if(reader.Read())
                            {
                                ChapterId = reader.GetValue(0).ToString().Trim();
                                EmployeeId = Convert.ToInt32(reader.GetValue(1));
                                RoleId = Convert.ToInt32(reader.GetValue(2));
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
        public static void Update(String chapterId, List<KeyValuePair<Role, Employee>> authors) 
        {
            try
            {
                String query = "USE IUL;" +
                    "DELETE FROM[IUL].[dbo].[PERFORMERS]" +
                    "WHERE[IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = @chapterId; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@chapterId", System.Data.SqlDbType.NChar).Value = chapterId;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception delete old performer for update", ex);
            }
            try 
            {
                foreach(var author in authors) 
                {
                    Performer performer = new Performer();
                    performer.ChapterId = chapterId;
                    performer.EmployeeId = author.Value.Id;
                    performer.RoleId = author.Key.Id;
                    performer.Insert();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception insert new performer for update", ex);
            }
        }
    }
}
