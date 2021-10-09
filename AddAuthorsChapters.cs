using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class AddAuthorsChapters : Form
    {
        List<string> _chapters;
        public AddAuthorsChapters()
        {
            InitializeComponent();
        }
        public AddAuthorsChapters(List<string> chapters)
        {
            InitializeComponent();
            _chapters = new List<string>(chapters);
        }
        /// <summary>
        /// Доделать:
        /// 1.  Выгрузку из БД "рабочих ролей"
        /// 2.  Выгрузку из БД "исполнителей"
        /// 3.  Загрузку в БД итоговых значений
        /// 4.  Проработать UI/UX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int distanceBetween = 25;
            int iter = 0;
            object[] arr = new object[] { 1, 2, 3, 4, 5, 6 };
            string[] workRoles = new string[] { "Разраб.", "Разраб.", "Рук. груп.", "Пров.", "ГИП", "Н. контр." };
            int maxSize = workRoles[2].Length * 7;
            foreach (var chapter in _chapters) 
            {
                Point labelLocation = new Point(10, 10);
                TabPage tabPage = new TabPage();
                tabControl1.TabPages.Add(tabPage);
                tabPage.Name = "TabPage" + iter.ToString();
                tabPage.Text = chapter;
                for (int i = 0; i < workRoles.Length; i++)
                {
                    labelLocation.Y += distanceBetween;
                    Size size = new Size(workRoles[i].Length * 7, 15);
                    string name = "Label" + i.ToString();
                    string text = workRoles[i];
                    tabPage.Controls.Add(CreateLabel(size, name, labelLocation, text));
                    Size sizeComboBox = new Size(120, 15);
                    string nameComboBox = "ComboBox" + iter.ToString();
                    Point locationComboBox = new Point(labelLocation.X + maxSize, labelLocation.Y);
                    tabPage.Controls.Add(CreateComboBox(sizeComboBox, nameComboBox, locationComboBox, arr));
                    tabPage.Controls.Add(CreateComboBox(sizeComboBox, nameComboBox, new Point(locationComboBox.X + sizeComboBox.Width + 10, labelLocation.Y), arr));

                }
                iter++;
            }
        }
        private Label CreateLabel(Size size, string name, Point location, string text) 
        {
            Label label = new Label();
            label.Size = new Size(text.Length * 7, 15);
            label.Name = name;
            label.Location = location;
            label.Text = text;
            return label;
        }
        private ComboBox CreateComboBox(Size size, string name, Point location, object[] arr) 
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Size = size;
            comboBox.Name = name;
            comboBox.Location = location;
            comboBox.Items.AddRange(arr);
            comboBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseWheel);
            return comboBox;
        }
        private void comboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}
