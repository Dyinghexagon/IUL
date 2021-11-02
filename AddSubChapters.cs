using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class AddSubChapters : Form
    {
        public AddSubChapters()
        {
            InitializeComponent();

        }
        public AddSubChapters(ref List<string> chapters)
        {
            InitializeComponent();
            FillingTabControl(chapters, tabControl1);
        }
        private void FillingTabControl(List<string> chapters, TabControl tabControl)
        {
            int iter = 0;
            int distanceBetween = 25;

            Size sizeTabControl = new Size(CreateForm.WidthComboBox * 2 + CreateForm.WidthComboBox / 4,
    CreateForm.HeightForm * 20);
            this.Size = new Size(sizeTabControl.Width + 50, sizeTabControl.Height + 50);
            string textCheckBox = "Добавить подраздел(ы)?";
            object[] countSubChapter = new object[] { 1, 2, 3, 4, 5, 6 };
            foreach (var chapter in chapters)
            {
                Point location = new Point(10, 35);
                TabPage tabPage = new TabPage();
                tabControl.TabPages.Add(tabPage);
                tabPage.Name = "TabPage" + iter.ToString();
                tabPage.Text = chapter;
                CheckBox checkBox = CreateForm.CreateCheckBox(tabPage.Name + "checkBox", location, textCheckBox);
                checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged); 
                tabPage.Controls.Add(checkBox);
                location.Y += distanceBetween;
                ComboBox comboBox = CreateForm.CreateComboBox(tabPage.Name + "comboBox", location, countSubChapter);
                comboBox.Enabled = false;
                comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedItem);
                tabPage.Controls.Add(comboBox);
                tabControl.Size = sizeTabControl;
                tabPage.Size = sizeTabControl;
                iter++;
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            TabPage selectedTabPage = tabControl1.SelectedTab;
            ComboBox cmb = selectedTabPage.Controls[selectedTabPage.Name + "comboBox"] as ComboBox;
            cmb.Enabled = !cmb.Enabled;
        }
        private void comboBox_SelectedItem(object sender, EventArgs e)
        {
            TabPage selectedTabPage = tabControl1.SelectedTab;
            ComboBox cmb = selectedTabPage.Controls[selectedTabPage.Name + "comboBox"] as ComboBox;
            int cuntSubChapter = Convert.ToInt32(cmb.SelectedItem);
            Point locationTextBox = new Point(10, 100);
            Size sizeTextBox = new Size(300, 25);
            for (int i = 0; i < cuntSubChapter; i++)
            {
                string nameTextBox = selectedTabPage.Name + "texBox" + i.ToString();
                selectedTabPage.Controls.Add(CreateForm.CreateTextBox(nameTextBox, locationTextBox, sizeTextBox));
                locationTextBox.Y += 25;
            }
        }
    }
}
