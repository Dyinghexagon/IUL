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
        private void buttonNewProject_Click(object sender, EventArgs e)
        {

        }
        private void buttonCreateIULs_Click(object sender, EventArgs e)
        {
            CreateIUL createIUL = new CreateIUL();
            createIUL.Show();
            this.Hide();
        }

        private void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            CreateFolderProject createFolder = new CreateFolderProject();
            createFolder.Show();
            this.Hide();
        }
        private void buttonAddChapters_Click(object sender, EventArgs e)
        {

        }
    }
}
