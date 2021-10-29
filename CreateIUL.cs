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
            //DbProviderFactories.UpdateImageSignEmployee(@"C:\Users\dying\Desktop\РАБОТА\IUL\bin\Debug\netcoreapp3.1\sign\Архипов.png", 2);
            MemoryStream memoryStream = new MemoryStream();
            foreach(var b in DbProviderFactories.GetSignBinary(2)) 
            {
                memoryStream.WriteByte(b);
            }
            System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);
            panel1.BackgroundImage = image;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string codeProject = idAndNameProjects[comboBox1.SelectedIndex].Key;
            IULs iuls = new IULs(codeProject);
            foreach(var chapter in iuls.GetChapters()) 
            {
                CreateTable(chapter.Key, chapter.Value, dateTimePicker1.Value.ToShortDateString(), iuls.GIP, iuls.Nkontr);
            }
            MessageBox.Show("ИУЛы готовы");
        }
        void CreateTable(string codeChapter, Chapters chapter, string dateSigning, string GIP, string NKontr)
        {
            var doc = new iTextSharp.text.Document(PageSize.A4);
            try
            {
                BaseFont baseFont = BaseFont.CreateFont(@"C:\\Windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11.5f, iTextSharp.text.Font.NORMAL);
                string nameFile = chapter.NameFile.Remove(chapter.NameFile.Length - 4, 4);
                nameFile += "-УЛ.pdf";
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
                    cell = new PdfPCell(new Phrase(GIP, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    iTextSharp.text.Image sign = iTextSharp.text.Image.GetInstance(@"C:\Users\dying\Desktop\РАБОТА\IUL\bin\Debug\netcoreapp3.1\sign\Рябов.png");
                    cell = new PdfPCell(sign);
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(dateSigning, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    foreach (var author in chapter.GetAuthorChapter())
                    {
                        cell = new PdfPCell(new Phrase(author.Value, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(author.Key, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase("", font));
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
                    cell = new PdfPCell(new Phrase(NKontr, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
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
