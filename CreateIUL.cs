using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace IUL
{
    public partial class CreateIUL : Form
    {
        static List<KeyValuePair<string, string>> idAndNameProjects;
        public CreateIUL()
        {
            InitializeComponent();
            idAndNameProjects = new List<KeyValuePair<string, string>>(DbProviderFactories.GetIdAndNameProject());
            foreach(var nameProject in idAndNameProjects) 
            {
                comboBox1.Items.Add(nameProject.Value);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string codeProject = idAndNameProjects[comboBox1.SelectedIndex].Key;
                string pathMainFolder = DbProviderFactories.GetPathMainFolder(codeProject);
                folderBrowserDialog1.SelectedPath = pathMainFolder;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathMainFolder = folderBrowserDialog1.SelectedPath;
                IULs iuls = new IULs(codeProject);
                Dictionary<string, IUL.Chapter> chaptrers = new Dictionary<string, IUL.Chapter>(iuls.GetChapters());
                string dateSign = dateTimePicker1.Value.ToShortDateString();
                foreach (var chapter in chaptrers)
                {
                    CreateTable(pathMainFolder, chapter.Key, chapter.Value, chapter.Value.GetAuthorChapter(), dateSign, iuls.GIP, iuls.Nkontr);
                }
                MessageBox.Show("ИУЛы готовы");
            }
            catch(System.ArgumentOutOfRangeException ex) 
            {
                MessageBox.Show("Необходимо выбрать проект!");
            }

        }
        private void CreateTable(string path, string codeChapter, IUL.Chapter chapter, List<KeyValuePair<string, Employee>> authorsChapter, string dateSigning, Employee GIP, Employee NKontr)
        {
            var doc = new iTextSharp.text.Document(PageSize.A4);
            try
            {
                float scale = 0.4f;
                BaseFont baseFont = BaseFont.CreateFont(@"C:\\Windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11.5f, iTextSharp.text.Font.NORMAL);
                string nameFile = chapter.NameFile.Remove(chapter.NameFile.Length - 4, 4);
                nameFile += "-УЛ.pdf";
                path += "\\" + nameFile;
                using (var writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create)))
                {
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
                    cell = new PdfPCell(new Phrase(codeChapter, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    //string str = "Проектная документация.\nРаздел 1 Пояснительная записка";
                    cell = new PdfPCell(new Phrase(chapter.NameChapter, font));
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
                    cell = new PdfPCell(new Phrase(chapter.MD5, font));
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

                    cell = new PdfPCell(new Phrase("тестовый текст", font));
                    cell.Colspan = 2;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(chapter.DateChange, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(chapter.SizeFile.ToString(), font));
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
                    cell = new PdfPCell(new Phrase(GIP.Fname, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    iTextSharp.text.Image signGip = iTextSharp.text.Image.GetInstance(GIP.Sign,BaseColor.WHITE);
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
                    foreach (var author in authorsChapter)
                    {
                        cell = new PdfPCell(new Phrase(author.Key, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(author.Value.Fname, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        iTextSharp.text.Image signAuthor = iTextSharp.text.Image.GetInstance(author.Value.Sign, BaseColor.WHITE);
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
                    cell = new PdfPCell(new Phrase(NKontr.Fname, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    iTextSharp.text.Image signNkontr = iTextSharp.text.Image.GetInstance(NKontr.Sign, BaseColor.WHITE);
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
                    cell = new PdfPCell(new Phrase(codeChapter + "-УЛ", font));
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

                    doc.Add(table);
                    doc.Close();
                    writer.Close();
                }
            }
            catch (DocumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
