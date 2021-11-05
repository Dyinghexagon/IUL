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
        private void ButtonNewProject_Click(object sender, EventArgs e)
        {

        }
        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            CreateIUL createIUL = new CreateIUL();
            createIUL.Show();
            this.Hide();
        }

        private void ButtonCreateFolder_Click(object sender, EventArgs e)
        {
            CreateFolderProject createFolder = new CreateFolderProject();
            createFolder.Show();
            this.Hide();
        }
        private void ButtonAddChapters_Click(object sender, EventArgs e)
        {

        }
    }
}
