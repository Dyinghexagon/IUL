using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using Force.Crc32;
using System.Linq;
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


        public String PathToFileChapter 
        {
            get { return this._pathToFileChapter; }
            set { this._pathToFileChapter = value; }
        }
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
                string MD5 = "";
                using (FileStream fs = System.IO.File.OpenRead(this._pathToFileChapter))
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
                using (FileStream fs = File.OpenRead(this._pathToFileChapter))
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
        public Chapter()
        {
            this._chapterId = "";
            this._projectId = "";
            this._chapterName = "";
            this._nameFileChapter = "";
        }
        public Chapter(string projectId, string chapterName) 
        {
            try 
            {
                this._authorsChapter = new List<KeyValuePair<string, Employee>>(4);
                this._projectId = projectId;
                this._chapterName = chapterName;
                this.InitializeChapter();//инциализирую поля шифра раздела и имени файла
                this.InitializeAuthorsChapter();//инциализирую состав авторского коллектива для раздела
                this._fileInfo = new FileInfo(this._pathToFileChapter);
            }
            catch (Exception ex)
            {
                throw new Exception("ChapterException " + ex.Message, ex);
            }
        }
        public void InitializeChapter() 
        {
            try 
            {
                string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_ID]" +
                ",[IUL].[dbo].[CHAPTERS].[CHAPTER_FILE_NAME]" +
                "FROM [IUL].[dbo].[CHAPTERS]" +
                "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME] LIKE @chapterName AND [IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId; ";
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
                                this._pathToFileChapter = reader.GetValue(1).ToString().Trim();
                                this._nameFileChapter = this._pathToFileChapter.Split('\\').Last();
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
        public void InsertNewChapter()
        {
            try 
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
               ", @pathFileChapter); ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@chapterId", SqlDbType.NChar).Value = this._chapterId;
                    command.Parameters.Add("@projectId", SqlDbType.NChar).Value = this._projectId;
                    command.Parameters.Add("@chapterName", SqlDbType.Text).Value = this._chapterName;
                    command.Parameters.Add("@pathFileChapter", SqlDbType.Text).Value = this._pathToFileChapter;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        private void InitializeAuthorsChapter() 
        {
            try 
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static void InitializeComboBoxChapters(System.Windows.Forms.ComboBox fillingComboBox, string projectId) 
        {
            try 
            {
                int countChapters;
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    string queryCount = "USE IUL;" +
                        "SELECT COUNT(*) FROM[IUL].[dbo].[CHAPTERS] WHERE[IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId;";
                    using (SqlCommand getchild = new SqlCommand(queryCount, connection)) //SQL queries
                    {
                        getchild.Parameters.Add("@projectId", System.Data.SqlDbType.NChar).Value = projectId;
                        countChapters = Convert.ToInt32(getchild.ExecuteScalar());
                    }
                }
                string[] chapters = new string[countChapters];
                string querySelect = "USE IUL;" +
                    "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME] " +
                    "FROM [IUL].[dbo].[CHAPTERS] " +
                    "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId;";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(querySelect, connection);
                    command.Parameters.Add("@projectId", System.Data.SqlDbType.NChar).Value = projectId;
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
                fillingComboBox.Items.AddRange(chapters);
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
