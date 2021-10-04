using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class AddChapters : Form
    {
        bool _capitalOrLinear = true;
        public AddChapters()
        {
            InitializeComponent();
            FillingCheckedList();
            int count = checkedListBox1.Items.Count;
            int height = Convert.ToInt32(count * 18.2);
            int width = checkedListBox1.Width;
            checkedListBox1.Width = width;
            checkedListBox1.Height = height;
            button1.Location = new Point(checkedListBox1.Location.X, checkedListBox1.Location.Y + height);
            this.Height = height + 80;
            this.Width = width + 40;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public AddChapters(bool capitalOrLinear) 
        {
            InitializeComponent();
            FillingCheckedList();
            int count = checkedListBox1.Items.Count;
            int height = Convert.ToInt32(count * 18.2);
            int width = 600;
            checkedListBox1.Width = width;
            checkedListBox1.Height = height;
            button1.Location = new Point(checkedListBox1.Location.X, checkedListBox1.Location.Y + height);
            this.Height = height + 80;
            this.Width = width + 40;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void FillingCheckedList() 
        {
            List<string> chapters = new List<string>(20);
            if (_capitalOrLinear) 
            {
                chapters.Add("Раздел 1 Пояснительная записка");
                chapters.Add("Раздел 2 Схема планировочной организации земельного участка");
                chapters.Add("Раздел 3 Архитектурные решения");
                chapters.Add("Раздел 4 Конструктивные и объемно-планировочные решения");
                chapters.Add("Раздел 5 Подраздел 5.1 Система электроснабжения");
                chapters.Add("Раздел 5 Подраздел 5.2 Система водоснабжения");
                chapters.Add("Раздел 5 Подраздел 5.3 Система водоотведения");
                chapters.Add("Раздел 5 Подраздел 5.4 Отопление, вентиляция и кондиционирование воздуха, тепловые сети");
                chapters.Add("Раздел 5 Подраздел 5.5 Сети связи");
                chapters.Add("Раздел 5 Подраздел 5.6 Система газоснабжения");
                chapters.Add("Раздел 5 Подраздел 5.7 Технологические решения");
                chapters.Add("Раздел 6 Проект организации строительства");
                chapters.Add("Раздел 7 Проект организации работ по сносу или демонтажу объектов капитального строительства");
                chapters.Add("Раздел 8 Перечень мероприятий по охране окружающей среды");
                chapters.Add("Раздел 9 Мероприятия по обеспечению пожарной безопасности");
                chapters.Add("Раздел 10 Мероприятия по обеспечению доступа инвалидов");
                chapters.Add("Раздел 10_1 Мероприятия по обеспечению соблюдения требований энергетической эффективности");
                chapters.Add("Раздел 11 Смета на строительство объектов капитального строительства");
                chapters.Add("Раздел 12 Иная документация в случаях, предусмотренных федеральными законами");
            }
            else 
            {
                chapters.Add("Раздел 1 Пояснительная записка");
                chapters.Add("Раздел 2 Проект полосы отвода");
                chapters.Add("Раздел 3 Технологические и конструктивные решения линейного объекта. Искусственные сооружения");
                chapters.Add("Раздел 4 Здания, строения и сооружения, входящие в инфраструктуру линейного объекта");
                chapters.Add("Раздел 5 Проект организации строительства");
                chapters.Add("Раздел 6 Проект организации работ по сносу (демонтажу) линейного объекта");
                chapters.Add("Раздел 7 Мероприятия по охране окружающей среды");
                chapters.Add("Раздел 8 Мероприятия по обеспечению пожарной безопасности");
                chapters.Add("Раздел 9 Смета на строительство");
            }
            checkedListBox1.Items.AddRange(chapters.ToArray());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> chapters = new List<string>(20);
            foreach(var chapter in checkedListBox1.CheckedItems) 
            {
                chapters.Add(chapter.ToString());
            }
        }
    }
}
