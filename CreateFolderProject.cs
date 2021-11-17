﻿using System;
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
            try
            {
                List<string> _chapters = new List<string>(20);
                foreach (var chapter in CheckedListBoxChapters.CheckedItems)
                {
                    _chapters.Add(chapter.ToString());
                }
                string pathToMainFolder;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathToMainFolder = folderBrowserDialog1.SelectedPath;
                string nameMaiFolder;
                if (TextBoxNameMainFolder.Text.Length == 0)
                {
                    MessageBox.Show("Необходимо заполнить поле с названием папки проекта!", "Ошибка!");
                    return;
                }
                else
                {
                    nameMaiFolder = TextBoxNameMainFolder.Text;
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
                MessageBox.Show("Папка проекта создана!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RadioButtonLinear.Checked)
                {
                    FilingComboBoxLinearChapter();
                }
                if (RadioButtonCapital.Checked)
                {
                    FilingComboBoxCapitalChapter();
                }
                this.ClientSize = new System.Drawing.Size(this.ClientSize.Width,
                        CheckedListBoxChapters.Size.Height + this.ButtonCrossCreateProject.Size.Height + this.ButtonBack.Size.Height
                      + this.ButtonCreateFolder.Size.Height + this.ButtonSelectAllChapters.Size.Height + this.ButtonSelectAllReseach.Size.Height + 70);
                Point pointButtonCross = new Point(558, 181);
                Point pointButtonBack = new Point(558, 245);
                ButtonCrossCreateProject.Location = new Point(ButtonCrossCreateProject.Location.X, pointButtonCross.Y + CheckedListBoxChapters.Height);
                ButtonBack.Location = new Point(ButtonBack.Location.X, pointButtonBack.Y + CheckedListBoxChapters.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        /// <summary>
        /// Метод создающий папку
        /// </summary>
        /// <param name="folderName">Имя создаваемой папки</param>
        /// <param name="path">Путь к папке</param>
        private void CreateFolder(string folderName, string path)
        {
            try 
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        /// <summary>
        /// Метод создающий подпапки для Изысканий
        /// </summary>
        /// <param name="path">Путь к папке !Изыскания</param>
        private void CreateResearchs(string path)
        {
            try 
            {
                foreach (var chls in CheckedListBoxResearchs.CheckedItems)
                {
                    CreateFolder(chls.ToString(), path);
                }
                List<string> sourse = new List<string>();
                foreach (var chls in CheckedListBoxResearchs.CheckedItems)
                {
                    sourse.Add(chls.ToString());
                }
                CreateFolderSource(sourse, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        /// <summary>
        /// Метод создает подпапки "pdf" и "dwg" в папках разделов и изысканий
        /// </summary>
        /// <param name="folders">Перечень папок, в которых буду созданы подпапки</param>
        /// <param name="path">Путь к папке в которой лежат папки для которых нужно создать подпаки "pdf" и "dwg"</param>
        private void CreateFolderSource(List<string> folders, string path)
        {
            try 
            {
                foreach (var folder in folders)
                {
                    CreateFolder("dwg", (path + "\\" + folder));
                    CreateFolder("pdf", (path + "\\" + folder));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonSelectAllChapters_Click(object sender, EventArgs e)
        {
            try 
            {
                if (CheckedListBoxChapters.Items.Count == 0)
                {
                    MessageBox.Show("Необходимо выбрать тип проекта!", "Ошибка!");
                    return;
                }
                for (int i = 0; i < CheckedListBoxChapters.Items.Count; i++)
                {
                    CheckedListBoxChapters.SetItemChecked(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ButtonSelectAllReseach_Click(object sender, EventArgs e)
        {
            try 
            {
                for (int i = 0; i < CheckedListBoxResearchs.Items.Count; i++)
                {
                    CheckedListBoxResearchs.SetItemChecked(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonCrossCreateProject_Click(object sender, EventArgs e)
        {
            try 
            {
                CreateProject createProject = new CreateProject();
                createProject.Show();
                this.Hide();
                Program.PreviosPage = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            try 
            {
                Program.PreviosPage.Show();
                this.Hide();
                Program.PreviosPage = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
    }
}
