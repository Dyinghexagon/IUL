using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class CreateIUL : Form
    {
        Project _selectedProject;
        public CreateIUL()
        {
            try 
            {
                InitializeComponent();
                Program.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
                Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewChapterNames);
                Program.GetMainMenu(ref MenuStrip);
                ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxProjectNames.DrawItem += Program.ComboBox_DrawItem;
                ComboBoxProjectNames.MeasureItem += Program.ComboBox_MeasureItem;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            try 
            {
                String dateSigning = DateTimePicker.Value.ToShortDateString();
                String pathMainFolder = String.Empty;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathMainFolder = folderBrowserDialog1.SelectedPath;
                _selectedProject.RolloutIULsForProject(dateSigning, pathMainFolder);
                MessageBox.Show("ИУЛы готовы!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String projectName = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(projectName);
                foreach(var chapter in _selectedProject.Chapters()) 
                {
                    DataGridViewChapterNames.Rows.Add(chapter.Value, chapter.Key.ChapterName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedProject.ChangeSelectedRolloutChapters(DataGridViewChapterNames[1, e.RowIndex].Value.ToString());
        }

        private void CreateIUL_Load(object sender, EventArgs e)
        {

        }
    }
}
