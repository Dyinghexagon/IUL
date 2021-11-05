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
    public partial class CreateFolderProject : Form
    {
        public CreateFolderProject()
        {
            InitializeComponent();
        }
        private void ButtonCreateFolder_Click(object sender, EventArgs e)
        {
            CreateMainFolder();
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                FilingComboBoxLinearChapter();
            }
            else if (RadioButton2.Checked)
            {
                FilingComboBoxCapitalChapter();
            }
        }
        private void CreateMainFolder()
        {
            List<string> _chapters = new List<string>(20);
            foreach (var chapter in checkedListBox2.CheckedItems)
            {
                _chapters.Add(chapter.ToString());
            }
            string pathToMainFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pathToMainFolder = folderBrowserDialog1.SelectedPath;
            string nameMaiFolder;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить поле с названием папки проекта!", "Ошибка!");
                return;
            }
            else
            {
                nameMaiFolder = textBox1.Text;
            }

            CreateFolder(nameMaiFolder, pathToMainFolder);//Создание папки проекта 
            // pathToMainFolder - путь к папке где необходимо создать папку проекта
            // pathMainFolder - путь самой папки проекта, т. е. путь к главной папке + её название
            string pathMainFolder = pathToMainFolder + "\\" + nameMaiFolder;
            List<string> subFolders = new List<string>()
            {
                "!Изыскания",
                "!ПД",
                "!ИРД",
                "!ИУЛ",
                "!Экспертиза"
            };
            //Создание папок
            foreach (var subFolder in subFolders)
            {
                CreateFolder(subFolder, pathMainFolder);
            }
            string keyFilePd = "!ПД";
            string pathPD = pathMainFolder + "\\" + keyFilePd + "\\";
            foreach (var chapter in _chapters)
            {
                CreateFolder(chapter, pathPD);

            }
            CreateFolderSource(_chapters, pathPD);

        }
        /// <summary>
        /// Метод создающий папку
        /// </summary>
        /// <param name="folderName">Имя создаваемой папки</param>
        /// <param name="path">Путь к папке</param>
        private void CreateFolder(string folderName, string path)
        {
            if (folderName.Equals("!Изыскания"))
            {
                CreateResearchs(path + "\\" + "!Изыскания");
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                dirInfo.CreateSubdirectory(folderName);
            }
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
            foreach (var folder in folders)
            {
                CreateFolder("dwg", (path + "\\" + folder));
                CreateFolder("pdf", (path + "\\" + folder));
            }
        }

        private void ButtonSelectAllChapters_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.Items.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать тип проекта!", "Ошибка!");
                return;
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
            }
        }
        private void ButtonSelectAllReseach_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
    }
}
