using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace IUL
{
    class IULs
    {

        private Employee _GIP;
        private Employee _NKontr;
        /// <summary>
        /// Словарь _chapters хранит информацию об том или ином разделе.
        /// Ключом выступает код раздела.
        /// Значением выступает объект класса IUL.
        /// </summary>
        private Dictionary<string, Chapter> _chapters;
        public Employee GIP 
        {
            get { return _GIP; }
        }
        public Employee Nkontr 
        {
            get { return _NKontr; }
        }
        
        public IULs(string codeProject) 
        {
            int countChapters = DbProviderFactories.GetCountСolumnsChapters(codeProject);
            HashSet<string> chaptersCode = GetChaptersCode(countChapters, codeProject);
            _chapters = new Dictionary<string, Chapter>(countChapters);
            InitializationGip(codeProject);
            InitializationNkontr(codeProject);
            foreach(var chapterCode in chaptersCode) 
            {
                _chapters.Add(chapterCode, new Chapter(chapterCode, codeProject));
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
            string gip = "";
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
                            gip = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            this._GIP = new Employee(gip);
        }
        private void InitializationNkontr(string codeProject)
        {
            string query = "USE IUL;" +
                "SELECT [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_FNAME]" +
                "FROM [IUL].[dbo].[PROJECTS]" +
                "JOIN [IUL].[dbo].[EMPLOYEES]" +
                "ON [IUL].[dbo].[PROJECTS].[PROJECT_N_KONTR_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]" +
                "WHERE[IUL].[dbo].[PROJECTS].[PROJECT_ID] = @codeProject" + ";";
            string nkont = "";
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
                            nkont = reader.GetValue(0).ToString().Trim();
                        }
                    }
                }
            }
            this._NKontr = new Employee(nkont);
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
        public ref Dictionary<string, Chapter> GetChapters() 
        {
            return ref this._chapters;
        } 
    }
}
