using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class EditProject : Form
    {
        Project _selectedProject;
        public EditProject()
        {
            InitializeComponent();
            DbProviderFactories.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += Main.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += Main.ComboBox_MeasureItem;
            ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxChapterNames.DrawItem += Main.ComboBox_DrawItem;
            ComboBoxChapterNames.MeasureItem += Main.ComboBox_MeasureItem;
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
        private void ComboBoxProjectNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            String projectName = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
            _selectedProject = new Project(projectName);
            foreach(var chapter in _selectedProject.Chapters()) 
            {
                ComboBoxChapterNames.Items.Add(chapter.ChapterName);
            }
        }
    }
}
