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

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            this.Visible = false;
            addProject.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateIUL createIUL = new CreateIUL();
            createIUL.Show();
            this.Hide();
        }
    }
}
