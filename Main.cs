using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ButtonCreateFolder_Click(object sender, EventArgs e)
        {
            try 
            {
				//тест создания новой ветки
				//тест создания новой ветки
                CreateFolderProject createFolderProject = new CreateFolderProject();
                Program.PreviosPage = this;
                createFolderProject.Show();
                this.Hide();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonNewProject_Click(object sender, EventArgs e)
        {
            try
            {
                CreateProject createProject = new CreateProject();
                Program.PreviosPage = this;
                createProject.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonAddChapters_Click(object sender, EventArgs e)
        {
            try
            {
                CreateChapter createChapter = new CreateChapter();
                Program.PreviosPage = this;
                createChapter.Show();
                this.Hide();
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
            CreateIUL createIUL = new CreateIUL();
            Program.PreviosPage = this;
            createIUL.Show();
            this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
 
        }

        private void ButtonAddPerformers_Click(object sender, EventArgs e)
        {
            try
            {
                CreatePerformer createPerformer = new CreatePerformer();
                Program.PreviosPage = this;
                createPerformer.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
    }
}
