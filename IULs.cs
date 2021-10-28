using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class IULs
    {

        private string _GIP;
        private string _NKontr;
        /// <summary>
        /// Словарь _chapters хранит информацию об том или ином разделе.
        /// Ключом выступает код раздела.
        /// Значением выступает объект класса IUL.
        /// </summary>
        private Dictionary<string, Chapters> _chapters;
        public string GIP 
        {
            get { return _GIP; }
        }
        public string Nkontr 
        {
            get { return _NKontr; }
        }

        public IULs(string codeProject) 
        {
            int countChapters = DbProviderFactories.GetCountСolumnsChapters(codeProject);
            HashSet<string> chaptersCode = GetChaptersCode(countChapters, codeProject);
            _chapters = new Dictionary<string, Chapters>(countChapters);
            InitializationGip(codeProject);
            InitializationNkontr(codeProject);
            foreach(var chapterCode in chaptersCode) 
            {
                _chapters.Add(chapterCode, new Chapters(chapterCode, codeProject));
            }
        }
        private void InitializationGip(string codeProject) 
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME]" +
                "FROM [IUL].[dbo].[PROJECTS]" +
                "JOIN [IUL].[dbo].[EMPLOYEES]" +
                "ON [IUL].[dbo].[PROJECTS].[PROJECT_GIP_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]" +
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
                            this._GIP = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
        }
        private void InitializationNkontr(string codeProject)
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME]" +
                "FROM [IUL].[dbo].[PROJECTS]" +
                "JOIN [IUL].[dbo].[EMPLOYEES]" +
                "ON [IUL].[dbo].[PROJECTS].[PROJECT_N_KONTR_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]" +
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
                            this._NKontr = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
        }
        private HashSet<string> GetChaptersCode(int countChapters, string codeProject) 
        {
            HashSet<string> chaptersName = new HashSet<string>(countChapters);
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID]" +
                "FROM [IUL].[dbo].[PERFORMERS] " +
                "JOIN [IUL].[dbo].[CHAPTERS]" +
                "ON [IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = [IUL].[dbo].[CHAPTERS].[CHAPTER_ID]" +
                "WHERE [IUL].[dbo].[CHAPTERS].CHAPTER_PROJECT_ID = @codeProject" + ";";
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
                            chaptersName.Add(reader.GetValue(0).ToString().Trim());
                        }
                    }
                }
            }
            return chaptersName;
        }
        public ref Dictionary<string, Chapters> GetIULsValue() 
        {
            return ref this._chapters;
        } 
    }
}
