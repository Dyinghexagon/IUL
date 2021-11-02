using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
namespace IUL
{
    class Chapter
    {
        private string _nameChapter;
        private string _nameFile;
        private List<KeyValuePair<string, Employee>> _authorsChapter;
        private string _MD5;
        private string _dateChange;
        private long _sizeFile;
        public string NameChapter 
        {
            get { return _nameChapter; }
        }
        public string NameFile 
        {
            get { return _nameFile; }
        }
        public string MD5 
        {
            get { return _MD5; }
        }
        public string DateChange 
        {
            get { return _dateChange; }
        }
        public long SizeFile 
        {
            get { return _sizeFile; }
        }
        public Chapter(string codeChapter, string codeProject)
        {
            this._authorsChapter = new List<KeyValuePair<string, Employee>>(4);
            this._nameFile = GetFileName(codeChapter);
            InitializationNameChapter(codeChapter);
            InitializationNameFile(codeChapter);
            InitializationAuthorsChapter(codeChapter);
            InitializationFileInfo(codeChapter, codeProject);
        }
        public ref List<KeyValuePair<string, Employee>> GetAuthorChapter() 
        {
            return ref this._authorsChapter;
        }
        private void InitializationAuthorsChapter(string codeChapter) 
        {
            string query = "USE IUL;" +
                "SELECT" +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME]," +
                "[IUL].[dbo].[ROLES].[ROLE_ABBREVIATED _NAME]" +
                "FROM [IUL].[dbo].[PERFORMERS]" +
                "JOIN [IUL].[dbo].[EMPLOYEES]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_EMPLOYEE_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]" +
                "JOIN [IUL].[dbo].[ROLES]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_ROLE_ID] = [IUL].[dbo].[ROLES].[ROLE_ID]" +
                "WHERE [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = @codeChapter" + ";";
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
                            string authorSurname = reader.GetValue(0).ToString().Trim();
                            string authorRole = reader.GetValue(1).ToString().Trim();
                            this._authorsChapter.Add(new KeyValuePair<string, Employee>(authorRole, new Employee(authorSurname)));
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
                            this._nameFile = nameFile;
                        }
                    }
                }
            }
        }
        private void InitializationFileInfo(string codeChapter, string codeProject) 
        {
            string path = GetPathMainFolder(codeProject) + "\\" + this._nameFile;
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                this._MD5 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            }
            FileInfo fileInfo = new FileInfo(path);
            this._sizeFile = fileInfo.Length;
            this._dateChange = fileInfo.LastWriteTime.ToShortDateString() + " " + fileInfo.LastWriteTime.ToLongTimeString();
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
