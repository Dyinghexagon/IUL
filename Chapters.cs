using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class Chapters
    {
        private static string _pathMainFolder;
        private string _nameChapter;
        private string _nameFile;
        private List<string> _authorsChapter;
        private string _MD5;
        private DateTime _dateChange;
        private int _sizeFile;
        public string NameChapter 
        {
            get { return _nameChapter; }
            set { _nameChapter = value; }
        }
        public string NameFile 
        {
            get { return _nameFile; }
            set { _nameFile = value; }
        }
        public Chapters(string codeChapter, string codeProject)
        {
            _authorsChapter = new List<string>(20);
            InitializationNameChapter(codeChapter);
            InitializationNameFile(codeChapter);
            InitializationAuthorsChapter(codeChapter);
            InitializationMD5(codeChapter, codeProject);
        }
        private void InitializationAuthorsChapter(string codeChapter) 
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME] " +
                "FROM [IUL].[dbo].[PERFORMERS] " +
                "JOIN" +
                "[IUL].[dbo].[EMPLOYEES] " +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_EMPLOYEE_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID] " +
                "WHERE[IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = @codeChapter" + ";";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter codeChapterParam = new SqlParameter("@codeChapter", codeChapter);
                command.Parameters.Add(codeChapterParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this._authorsChapter.Add(reader.GetValue(0).ToString().Trim());
                        }
                    }
                }
            }
        }
        private void InitializationNameChapter(string codeChapter) 
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME]" +
                "FROM [IUL].[dbo].[PERFORMERS]" +
                "JOIN [IUL].[dbo].[CHAPTERS]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = [IUL].[dbo].[CHAPTERS].[CHAPTER_ID]" +
                "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_ID] = @codeChapter" + ";";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter codeChapterParam = new SqlParameter("@codeChapter", codeChapter);
                command.Parameters.Add(codeChapterParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this._nameChapter = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
        }
        private void InitializationNameFile(string codeChapter)
        {
            string query = "USE IUL; " +
                "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_FILE_NAME]" +
                "FROM [IUL].[dbo].[PERFORMERS]" +
                "JOIN [IUL].[dbo].[CHAPTERS]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = [IUL].[dbo].[CHAPTERS].[CHAPTER_ID]" +
                "WHERE[IUL].[dbo].[CHAPTERS].[CHAPTER_ID] = @codeChapter" + ";";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter codeChapterParam = new SqlParameter("@codeChapter", codeChapter);
                command.Parameters.Add(codeChapterParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string nameFile = reader.GetValue(0).ToString().Trim();
                            nameFile += ".pdf";
                            this._nameFile = nameFile;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Дописать отсюда!!!!!
        /// </summary>
        /// <param name="codeChapter"></param>
        /// <param name="codeProject"></param>
        private void InitializationMD5(string codeChapter, string codeProject) 
        {
            string path = GetPathMainFolder(codeProject) + "\\" + GetFileName(codeChapter) + ".pdf";
            Console.WriteLine(path);
        }
        private string GetFileName(string codeChapter) 
        {
            string fileName = "";
            string query = "USE IUL;" +
                "SELECT[IUL].[dbo].[CHAPTERS].[CHAPTER_FILE_NAME]" +
                "FROM [IUL].[dbo].[CHAPTERS]" +
                "WHERE[IUL].[dbo].[CHAPTERS].[CHAPTER_ID] = @codeChapter" + ";";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter codeChapterParam = new SqlParameter("@codeChapter", codeChapter);
                command.Parameters.Add(codeChapterParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            fileName = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            return fileName;
        }
        private string GetPathMainFolder(string codeProject)
        {
            string path = "";
            string query = "USE IUL;" +
                "SELECT[IUL].[dbo].[PROJECTS].[PROJECT_PATH_FOLDER]" +
                "FROM [IUL].[dbo].[PROJECTS] " +
                "WHERE[IUL].[dbo].[PROJECTS].[PROJECT_ID] = @codeProject" + ";";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter codeChapterParam = new SqlParameter("@codeProject", codeProject);
                command.Parameters.Add(codeChapterParam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            path = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            return path;
        }
    }
}
