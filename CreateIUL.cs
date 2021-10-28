using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
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
            string codeProject = idAndNameProjects[comboBox1.SelectedIndex].Key;
            IULs iuls = new IULs(codeProject);
            foreach(var chapter in iuls.GetIULsValue()) 
            {
                Console.WriteLine(chapter.Key);
            }
        }
        void CreateTable(string nameFile, IULs IUL, string codeChapter, string nameDoc, string MD5, string dateChange, long sizeFile, string dateSigning, string CodeIUL)
        {
            var doc = new iTextSharp.text.Document(PageSize.A4);
            try
            {
                BaseFont baseFont = BaseFont.CreateFont(@"C:\\Windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11.5f, iTextSharp.text.Font.NORMAL);
                using (var writer = PdfWriter.GetInstance(doc, new FileStream(nameFile, FileMode.Create)))
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
                    cell = new PdfPCell(new Phrase(nameDoc, font));
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
                    cell = new PdfPCell(new Phrase(MD5, font));
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
                    cell = new PdfPCell(new Phrase(dateChange, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(sizeFile.ToString(), font));
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
                    //foreach (var author in IUL.AuthorTeam)
                    //{
                    //    cell = new PdfPCell(new Phrase(author.WorkRole, font));
                    //    cell.Colspan = 1;
                    //    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    //    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    //    table.AddCell(cell);
                    //    cell = new PdfPCell(new Phrase(author.Surname, font));
                    //    cell.Colspan = 1;
                    //    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    //    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    //    table.AddCell(cell);
                    //    cell = new PdfPCell(new Phrase("", font));
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
                    cell = new PdfPCell(new Phrase("Информационно-удостоверяющий лист", font));
                    cell.Colspan = 2;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(CodeIUL, font));
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
