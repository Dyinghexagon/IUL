using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class Form1 : Form
    {
        Project _selectedProject;
        public Form1()
        {
            InitializeComponent();
            Project.InitializeComboBoxProjects(this.ComboBoxNameProjects);
            
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.PreviosPage.Show();
            this.Hide();
            Program.PreviosPage = this;
        }
        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            try 
            {
                string dateSigning = dateTimePicker1.Value.ToShortDateString();
                string pathMainFolder = "";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathMainFolder = folderBrowserDialog1.SelectedPath;
                this._selectedProject.CreateTable(dateSigning, pathMainFolder);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            finally 
            {
                MessageBox.Show("ИУЛы готовы!");
            }
        }
        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string projectName = ComboBoxNameProjects.Items[ComboBoxNameProjects.SelectedIndex].ToString();
            this._selectedProject = new Project(projectName);
        }
    }
}
