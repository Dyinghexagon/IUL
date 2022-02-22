﻿using System;
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
                DbProviderFactories.InitializeComboBox(this.ComboBoxNameProjects, Tables.PROJECTS);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
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
        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            try 
            {
                String dateSigning = dateTimePicker1.Value.ToShortDateString();
                String pathMainFolder = String.Empty;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathMainFolder = folderBrowserDialog1.SelectedPath;
                this._selectedProject.RolloutIULsForProject(dateSigning, pathMainFolder);
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
                String projectName = ComboBoxNameProjects.Items[ComboBoxNameProjects.SelectedIndex].ToString();
                this._selectedProject = new Project(projectName);
                this._selectedProject.FillingListBoxChapters(this.CheckedListBoxChapters);
                this.Height += CheckedListBoxChapters.Height;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void CheckedListBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CheckedListBoxChapters_Click(object sender, EventArgs e)
        {
            Int32 selectedIndexChapter = CheckedListBoxChapters.SelectedIndex;
            Boolean ValueSelectedChapter = !CheckedListBoxChapters.GetItemChecked(selectedIndexChapter);
            String selectedChapter = CheckedListBoxChapters.Items[selectedIndexChapter].ToString();
            CheckedListBoxChapters.SetItemChecked(selectedIndexChapter, ValueSelectedChapter);
            _selectedProject.ChangeSelectedRolloutChapters(selectedChapter);
        }
    }
}
