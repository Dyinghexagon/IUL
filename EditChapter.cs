using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class EditChapter : Form
    {
        Project _selectedProject;
        Chapter _selectedChapter;
        public EditChapter()
        {
            InitializeComponent();
            Program.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
            Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewChapterAuthors);
            Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewAuthors);
            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += Program.ComboBox_MeasureItem;

            ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxChapterNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxChapterNames.MeasureItem += Program.ComboBox_MeasureItem;

            foreach (var employee in Employee.Employees())
            {
                DataGridViewAuthors.Rows.Add(false, employee);
            }
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {

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

        private void CheckBoxEditNameChapter_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxEditName.Enabled = !TextBoxEditName.Enabled;
        }

        private void CheckBoxEditPath_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEditPath.Enabled = !ButtonEditPath.Enabled;
        }

        private void CheckBoxEditAuthors_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewAuthors.Enabled = !DataGridViewAuthors.Enabled;
        }

        private void ComboBoxProjectNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String nameProject = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(nameProject);
                foreach (var chapter in _selectedProject.Chapters())
                {
                    ComboBoxChapterNames.Items.Add(chapter.Key.ChapterName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception selected project", ex.Message);
            }
        }

        private void ComboBoxChapterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String nameChapter = ComboBoxChapterNames.Items[ComboBoxChapterNames.SelectedIndex].ToString();
                _selectedChapter = new Chapter(_selectedProject.Id, nameChapter);
                foreach(var autor in _selectedChapter.Authors()) 
                {
                    DataGridViewChapterAuthors.Rows.Add(true, autor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception selected chapter", ex.Message);
            }
        }

        private void ButtonEditPath_Click(object sender, EventArgs e)
        {
            try 
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                _selectedChapter.PathToFileChapter = folderBrowserDialog1.SelectedPath;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Exception selected new path", ex.Message);
            }
        }
    }
}
