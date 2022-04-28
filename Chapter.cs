using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using Force.Crc32;
using System.Linq;
using Aspose.Pdf;
namespace IUL
{
    class Chapter
    {
        private String _chapterId;
        private String _projectId;
        private String _chapterName;
        private String _nameFileChapter;
        private String _pathToFileChapter;
        private Int32 _numberChapter;
        private List<Performer> _authors;
        private FileInfo _fileInfo;


        public String PathToFileChapter 
        {
            get { return _pathToFileChapter; }
            set { _pathToFileChapter = value; }
        }
        public Int64 SizeFileChapter 
        {
            get { return _fileInfo.Length; }
        }
        public String DateChange 
        {
            get
            {
                Document pdfDocument = new Document(_pathToFileChapter);
                DocumentInfo docInfo = pdfDocument.Info;
                return docInfo.ModDate.ToShortDateString()+ " " + docInfo.ModDate.ToLongTimeString();
            }
        }
        public String MD5 
        {
            get 
            {
                String MD5 = "";
                using (FileStream fs = System.IO.File.OpenRead(_pathToFileChapter))
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    Byte[] fileData = new byte[fs.Length];
                    fs.Read(fileData, 0, (Int32)fs.Length);
                    Byte[] checkSum = md5.ComputeHash(fileData);
                    MD5 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                }
                return MD5;
            }
        }
        public String CRC32 
        {
            get 
            {
                Force.Crc32.Crc32Algorithm crc32 = new Force.Crc32.Crc32Algorithm();
                String hash = String.Empty;
                using (FileStream fs = File.OpenRead(_pathToFileChapter))
                {
                    foreach (Byte b in crc32.ComputeHash(fs))
                    {
                        hash += b.ToString("x2").ToLower();
                    }
                }
                return hash;
            }
        }
        public String Id
        {
            get { return _chapterId; }
            set { _chapterId = value; }
        }
        public String ProjectId
        {
            get { return _projectId; }
            set { _projectId = value; }
        }
        public String ChapterName
        {
            get { return _chapterName; }
            set { _chapterName = value; }
        }
        public String NameFileChapter
        {
            get { return _nameFileChapter; }
            set { _nameFileChapter = value; }
        }
        public Int32 NumberChapter 
        {
            get { return _numberChapter; }
            set { _numberChapter = value; }
        }       
        public Chapter()
        {
            _chapterId = "";
            _projectId = "";
            _chapterName = "";
            _nameFileChapter = "";
        }
        public Chapter(String projectId, String chapterName) 
        {
            try 
            {
                _authors = new List<Performer>();
                _projectId = projectId;
                _chapterName = chapterName;
                //инциализирую поля шифра раздела и имени файла
                String query = "USE IUL;" +
                "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_ID]" +
                ",[IUL].[dbo].[CHAPTERS].[CHAPTER_FILE_NAME]" +
                "FROM [IUL].[dbo].[CHAPTERS]" +
                "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME] LIKE @chapterName AND [IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@chapterName", SqlDbType.Text).Value = _chapterName;
                    command.Parameters.Add("@projectId", SqlDbType.NChar).Value = _projectId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                _chapterId = reader.GetValue(0).ToString().Trim();
                                _pathToFileChapter = reader.GetValue(1).ToString().Trim();
                                _nameFileChapter = _pathToFileChapter.Split('\\').Last();
                            }
                        }
                    }
                }
                //инциализирую состав авторского коллектива для раздела
                query = "USE IUL;" +
                    "SELECT[IUL].[dbo].[PERFORMERS].[PERFORMER_ID] " +
                    "FROM[IUL].[dbo].[PERFORMERS] " +
                    "WHERE[IUL].[dbo].[PERFORMERS].[PERFORMER_CHAPTER_ID] = @chapterId; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@chapterId", System.Data.SqlDbType.NChar).Value = _chapterId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Int32 performerId = Convert.ToInt32(reader.GetValue(0));
                                _authors.Add(new Performer(performerId));
                            }
                        }
                    }
                }
                _fileInfo = new FileInfo(_pathToFileChapter);
            }
            catch (Exception ex)
            {
                throw new Exception("ChapterСonstructorException " + ex.Message, ex);
            }
        }
        public void Insert()
        {
            try 
            {
               String query = "USE IUL;" +
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
                    command.Parameters.Add("@chapterId", SqlDbType.NChar).Value = _chapterId;
                    command.Parameters.Add("@projectId", SqlDbType.NChar).Value = _projectId;
                    command.Parameters.Add("@chapterName", SqlDbType.Text).Value = _chapterName;
                    command.Parameters.Add("@pathFileChapter", SqlDbType.Text).Value = _pathToFileChapter;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public IEnumerable<Performer> Authors() 
        {
            foreach(var author in _authors) 
            {
                yield return author;
            }
        }
        public void Update() 
        {
            try
            {
                String query = "USE IUL;" +
                    "UPDATE[IUL].[dbo].[CHAPTERS]" +
                    "SET[IUL].[dbo].[CHAPTERS].[CHAPTER_NAME] = @chapterName, " +
                    "[IUL].[dbo].[CHAPTERS].[CHAPTER_FILE_NAME] = @path " +
                    "WHERE[IUL].[dbo].[CHAPTERS].[CHAPTER_ID] = @id; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@chapterName", SqlDbType.Text).Value = _chapterName;
                    command.Parameters.Add("@path", SqlDbType.Text).Value = _pathToFileChapter;
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = _chapterId;
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
