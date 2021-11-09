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
    }
}
