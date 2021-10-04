using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace IUL
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filePath = folderBrowserDialog1.SelectedPath;
            string nameMaiFolder;
            if(textBox1.Text.Length == 0) 
            {
                MessageBox.Show("Необходимо заполнить поле с названием проекта!", "Ошибка!");
                return;
            }
            else 
            {
                nameMaiFolder = textBox1.Text;
            }
            CreateFolder(nameMaiFolder, filePath);//Создание папки проекта
            Dictionary<string, string> dictSubFolder = new Dictionary<string, string>();
            dictSubFolder.Add("!Изыскания", filePath + "\\" + nameMaiFolder);
            dictSubFolder.Add("!ПД", filePath + "\\" + nameMaiFolder);
            dictSubFolder.Add("!ИРД", filePath + "\\" + nameMaiFolder);
            //Создание папок
            foreach(var sf in dictSubFolder) 
            {
                CreateFolder(sf.Key, sf.Value);
            }
            CreateResearchs(filePath + "\\" + nameMaiFolder + "\\" + "!Изыскания");
        }
        /// <summary>
        /// Метод создающий папку
        /// </summary>
        /// <param name="folderName">Имя создаваемой папки</param>
        /// <param name="path">Путь к папке</param>
        private void CreateFolder(string folderName, string path) 
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(folderName);
        } 
        /// <summary>
        /// Метод создающий подпапки для Изысканий
        /// </summary>
        /// <param name="path">Путь к папке !Изыскания</param>
        private void CreateResearchs(string path) 
        {
            foreach (var chls in checkedListBox1.CheckedItems)
            {
                CreateFolder(chls.ToString(), path);
            }
            List<string> sourse = new List<string>();
            foreach (var chls in checkedListBox1.CheckedItems)
            {
                sourse.Add(chls.ToString());
            }
            CreateFolderSource(sourse, path);
        }
        /// <summary>
        /// Метод создает подпапки "pdf" и "dwg" в папках разделов и изысканий
        /// </summary>
        /// <param name="folders">Перечень папок, в которых буду созданы подпапки</param>
        /// <param name="path">Путь к папке в которой лежат папки для которых нужно создать подпаки "pdf" и "dwg"</param>
        private void CreateFolderSource(List<string> folders, string path) 
        {
            foreach(var folder in folders) 
            {
                CreateFolder("dwg", (path + "\\" + folder));
                CreateFolder("pdf", (path + "\\" + folder));
            }
        }     
    }
}
