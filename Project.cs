using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace IUL
{
    class Project
    {
        private String _id;
        private String _name;
        private Boolean _capitalOrLinear;
        private Surveys _surveys;
        private String _nameCustomer;
        private String _path;
        private Dictionary<Chapter, Boolean> _chaptersDict;
        private Employee _GIP;
        private Employee _Nkontr;
        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public Boolean CapitalOrLinear
        {
            get { return _capitalOrLinear; }
            set { _capitalOrLinear = value; }

        }
        /// <summary>
        /// Инженерно-геодезические изыскания
        /// </summary>
        public String NameCustomer
        {
            get { return _nameCustomer; }
            set { _nameCustomer = value; }

        }
        public Employee GIP 
        {
            get { return _GIP; }
            set { _GIP = new Employee(value); }
        }
        public Employee Nkontr 
        {
            get { return _Nkontr; }
            set { _Nkontr = new Employee(value); }
        }
        public String Path
        {
            get { return _path; }
            set { _path = value; }

        }
        public Surveys Surveys 
        {
            get { return _surveys;}
            set { _surveys = value;}
        }
        public Project() 
        {
            Surveys = new Surveys(true, true, true, true, true, true, true);
        }
        public Project(String nameProject)
        {
            try 
            {
                _name = nameProject;
                _chaptersDict = new Dictionary<Chapter, Boolean>(30);
                String query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[PROJECTS].[PROJECT_ID]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_CAPITAL_OR_LINEAR]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_GEODETI_SURVEYS]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_GEOLOGICAL_SURVEYS_SURVEYS]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_ENVIRONMENTAL_SURVEYS]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_METEOROLOGICAL_SURVEYS]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_GEOTECHNICAL_SURVEYS]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_ARCHAEOLOGICAL_SURVEYS]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_INSPECTION_OF_TECHNICAL_CONDITION]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_CUSTOMER]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_PATH_FOLDER]" +
                    ",[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME]" +
                    ",[IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME]" +
                    "FROM [IUL].[dbo].[PROJECTS]" +
                    "JOIN [IUL].[dbo].[EMPLOYEES]" +
                    "ON [IUL].[dbo].[PROJECTS].[PROJECT_GIP_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID] " +
                    "OR [IUL].[dbo].[PROJECTS].[PROJECT_N_KONTR_ID] = [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_ID]" +
                    "WHERE [IUL].[dbo].[PROJECTS].[PROJECT_NAME] LIKE @nameProject;";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@nameProject", SqlDbType.Text).Value = _name;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                _id = reader.GetValue(0).ToString().Trim();
                                _capitalOrLinear = Convert.ToBoolean(reader.GetValue(1));
                                _surveys = new Surveys(
                                    Convert.ToBoolean(reader.GetValue(2)), Convert.ToBoolean(reader.GetValue(3)),
                                    Convert.ToBoolean(reader.GetValue(4)), Convert.ToBoolean(reader.GetValue(5)), 
                                    Convert.ToBoolean(reader.GetValue(6)), Convert.ToBoolean(reader.GetValue(7)), 
                                    Convert.ToBoolean(reader.GetValue(8)));
                                _nameCustomer = reader.GetValue(9).ToString().Trim();
                                _path = reader.GetValue(10).ToString().Trim();
                                _GIP = new Employee(reader.GetValue(11).ToString().Trim());
                                _Nkontr = new Employee(reader.GetValue(12).ToString().Trim());
                            }
                        }
                    }
                }
                query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[CHAPTERS].[CHAPTER_NAME]" +
                    "FROM [IUL].[dbo].[CHAPTERS]" +
                    "WHERE [IUL].[dbo].[CHAPTERS].[CHAPTER_PROJECT_ID] = @projectId; ";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@projectId", SqlDbType.NChar).Value = _id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String chapterName = reader.GetValue(0).ToString().Trim();
                                _chaptersDict.Add(new Chapter(_id, chapterName), true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("projectException " + ex.Message,ex);
            }
        }
        public void Insert()
        {
            try
            {
                String query = "USE [IUL];" +
               "INSERT INTO [IUL].[dbo].[PROJECTS]([PROJECT_ID]" +
               ",[PROJECT_NAME]" +
               ",[PROJECT_CAPITAL_OR_LINEAR]" +
               ",[PROJECT_GEODETI_SURVEYS]" +
               ",[PROJECT_GEOLOGICAL_SURVEYS_SURVEYS]" +
               ",[PROJECT_ENVIRONMENTAL_SURVEYS]" +
               ",[PROJECT_METEOROLOGICAL_SURVEYS]" +
               ",[PROJECT_GEOTECHNICAL_SURVEYS]" +
               ",[PROJECT_ARCHAEOLOGICAL_SURVEYS]" +
               ",[PROJECT_INSPECTION_OF_TECHNICAL_CONDITION]" +
               ",[PROJECT_CUSTOMER]" +
               ",[PROJECT_GIP_ID]" +
               ",[PROJECT_N_KONTR_ID]" +
               ",[PROJECT_PATH_FOLDER]) " +
               "VALUES(@id, @name, " +
               "@capitalOrLinear, @isGeodetiSurveys," +
               "@isGeologicalSurveysSurveys, @isEnvironmentalSurveys," +
               "@isMeteorologicalSurveys, @isGeotechnicalSurveys, " +
               "@isArchaeologicalSurveys, @isInspectionOfTechnicalCondition, " +
               "@nameCustomer, @idGIP, " +
               "@idNkont, @path);";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = _id;
                    command.Parameters.Add("@name", SqlDbType.Text).Value = _name;
                    command.Parameters.Add("@capitalOrLinear", SqlDbType.Bit).Value = _capitalOrLinear;
                    command.Parameters.Add("@isGeodetiSurveys", SqlDbType.Bit).Value = Surveys.IsGeodetiSurveys;
                    command.Parameters.Add("@isGeologicalSurveysSurveys", SqlDbType.Bit).Value =
                        Surveys.IsGeologicalSurveysSurveys;
                    command.Parameters.Add("@isEnvironmentalSurveys", SqlDbType.Bit).Value = Surveys.IsEnvironmentalSurveys;
                    command.Parameters.Add("@isMeteorologicalSurveys", SqlDbType.Bit).Value = Surveys.IsMeteorologicalSurveys;
                    command.Parameters.Add("@isGeotechnicalSurveys", SqlDbType.Bit).Value = Surveys.IsGeotechnicalSurveys;
                    command.Parameters.Add("@isArchaeologicalSurveys", SqlDbType.Bit).Value = Surveys.IsArchaeologicalSurveys;
                    command.Parameters.Add("@isInspectionOfTechnicalCondition", SqlDbType.Bit).Value =
                        Surveys.IsInspectionOfTechnicalCondition;
                    command.Parameters.Add("@nameCustomer", SqlDbType.Text).Value = _nameCustomer;
                    command.Parameters.Add("@idGIP", SqlDbType.Int).Value = _GIP.Id;
                    command.Parameters.Add("@idNkont", SqlDbType.Int).Value = _Nkontr.Id;
                    command.Parameters.Add("@path", SqlDbType.Text).Value = _path;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public void RolloutIULsForProject(String dateSigning, String pathToMainFile)
        {
            try
            {
                float scale = 0.09f;
                BaseFont baseFont = BaseFont.CreateFont(@"C:\\Windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11.5f, iTextSharp.text.Font.NORMAL);
                foreach(var chapter in this._chaptersDict) 
                {
                    if (!chapter.Value) continue;
                    String nameFile = chapter.Key.NameFileChapter
                        .Remove(chapter.Key.NameFileChapter.Length - 4, 4);
                    nameFile += "-УЛ.pdf";
                    String path = pathToMainFile + "\\" + nameFile;
                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4);
                        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fileStream);
                        doc.Open();
                        PdfPTable table = new PdfPTable(4);

                        PdfPCell cell = new PdfPCell(new Phrase("Номер п/п", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Обозначение документа", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Наименование документа", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Номер последнего изменения (версии)", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(chapter.Key.Id, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase(chapter.Key.ChapterName, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("1", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("MD5", font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(chapter.Key.MD5, font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("CRC32", font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(chapter.Key.CRC32, font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Наименование файла", font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Дата и время последнего изменения файла", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Размер файла, байт", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase(chapter.Key.NameFileChapter, font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(chapter.Key.DateChange, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(chapter.Key.SizeFileChapter.ToString(), font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Характер работы", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Фамилия", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Подпись", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Дата подписания", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        //ГИП
                        cell = new PdfPCell(new Phrase("ГИП", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(_GIP.Surname, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        iTextSharp.text.Image signGip = iTextSharp.text.Image.GetInstance(_GIP.Sign, BaseColor.WHITE);
                        cell = new PdfPCell(signGip);
                        signGip.ScaleAbsolute(signGip.Width * scale, signGip.Height * scale);
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(dateSigning, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        //foreach (var author in chapter.Key.Authors()) 
                        //{
                        //    cell = new PdfPCell(new Phrase(author.Key.AbbreviatedName, font));
                        //    cell.Colspan = 1;
                        //    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        //    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        //    table.AddCell(cell);
                        //    cell = new PdfPCell(new Phrase(author.Value.Surname, font));
                        //    cell.Colspan = 1;
                        //    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        //    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        //    table.AddCell(cell);
                        //    iTextSharp.text.Image signAuthor = iTextSharp.text.Image.GetInstance(author.Value.Sign, BaseColor.WHITE);
                        //    cell = new PdfPCell(signAuthor);
                        //    signAuthor.ScaleAbsolute(signGip.Width * scale, signGip.Height * scale);
                        //    cell.Colspan = 1;
                        //    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        //    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        //    table.AddCell(cell);
                        //    cell = new PdfPCell(new Phrase(dateSigning, font));
                        //    cell.Colspan = 1;
                        //    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        //    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        //    table.AddCell(cell);
                        //}
                        foreach (var author in chapter.Key.Authors())
                        {
                            Employee employee = new Employee(author.EmployeeId);
                            Role role = new Role(author.RoleId);
                            cell = new PdfPCell(new Phrase(role.AbbreviatedName, font));
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                            cell = new PdfPCell(new Phrase(employee.Surname, font));
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                            iTextSharp.text.Image signAuthor = iTextSharp.text.Image.GetInstance(employee.Sign, BaseColor.WHITE);
                            cell = new PdfPCell(signAuthor);
                            signAuthor.ScaleAbsolute(signGip.Width * scale, signGip.Height * scale);
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                            cell = new PdfPCell(new Phrase(dateSigning, font));
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                        }
                        //Н.КОНТР
                        cell = new PdfPCell(new Phrase("Н. контр", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(_Nkontr.Surname, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        iTextSharp.text.Image signNkontr = iTextSharp.text.Image.GetInstance(_Nkontr.Sign, BaseColor.WHITE);
                        cell = new PdfPCell(signNkontr);
                        signNkontr.ScaleAbsolute(signGip.Width * scale, signGip.Height * scale);
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(dateSigning, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Информационно-удостоверяющий лист", font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(chapter.Key.Id + "-УЛ", font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        PdfPTable subTable = new PdfPTable(2);
                        PdfPCell subCell = new PdfPCell(new Phrase("Лист", font));
                        subCell.Colspan = 1;
                        subCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        subCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        subTable.AddCell(subCell);
                        subCell = new PdfPCell(new Phrase("Листов", font));
                        subCell.Colspan = 1;
                        subCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        subCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        subTable.AddCell(subCell);
                        subCell = new PdfPCell(new Phrase("", font));
                        subCell.Colspan = 1;
                        subCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        subCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        subTable.AddCell(subCell);
                        subCell = new PdfPCell(new Phrase("   ", font));
                        subCell.Colspan = 1;
                        subCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        subCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        subTable.AddCell(subCell);
                        cell = new PdfPCell(subTable);
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        doc.Open();
                        doc.Add(table);
                        doc.Close();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void ChangeSelectedRolloutChapters(String chapterName) 
        {
            foreach(var chapter in _chaptersDict.Keys.ToList()) 
            {
                if (chapter.ChapterName.Equals(chapterName)) 
                {
                    _chaptersDict[chapter] = !_chaptersDict[chapter];
                }
            }
        }
        public IEnumerable<KeyValuePair<Chapter, Boolean>> Chapters()
        {
            foreach (var chapter in _chaptersDict)
            {
                yield return new KeyValuePair<Chapter, Boolean>(chapter.Key, chapter.Value);
            }
        }
        public void Update() 
        {
            try 
            {
                String query = "USE IUL; " +
                    "UPDATE[IUL].[dbo].[PROJECTS] " +
                    "SET[IUL].[dbo].[PROJECTS].[PROJECT_CUSTOMER] = @nameCustomer, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_NAME] = @name, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_GIP_ID] = @idGIP, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_N_KONTR_ID] = @idNkont, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_GEODETI_SURVEYS] = @isGeodetiSurveys, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_GEOLOGICAL_SURVEYS_SURVEYS] = @isGeologicalSurveysSurveys, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_ENVIRONMENTAL_SURVEYS] = @isEnvironmentalSurveys, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_METEOROLOGICAL_SURVEYS] = @isMeteorologicalSurveys, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_GEOTECHNICAL_SURVEYS] = @isGeotechnicalSurveys, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_ARCHAEOLOGICAL_SURVEYS] = @IsArchaeologicalSurveys, " +
                    "[IUL].[dbo].[PROJECTS].[PROJECT_INSPECTION_OF_TECHNICAL_CONDITION] = @isInspectionOfTechnicalCondition " +
                    "WHERE[IUL].[dbo].[PROJECTS].[PROJECT_ID] = @id;";
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = _id;
                    command.Parameters.Add("@name", SqlDbType.Text).Value = _name;
                    command.Parameters.Add("@isGeodetiSurveys", SqlDbType.Bit).Value = Surveys.IsGeodetiSurveys;
                    command.Parameters.Add("@isGeologicalSurveysSurveys", SqlDbType.Bit).Value =
                        Surveys.IsGeologicalSurveysSurveys;
                    command.Parameters.Add("@isEnvironmentalSurveys", SqlDbType.Bit).Value = Surveys.IsEnvironmentalSurveys;
                    command.Parameters.Add("@isMeteorologicalSurveys", SqlDbType.Bit).Value = Surveys.IsMeteorologicalSurveys;
                    command.Parameters.Add("@isGeotechnicalSurveys", SqlDbType.Bit).Value = Surveys.IsGeotechnicalSurveys;
                    command.Parameters.Add("@isArchaeologicalSurveys", SqlDbType.Bit).Value = Surveys.IsArchaeologicalSurveys;
                    command.Parameters.Add("@isInspectionOfTechnicalCondition", SqlDbType.Bit).Value =
                        Surveys.IsInspectionOfTechnicalCondition;
                    command.Parameters.Add("@nameCustomer", SqlDbType.Text).Value = _nameCustomer;
                    command.Parameters.Add("@idGIP", SqlDbType.Int).Value = _GIP.Id;
                    command.Parameters.Add("@idNkont", SqlDbType.Int).Value = _Nkontr.Id;
                    command.ExecuteNonQuery();
                }

            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
        

        
