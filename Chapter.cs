using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class Chapter
    {
        private string _chapterId;
        private string _projectId;
        private string _chapterName;
        private string _nameFileChapter;

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
    }
}
