﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Net.Http.Headers;
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
        private Int32 _idGIP;
        private Int32 _idNkont;
        private String _path;
        private List<Chapter> _chapters;
        private Employee _GIP;
        private Employee _Nkontr;
        public String Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public String Name
        {
            get { return this._name; }
            set { this._name = value; }

        }
        public Boolean CapitalOrLinear
        {
            get { return this._capitalOrLinear; }
            set { this._capitalOrLinear = value; }

        }
        /// <summary>
        /// Инженерно-геодезические изыскания
        /// </summary>
        public String NameCustomer
        {
            get { return this._nameCustomer; }
            set { this._nameCustomer = value; }

        }
        public Int32 IdGIP
        {
            get { return this._idGIP; }
            set { this._idGIP = value; }

        }
        public Int32 IdNkont
        {
            get { return this._idNkont; }
            set { this._idNkont = value; }

        }
        public String Path
        {
            get { return this._path; }
            set { this._path = value; }

        }
        public Surveys Surveys 
        {
            get { return this._surveys;}
            set { this._surveys = value;}
        }
        public Project() 
        {
            Surveys = new Surveys(true, true, true, true, true, true, true);
        }
        public Project(String nameProject)
        {
            try 
            {
                this._name = nameProject;
                this._chapters = new List<Chapter>(30);
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
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_GIP_ID]" +
                    ",[IUL].[dbo].[PROJECTS].[PROJECT_N_KONTR_ID]" +
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
                    command.Parameters.Add("@nameProject", SqlDbType.Text).Value = this._name;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                this._id = reader.GetValue(0).ToString().Trim();
                                this._capitalOrLinear = Convert.ToBoolean(reader.GetValue(1));
                                this._surveys = new Surveys(
                                    Convert.ToBoolean(reader.GetValue(2)), Convert.ToBoolean(reader.GetValue(3)),
                                    Convert.ToBoolean(reader.GetValue(4)), Convert.ToBoolean(reader.GetValue(5)), 
                                    Convert.ToBoolean(reader.GetValue(6)), Convert.ToBoolean(reader.GetValue(7)), 
                                    Convert.ToBoolean(reader.GetValue(8)));
                                this._nameCustomer = reader.GetValue(9).ToString().Trim();
                                this._idGIP = Convert.ToInt32(reader.GetValue(10));
                                this._idNkont = Convert.ToInt32(reader.GetValue(11));
                                this._path = reader.GetValue(12).ToString().Trim();
                                this._GIP = new Employee(reader.GetValue(13).ToString().Trim());
                                this._Nkontr = new Employee(reader.GetValue(14).ToString().Trim());
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
                    command.Parameters.Add("@projectId", SqlDbType.NChar).Value = this._id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String chapterName = reader.GetValue(0).ToString().Trim();
                                this._chapters.Add(new Chapter(this._id, chapterName));
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
        public void InsertNewProject()
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
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = this._id;
                    command.Parameters.Add("@name", SqlDbType.Text).Value = this._name;
                    command.Parameters.Add("@capitalOrLinear", SqlDbType.Bit).Value = this._capitalOrLinear;
                    command.Parameters.Add("@isGeodetiSurveys", SqlDbType.Bit).Value = this.Surveys.IsGeodetiSurveys;
                    command.Parameters.Add("@isGeologicalSurveysSurveys", SqlDbType.Bit).Value =
                        this.Surveys.IsGeologicalSurveysSurveys;
                    command.Parameters.Add("@isEnvironmentalSurveys", SqlDbType.Bit).Value = this.Surveys.IsEnvironmentalSurveys;
                    command.Parameters.Add("@isMeteorologicalSurveys", SqlDbType.Bit).Value = this.Surveys.IsMeteorologicalSurveys;
                    command.Parameters.Add("@isGeotechnicalSurveys", SqlDbType.Bit).Value = this.Surveys.IsGeotechnicalSurveys;
                    command.Parameters.Add("@isArchaeologicalSurveys", SqlDbType.Bit).Value = this.Surveys.IsArchaeologicalSurveys;
                    command.Parameters.Add("@isInspectionOfTechnicalCondition", SqlDbType.Bit).Value =
                        this.Surveys.IsInspectionOfTechnicalCondition;
                    command.Parameters.Add("@nameCustomer", SqlDbType.Text).Value = this._nameCustomer;
                    command.Parameters.Add("@idGIP", SqlDbType.Int).Value = this._idGIP;
                    command.Parameters.Add("@idNkont", SqlDbType.Int).Value = this._idNkont;
                    command.Parameters.Add("@path", SqlDbType.Text).Value = this._path;
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
                for (Int32 iter = 0; iter < this._chapters.Count; iter++)
                {
                    String nameFile = this._chapters[iter].NameFileChapter
                        .Remove(this._chapters[iter].NameFileChapter.Length - 4, 4);
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
                        cell = new PdfPCell(new Phrase(this._chapters[iter].Id, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase(this._chapters[iter].ChapterName, font));
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
                        cell = new PdfPCell(new Phrase(this._chapters[iter].MD5, font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("CRC32", font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(this._chapters[iter].CRC32, font));
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

                        cell = new PdfPCell(new Phrase(this._chapters[iter].NameFileChapter, font));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(this._chapters[iter].DateChange, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(this._chapters[iter].SizeFileChapter.ToString(), font));
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
                        cell = new PdfPCell(new Phrase(this._GIP.Surname, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        iTextSharp.text.Image signGip = iTextSharp.text.Image.GetInstance(this._GIP.Sign, BaseColor.WHITE);
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
                        int countAuthors = this._chapters[iter].CountAuthorChapter;
                        for (int i = 0; i < countAuthors; i++)
                        {
                            cell = new PdfPCell(new Phrase(this._chapters[iter][i].Key, font));
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                            cell = new PdfPCell(new Phrase(this._chapters[iter][i].Value.Surname, font));
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                            iTextSharp.text.Image signAuthor = iTextSharp.text.Image.GetInstance(this._chapters[iter][i].Value.Sign, BaseColor.WHITE);
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
                        cell = new PdfPCell(new Phrase(this._Nkontr.Surname, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        iTextSharp.text.Image signNkontr = iTextSharp.text.Image.GetInstance(this._Nkontr.Sign, BaseColor.WHITE);
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
                        cell = new PdfPCell(new Phrase(this._chapters[iter].Id + "-УЛ", font));
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
    }
}
        

        
