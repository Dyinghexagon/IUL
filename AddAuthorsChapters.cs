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
        public AddAuthorsChapters()
        {
            InitializeComponent();
        }
        public AddAuthorsChapters(List<string> chapters)
        {
            InitializeComponent();
            FillingTabControl(chapters, tabControl1);
        }
        private void FillingTabControl(List<string> chapters, TabControl tabControl) 
        {
            int distanceBetween = 25;
            int countCombobox = 6;
            int heightObject = 15;
            Size sizeTabControl = new Size(50 + 260, heightObject + heightObject * countCombobox + distanceBetween * countCombobox);
            int iter = 0;
            List<string> roles = new List<string>(Roles.GetFullOrAbbreviatedNameRoles(true));
            List<string> fioEmployees = new List<string>(Employees.GetFIOList());
            foreach (var chapter in chapters)
            {
                Point location = new Point(10, 35);
                TabPage tabPage = new TabPage();
                tabControl.TabPages.Add(tabPage);
                tabPage.Name = "TabPage" + iter.ToString();
                tabPage.Text = chapter;
                tabPage.Controls.Add(CreateLabel("label1" + tabPage.Name, new Point(location.X, location.Y - distanceBetween), "РОЛЬ"));
                tabPage.Controls.Add(CreateLabel("label2" + tabPage.Name, new Point(location.X + 130, location.Y - distanceBetween), "ИСПОЛНИТЕЛИ"));
                for (int i = 0; i < countCombobox; i++)
                {
                    string nameComboBoxWorkRole = "ComboBox" + i.ToString();
                    string nameComboBoxSurname = "ComboBox" + i.ToString() + "_2";
                    tabPage.Controls.Add(CreateComboBox(nameComboBoxWorkRole, location, roles.ToArray()));
                    tabPage.Controls.Add(CreateComboBox(nameComboBoxSurname, new Point(location.X + 130, location.Y), fioEmployees.ToArray()));
                    location.Y += distanceBetween;
                }
                tabPage.Controls.Add(CreateButton("Button" + tabPage.Name, new Point(location.X + 130, location.Y), "Добавить"));
                tabControl.Size = sizeTabControl;
                tabPage.Size = sizeTabControl;
                iter++;
            }
        }
        private Label CreateLabel(string name, Point location, string text) 
        {
            Label label = new Label();
            label.Size = new Size(text.Length * 10, 15);
            label.Name = name;
            label.Location = location;
            label.Text = text;
            return label;
        }
        private Button CreateButton(string name, Point location, string text) 
        {
            Button button = new Button();
            button.Name = name;
            button.Location = location;
            button.Text = text;
            button.Click += new System.EventHandler(this.button_click);
            return button;
        }
        private ComboBox CreateComboBox(string name, Point location, object[] arr) 
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Size = new Size(120, 15);
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
        private void button_click(object sender, EventArgs e) 
        {
            MessageBox.Show(tabControl1.SelectedTab.Text);
        }
    }
}
