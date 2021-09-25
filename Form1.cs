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
    public partial class Form1 : Form
    {
        List<IULValue> IULs = new List<IULValue>();
        List<string> fileNames = new List<string>();
        string dateSigning;
        public Form1()
        {
            InitializeComponent();
            dateSigning = textBox1.Text;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string connStr = "server=localhost;user=root;database=IUL;password=root";
            using (MySqlConnection conn = new MySqlConnection(connStr)) 
            {
                conn.Open();
                string sql = "SELECT * FROM project_composition;";
                MySqlCommand com = new MySqlCommand(sql, conn);
                MySqlDataReader reader = com.ExecuteReader();
                List<string> codes = new List<string>();
                List<string> namesDoc = new List<string>();
                while (reader.Read())
                {
                    codes.Add(reader[0].ToString());
                    namesDoc.Add(reader[1].ToString());
                }
                reader.Close();
                int i = 0;
                AuthorTeam GIP = new AuthorTeam();
                AuthorTeam NKontr = new AuthorTeam();
                string queryGIP = "SELECT work_role, surname FROM engineers WHERE work_role = 'ГИП';";
                string queryNKontr = "SELECT work_role, surname FROM engineers WHERE work_role = 'Н.Контр';";
                MySqlCommand selectGIP = new MySqlCommand(queryGIP, conn);
                reader = selectGIP.ExecuteReader();
                while (reader.Read()) 
                {
                    GIP.WorkRole = reader[0].ToString();
                    GIP.Surname = reader[1].ToString();
                }
                reader.Close();
                MySqlCommand selectNKontr = new MySqlCommand(queryNKontr, conn);
                reader = selectNKontr.ExecuteReader();
                while (reader.Read()) 
                {
                    NKontr.WorkRole = reader[0].ToString();
                    NKontr.Surname = reader[1].ToString();
                }
                reader.Close();
                foreach (var code in codes) 
                {
                    string queryAuthorTeam = "SELECT work_role, surname FROM engineers WHERE code_id = @code;";
                    MySqlCommand selectAuthorTeam = new MySqlCommand(queryAuthorTeam, conn);
                    MySqlParameter codeIdParam = new MySqlParameter("@code", code);
                    selectAuthorTeam.Parameters.Add(codeIdParam);
                    reader = selectAuthorTeam.ExecuteReader();
                    List<AuthorTeam> authorTeam = new List<AuthorTeam>();
                    authorTeam.Add(GIP);
                    while (reader.Read()) 
                    {
                        authorTeam.Add(new AuthorTeam(reader[0].ToString(), reader[1].ToString()));
                    }
                    authorTeam.Add(NKontr);
                    IULs.Add(new IULValue(code,(code + "-УЛ"), namesDoc[i], authorTeam));
                    reader.Close();
                    i++;
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = folderBrowserDialog1.SelectedPath;
            IEnumerable<string> PathDirectorys = Directory.EnumerateFiles(path);
            foreach (var PathDirectory in PathDirectorys) 
            {
                int position = PathDirectory.IndexOf("\\");
                if (position < 0)
                    continue;
                string fileName = Path.GetFileName(PathDirectory);
                if (fileName.Equals("Thumbs.db"))
                    continue;
                richTextBox1.Text += fileName + "\n";
                fileNames.Add(fileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var IUL in IULs) 
            {
                richTextBox1.Text += "Code: " + IUL.Code + "\n"
                                    + "CodeIUL: " + IUL.CodeIUL + "\n"
                                    + "NameDoc: " + IUL.NameDoc + "\n"
                                    + "AuthorTeam: " + "\n";
                foreach(var author in IUL.AuthorTeam) 
                {
                    richTextBox1.Text += "WorkRole: " + author.WorkRole + "\n"
                                       + "Surname: " + author.Surname + "\n";
                }
                richTextBox1.Text += "--------------------------------------------------------" + "\n";
                string nameFile = "File" + i.ToString() + ".pdf";
                CreateTable(nameFile, IUL);
                i++;
            }
            //for(int i=0;i< chapter.Length; i++) 
            //{
            //    string nameFile = "File" + i.ToString() + ".pdf";
            //    CreateTables(nameFile);
            //}
        }
        void CreateTable(string nameFile, IULValue IUL)
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
                    cell = new PdfPCell(new Phrase(IUL.Code, font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    //string str = "Проектная документация.\nРаздел 1 Пояснительная записка";
                    cell = new PdfPCell(new Phrase(IUL.NameDoc, font));
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
                    cell = new PdfPCell(new Phrase("4E47EE85B11B625B0511E2BF50EC59EA", font));
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
                    cell = new PdfPCell(new Phrase("26.08.2021 11:45", font));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("28440833", font));
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
                    foreach (var author in IUL.AuthorTeam) 
                    {
                        cell = new PdfPCell(new Phrase(author.WorkRole, font));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(author.Surname, font));
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
                    cell = new PdfPCell(new Phrase("Информационно-удостоверяющий лист", font));
                    cell.Colspan = 2;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(IUL.CodeIUL, font));
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

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo file = new System.IO.FileInfo("file0.pdf");
            richTextBox1.Text += file.Length.ToString();
        }
    }
}
