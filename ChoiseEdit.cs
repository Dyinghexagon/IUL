using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class ChoiseEdit : Form
    {
        public ChoiseEdit()
        {
            InitializeComponent();
        }

        private void ButtonEditProject_Click(object sender, EventArgs e)
        {
            try 
            {
                EditProject editProject = new EditProject();
                Program.PreviosPage = this;
                editProject.Show();
                this.Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonEditChapter_Click(object sender, EventArgs e)
        {
            try
            {
                EditProject editProject = new EditProject();
                Program.PreviosPage = this;
                editProject.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EditProject editProject = new EditProject();
                Program.PreviosPage = this;
                editProject.Show();
                this.Hide();
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
    }
}
