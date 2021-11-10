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
            CreateFolderProject createFolderProject = new CreateFolderProject();
            Program.PreviosPage = this;
            createFolderProject.Show();
            this.Hide();
        }

        private void ButtonNewProject_Click(object sender, EventArgs e)
        {
            CreateProject createProject = new CreateProject();
            Program.PreviosPage = this;
            createProject.Show();
            this.Hide();
        }

        private void ButtonAddChapters_Click(object sender, EventArgs e)
        {
            CreateChapter createChapter = new CreateChapter();
            Program.PreviosPage = this;
            createChapter.Show();
            this.Hide();
        }

        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            CreateIUL createIUL = new CreateIUL();
            Program.PreviosPage = this;
            createIUL.Show();
            this.Hide();
        }

        private void ButtonAddPerformers_Click(object sender, EventArgs e)
        {
            CreatePerformer createPerformer = new CreatePerformer();
            Program.PreviosPage = this;
            createPerformer.Show();
            this.Hide();
        }
    }
}
