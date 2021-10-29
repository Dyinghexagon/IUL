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
            int iter = 0;
            List<string> roles = new List<string>(Roles.GetFullOrAbbreviatedNameRoles(true));
            List<string> fioEmployees = new List<string>(Employee.GetFIOList());
            Size sizeTabControl = new Size(CreateForm.WidthComboBox * 2 + CreateForm.WidthComboBox / 4,
    CreateForm.HeightForm * 17);
            this.Size = new Size(sizeTabControl.Width + 50, sizeTabControl.Height + 50);
            foreach (var chapter in chapters)
            {
                Point location = new Point(10, 35);
                TabPage tabPage = new TabPage();
                tabControl.TabPages.Add(tabPage);
                tabPage.Name = "TabPage" + iter.ToString();
                tabPage.Text = chapter;
                tabPage.Controls.Add(CreateForm.CreateLabel("label1" + tabPage.Name, 
                    new Point(location.X, location.Y - distanceBetween), "РОЛЬ"));
                tabPage.Controls.Add(CreateForm.CreateLabel("label2" + tabPage.Name, 
                    new Point(location.X + 130, location.Y - distanceBetween), "ИСПОЛНИТЕЛИ"));
                for (int i = 0; i < countCombobox; i++)
                {
                    string nameComboBoxWorkRole = "ComboBox" + i.ToString();
                    string nameComboBoxSurname = "ComboBox" + i.ToString() + "_2";
                    ComboBox comboBoxWorkRole = CreateForm.CreateComboBox(nameComboBoxWorkRole, location, roles.ToArray());
                    ComboBox comboBoxEmployee = CreateForm.CreateComboBox(nameComboBoxSurname, 
                        new Point(location.X + CreateForm.WidthComboBox + distanceBetween, location.Y),
                        fioEmployees.ToArray());
                    comboBoxWorkRole.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseWheel);
                    comboBoxEmployee.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseWheel);
                    tabPage.Controls.Add(comboBoxWorkRole);
                    tabPage.Controls.Add(comboBoxEmployee);
                    location.Y += distanceBetween;
                }
                Button buttonAdd = CreateForm.CreateButton("Button" + tabPage.Name, new Point(location.X + CreateForm.WidthComboBox + distanceBetween, 
                    location.Y), "Добавить");
                buttonAdd.Click += new System.EventHandler(this.button_click);
                tabPage.Controls.Add(buttonAdd);
                tabControl.Size = sizeTabControl;
                tabPage.Size = sizeTabControl;
                iter++;
            }
        }
        private void comboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        private void button_click(object sender, EventArgs e) 
        {
            MessageBox.Show(tabControl1.SelectedTab.Text);
        }

        private void AddAuthorsChapters_Load(object sender, EventArgs e)
        {

        }
    }
}
