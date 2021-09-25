using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class AddProject : Form
    {
        List<string> _projectCompositionCapital = new List<string>();
        List<string> _projectCompositionLinear = new List<string>();
        public AddProject()
        {
            InitializeComponent();
            tabPage1.Text = "Объекты капитального строительства";
            tabPage2.Text = "Линейные объекты";
            CreateProjectCompositionCapital();
            CreateOrijectCompositionLinear();
            CreateCheckBox(this.tabControl1.TabPages[0], _projectCompositionCapital, "checkBoxCompositionCapital");
            CreateCheckBox(this.tabControl1.TabPages[1], _projectCompositionLinear, "checkBoxCompositionLinear");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage selectTabPage = this.tabControl1.SelectedTab;
            
            foreach(var checkbox in selectTabPage.Controls) 
            {
                if(checkbox is CheckBox) 
                {
                    CheckBox box = (CheckBox)checkbox;
                    textBox1.Text += "Tag: " + box.Tag + "\n" +"\n"+" Name: " + "\n" + box.Name + " Checked: " + "\n" + box.Checked + "\n";
                }
            }
        }
        private void CreateProjectCompositionCapital() 
        {
            _projectCompositionCapital.Add("Раздел 1 Пояснительная записка");
            _projectCompositionCapital.Add("Раздел 2 Схема планировочной организации земельного участка");
            _projectCompositionCapital.Add("Раздел 3 Архитектурные решения");
            _projectCompositionCapital.Add("Раздел 4 Конструктивные и объемно-планировочные решения");
            _projectCompositionCapital.Add("Раздел 5 Сведения об инженерном оборудовании, о сетях инженерно-технического обеспечения, перечень инженерно-технических мероприятий, содержание технологических решений");

            _projectCompositionCapital.Add("Подраздел Система электроснабжения");
            _projectCompositionCapital.Add("Подраздел Система водоснабжения");
            _projectCompositionCapital.Add("Подраздел Система водоотведения");
            _projectCompositionCapital.Add("Подраздел Отопление, вентиляция и кондиционирование воздуха, тепловые сети");
            _projectCompositionCapital.Add("Подраздел Сети связи");
            _projectCompositionCapital.Add("Подраздел Система газоснабжения");
            _projectCompositionCapital.Add("Подраздел Технологические решения");

            _projectCompositionCapital.Add("Раздел 6 Проект организации строительства");
            _projectCompositionCapital.Add("Раздел 7 Проект организации работ по сносу или демонтажу объектов капитального строительства");
            _projectCompositionCapital.Add("Раздел 8 Перечень мероприятий по охране окружающей среды");
            _projectCompositionCapital.Add("Раздел 9 Мероприятия по обеспечению пожарной безопасности");
            _projectCompositionCapital.Add("Раздел 10 Мероприятия по обеспечению доступа инвалидов");
            _projectCompositionCapital.Add("Раздел 10_1 Мероприятия по обеспечению соблюдения требований энергетической эффективности и требований оснащенности зданий, строений и сооружений приборами учета используемых энергетических ресурсов");
            _projectCompositionCapital.Add("Раздел 11 Смета на строительство объектов капитального строительства");
            _projectCompositionCapital.Add("Раздел 12 Иная документация в случаях, предусмотренных федеральными законами");
           
        }
        private void CreateCheckBox(TabPage tabPage, List<string> chapters, string nameCheckBox) 
        {
            List<CheckBox> checkBoxesCapital = new List<CheckBox>();
            int i = 0;

            foreach (var chapter in chapters)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = nameCheckBox + i.ToString();
                checkBox.Text = chapter;
                checkBox.AutoSize = false;
                checkBox.Size = new Size(chapter.Length * 15, checkBox.Size.Height);
                checkBoxesCapital.Add(checkBox);
                i++;
            }
            Point locationCheckBox = new Point(10, 10);
            int tagChapter = 1;//Тэг на чекбоксе, соответствующий номеру раздела ПД
            int tagSubChapter = 1;//Тэг на чекбоксе, соответствующий номеру подраздела ПД
            foreach (var checkBox in checkBoxesCapital)
            {
                checkBox.Tag = tagChapter.ToString();
                tabPage.Controls.Add(checkBox);
                string[] words = checkBox.Text.Split(' ');
                if (words[1].Equals("10_1")) 
                {
                    checkBox.Tag = "10_1";
                    tagChapter--;
                }
                if (words[0].Equals("Подраздел"))
                {
                    locationCheckBox.X = 25;
                    checkBox.Location = new Point(checkBox.Location.X + 20, checkBox.Location.Y + 20);
                    checkBox.Tag = (tagChapter-1).ToString() + "." + tagSubChapter.ToString();
                    tagSubChapter++;
                }
                else 
                {
                    tagChapter++;
                }
                checkBox.Location = new Point(locationCheckBox.X, locationCheckBox.Y);
                locationCheckBox.Y += 20;
                locationCheckBox.X = 10;
            }
        }
        private void CreateOrijectCompositionLinear() 
        {
            _projectCompositionLinear.Add("Раздел 1 Пояснительная записка");
            _projectCompositionLinear.Add("Раздел 2 Проект полосы отвода");
            _projectCompositionLinear.Add("Раздел 3 Технологические и конструктивные решения линейного объекта. Искусственные сооружения");
            _projectCompositionLinear.Add("Раздел 4 Здания, строения и сооружения, входящие в инфраструктуру линейного объекта");
            _projectCompositionLinear.Add("Раздел 5 Проект организации строительства");
            _projectCompositionLinear.Add("Раздел 6 Проект организации работ по сносу (демонтажу) линейного объекта");
            _projectCompositionLinear.Add("Раздел 7 Мероприятия по охране окружающей среды");
            _projectCompositionLinear.Add("Раздел 8 Мероприятия по обеспечению пожарной безопасности");
            _projectCompositionLinear.Add("Раздел 9 Смета на строительство");
        }
    }
}
