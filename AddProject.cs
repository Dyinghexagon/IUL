using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
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
            CreateFolderProject();
        }
        private void CreateFolderProject() 
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
                MessageBox.Show("Необходимо заполнить поле с названием проекта!", "Ошибка!");
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
            foreach(var subFolder in subFolders) 
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
            foreach(var folder in folders) 
            {
                CreateFolder("dwg", (path + "\\" + folder));
                CreateFolder("pdf", (path + "\\" + folder));
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            if (radioButton1.Checked) 
            {
                checkedListBox2.Items.AddRange(new object[]
                {
                    "Раздел 1. Пояснительная записка",
                    "Раздел 2. Проект полосы отвода",
                    "Раздел 3. Технологические и конструктивные решения линейного объекта. Искусственные сооружения",
                    "Раздел 4. Здания, строения и сооружения, входящие в инфраструктуру линейного объекта",
                    "Раздел 5. Проект организации строительства",
                    "Раздел 6. Проект организации работ по сносу (демонтажу) линейного объекта",
                    "Раздел 7. Мероприятия по охране окружающей среды",
                    "Раздел 8. Мероприятия по обеспечению пожарной безопасности",
                    "Раздел 9. Смета на строительство"
                });
                checkedListBox2.Size = new Size(605, 166);
            }
            else if (radioButton2.Checked) 
            {
                checkedListBox2.Items.AddRange(new object[]
                {
                    "Раздел 1. Пояснительная записка",
                    "Раздел 2. Схема планировочной организации земельного участка",
                    "Раздел 3. Архитектурные решения",
                    "Раздел 4. Конструктивные и объемно-планировочные решения",
                    "Раздел 5. Подраздел 5.1 Система электроснабжения",
                    "Раздел 5. Подраздел 5.2 Система водоснабжения",
                    "Раздел 5. Подраздел 5.3 Система водоотведения",
                    "Раздел 5. Подраздел 5.4 Отопление, вентиляция и кондиционирование воздуха, тепловые сети",
                    "Раздел 5. Подраздел 5.5 Сети связи",
                    "Раздел 5. Подраздел 5.6 Система газоснабжения",
                    "Раздел 5. Подраздел 5.7 Технологические решения",
                    "Раздел 6. Проект организации строительства",
                    "Раздел 7. Проект организации работ по сносу или демонтажу объектов капитального строительства",
                    "Раздел 8. Перечень мероприятий по охране окружающей среды",
                    "Раздел 9. Мероприятия по обеспечению пожарной безопасности",
                    "Раздел 10. Мероприятия по обеспечению доступа инвалидов",
                    "Раздел 10_1. Мероприятия по обеспечению соблюдения требований энергетической эффективности",
                    "Раздел 11. Смета на строительство объектов капитального строительства",
                    "Раздел 12. Иная документация в случаях, предусмотренных федеральными законами"
                });
                checkedListBox2.Size = new Size(605, 350);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkedListBox2.Items.Count == 0) 
            {
                MessageBox.Show("Необходимо выбрать тип проекта!", "Ошибка!");
                return;
            }
            for(int i=0; i < checkedListBox2.Items.Count; i++) 
            {
                checkedListBox2.SetItemChecked(i, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.Items.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать тип проекта!", "Ошибка!");
                return;
            }
            List<string> selectedChapters = new List<string>(20);
            foreach (var chapter in checkedListBox2.CheckedItems)
            {
                selectedChapters.Add(chapter.ToString());
            }
            foreach (var chapter in checkedListBox1.CheckedItems)
            {
                selectedChapters.Add(chapter.ToString());
            }
            AddAuthorsChapters addAuthorsChapters = new AddAuthorsChapters(selectedChapters);
            addAuthorsChapters.Show();

        }
    }
}
