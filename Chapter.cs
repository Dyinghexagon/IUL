using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using Force.Crc32;
namespace IUL
{
    class Chapter
    {
        private string _chapterId;
        private string _projectId;
        private string _chapterName;
        private string _nameFileChapter;
        private string _pathToFileChapter;
        private List<KeyValuePair<string, Employee>> _authorsChapter;
        private FileInfo _fileInfo;

        public long SizeFileChapter 
        {
            get { return this._fileInfo.Length; }
        }
        public string DateChange 
        {
            get { return this._fileInfo.LastWriteTime.ToShortDateString() + " " + this._fileInfo.LastWriteTime.ToLongTimeString(); }
        }
        public string MD5 
        {
            get 
            {
                string path = Project.GetPathMainFolder(this._projectId) + "\\" + this._nameFileChapter;
                string MD5 = "";
                using (FileStream fs = System.IO.File.OpenRead(path))
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] fileData = new byte[fs.Length];
                    fs.Read(fileData, 0, (int)fs.Length);
                    byte[] checkSum = md5.ComputeHash(fileData);
                    MD5 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                }
                return MD5;
            }
        }
        public string CRC32 
        {
            get 
            {
                Force.Crc32.Crc32Algorithm crc32 = new Force.Crc32.Crc32Algorithm();
                String hash = String.Empty;
                string path = Project.GetPathMainFolder(this._projectId) + "\\" + this._nameFileChapter;
                using (FileStream fs = File.OpenRead(path))
                {
                    foreach (byte b in crc32.ComputeHash(fs))
                    {
                        hash += b.ToString("x2").ToLower();
                    }
                }
                return hash;
            }
        }
        public string ChapterId
        {
            get { return this._chapterId; }
            set { this._chapterId = value; }
        }
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }
        public string ChapterName
        {
            get { return this._chapterName; }
            set { this._chapterName = value; }
        }
        public string NameFileChapter
        {
            get { return this._nameFileChapter; }
            set { this._nameFileChapter = value; }
        }
        public int CountAuthorChapter 
        {
            get { return this._authorsChapter.Count; }
        }
        public KeyValuePair<string, Employee> this[int index] 
        {
            get { return this._authorsChapter[index]; }
        }
        Chapter(string chapterId, string projectId, string chapterName, string nameFileChapter)
        {
            this._chapterId = chapterId;
            this._projectId = projectId;
            this._chapterName = chapterName;
            this._nameFileChapter = nameFileChapter;
        }
        public Chapter()
        {
            this._chapterId = "";
            this._projectId = "";
            this._chapterName = "";
            this._nameFileChapter = "";
        }
        public Chapter(string projectId, string chapterName) 
        {
            this._authorsChapter = new List<KeyValuePair<string, Employee>>(4);
            this._projectId = projectId;
            this._chapterName = chapterName;
            this.InitializeChapter();//инциализирую поля шифра раздела и имени файла
            this.InitializeAuthorsChapter();//инциализирую состав авторского коллектива для раздела
            this._pathToFileChapter =  Project.GetPathMainFolder(this._projectId) + "\\" + this._nameFileChapter;
            this._fileInfo = new FileInfo(this._pathToFileChapter);
        }
        public void InitializeChapter() 
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_ID]" +
                ",[IUL].[dbo].[CHAPTERS].[CHAPTER_FILE_NAME]" +
                "FROM [IUL].[dbo].[CHAPTERS]" +
                "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME] LIKE @chapterName AND[IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId; ";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@chapterName", SqlDbType.Text).Value = this._chapterName;
                command.Parameters.Add("@projectId", SqlDbType.NChar).Value = this._projectId;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            this._chapterId = reader.GetValue(0).ToString().Trim();
                            this._nameFileChapter = reader.GetValue(1).ToString().Trim();
                        }
                    }
                }
            }
        }
        public bool InsertNewChapter()
        {
            string query = "USE IUL;" +
                           "INSERT INTO[IUL].[dbo].[CHAPTERS]" +
                           "([CHAPTER_ID]" +
                           ",[CHAPTER_PROJECT_ID]" +
                           ",[CHAPTER_NAME]" +
                           ",[CHAPTER_FILE_NAME]) " +
                           "VALUES" +
                           "(@chapterId" +
                           ", @projectId" +
                           ", @chapterName" +
                           ", @nameFileChapter); ";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@chapterId", SqlDbType.NChar).Value = this._chapterId;
                command.Parameters.Add("@projectId", SqlDbType.NChar).Value = this._projectId;
                command.Parameters.Add("@chapterName", SqlDbType.Text).Value = this._chapterName;
                command.Parameters.Add("@nameFileChapter", SqlDbType.Text).Value = this._nameFileChapter;
                command.ExecuteNonQuery();
            }
            return true;
        }
        public string[] GetChaptersArray()
        {
            int countChapters = this.GetCountChaptersInProject();
            string[] chapters = new string[countChapters];
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME] " +
                "FROM [IUL].[dbo].[CHAPTERS] " +
                "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@projectId", System.Data.SqlDbType.NChar).Value = this._projectId;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        for (int i = 0; reader.Read(); i++)
                        {
                            chapters[i] = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            return chapters;
        }
        private int GetCountChaptersInProject() 
        {

            int count = 0;
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                string query = "USE IUL;" +
                    "SELECT COUNT(*) FROM[IUL].[dbo].[CHAPTERS] WHERE[IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId;";
                using (SqlCommand getchild = new SqlCommand(query, connection)) //SQL queries
                {
                    getchild.Parameters.Add("@projectId", System.Data.SqlDbType.NChar).Value = this._projectId;
                    count = Convert.ToInt32(getchild.ExecuteScalar());
                }
            }
            return count;
        }
        private void InitializeAuthorsChapter() 
        {
            string query = "USE IUL;" +
                "SELECT" +
                "[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME]," +
                "[IUL].[dbo].[ROLES].[ROLE_ABBREVIATED _NAME]" +
                "FROM [IUL].[dbo].[PERFORMERS]" +
                "JOIN [IUL].[dbo].[EMPLOYEES]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_EMPLOYEE_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]" +
                "JOIN [IUL].[dbo].[ROLES]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_ROLE_ID] = [IUL].[dbo].[ROLES].[ROLE_ID]" +
                "WHERE [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = @chapterId;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@chapterId", System.Data.SqlDbType.NChar).Value = this._chapterId;
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
    }
}
