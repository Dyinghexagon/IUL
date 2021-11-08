using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class CreateChapter : Form
    {
        private Dictionary<string, string> _codeNamePair;
        public CreateChapter()
        {
            InitializeComponent();
            InitializeProjects();
        }

        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameProject = ComboBoxNameProjects.Items[ComboBoxNameProjects.SelectedIndex].ToString();
            Project selectedProject = new Project(nameProject);
            LabelCodeProject.Text = selectedProject.Id;
            _codeNamePair = new Dictionary<string, string>();

            if (selectedProject.CapitalOrLinear) 
            {
                FilingComboBoxCapitalChapter();
                _codeNamePair.Add("Раздел 1. Пояснительная записка", "ПЗ");
                _codeNamePair.Add("Раздел 2. Схема планировочной организации земельного участка", "ПЗУ");
                _codeNamePair.Add("Раздел 3. Архитектурные решения", "АР");
                _codeNamePair.Add("Раздел 4. Конструктивные и объемно - планировочные решения", "КР");
                _codeNamePair.Add("Раздел 5. Подраздел 5.1 Система электроснабжения", "ИОС5.1");
                _codeNamePair.Add("Раздел 5. Подраздел 5.2 Система водоснабжения", "ИОС5.2");
                _codeNamePair.Add("Раздел 5. Подраздел 5.3 Система водоотведения", "ИОС5.3");
                _codeNamePair.Add("Раздел 5. Подраздел 5.4 Отопление, вентиляция и кондиционирование воздуха, тепловые сети", "ИОС5.4");
                _codeNamePair.Add("Раздел 5. Подраздел 5.5 Сети связи", "ИОС5.5");
                _codeNamePair.Add("Раздел 5. Подраздел 5.6 Система газоснабжения", "ИОС5.6");
                _codeNamePair.Add("Раздел 5. Подраздел 5.7 Технологические решения", "ИОС5.7");

                _codeNamePair.Add("Раздел 6. Проект организации строительства", "ПОС");
                _codeNamePair.Add("Раздел 7. Проект организации работ по сносу или демонтажу объектов капитального строительства", "ПОД");
                _codeNamePair.Add("Раздел 8. Перечень мероприятий по охране окружающей среды", "ООС");
                _codeNamePair.Add("Раздел 9. Мероприятия по обеспечению пожарной безопасности", "ПБ");
                _codeNamePair.Add("Раздел 10. Мероприятия по обеспечению доступа инвалидов", "ОДИ");
                _codeNamePair.Add("Раздел 10_1. Мероприятия по обеспечению соблюдения требований энергетической эффективности", "ЭЭ");
                _codeNamePair.Add("Раздел 11. Смета на строительство объектов капитального строительства", "СМ");
                _codeNamePair.Add("Раздел 12. Иная документация в случаях, предусмотренных федеральными законами", "КР");

            }
            else 
            {
                FilingComboBoxLinearChapter();
                _codeNamePair.Add("Раздел 1. Пояснительная записка", "ПЗ");
                _codeNamePair.Add("Раздел 2. Проект полосы отвода", "ППО");
                _codeNamePair.Add("Раздел 3. Технологические и конструктивные решения линейного объекта. Искусственные сооружения", "ТКР");
                _codeNamePair.Add("Раздел 4. Здания, строения и сооружения, входящие в инфраструктуру линейного объекта", "ИЛО");
                _codeNamePair.Add("Раздел 5. Проект организации строительства", "ПОС");
                _codeNamePair.Add("Раздел 6. Проект организации работ по сносу (демонтажу) линейного объекта", "ПОД");
                _codeNamePair.Add("Раздел 7. Мероприятия по охране окружающей среды", "ООС");
                _codeNamePair.Add("Раздел 8. Мероприятия по обеспечению пожарной безопасности", "ПБ");
                _codeNamePair.Add("Раздел 9. Смета на строительство", "СМ");
            }

        }

        private void ComboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codeChapter = LabelCodeProject.Text;
            string nameChapter = "Проектная документация. ";
            string res = ComboBoxChapters.Items[ComboBoxChapters.SelectedIndex].ToString();
            if (ComboBoxChapters.SelectedIndex >= 4 && ComboBoxChapters.SelectedIndex <= 10)
            {
                string chapter5 = "Раздел 5. Сведения об инженерном оборудовании, о сетях инженерно-технического обеспечения, перечень инженерно-технических мероприятий, содержание технологических решений";
                nameChapter += chapter5;
            }
            //ИСПРАВИТЬ ДЛЯ СЛУЧАЯ С РАЗДЕЛОМ 5
                nameChapter += res;
            
            codeChapter += "-" + _codeNamePair[res];
            Console.WriteLine(codeChapter);
            Console.WriteLine(nameChapter);
        }
    }
}