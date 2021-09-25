using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class AddChapters : Form
    {
        public AddChapters()
        {
            InitializeComponent();
        }
        public AddChapters(Dictionary<string, string> chapters) 
        {
            InitializeComponent();
            foreach(var chapter in chapters) 
            {
                textBox1.Text += "key: " + chapter.Key + " value: " + chapter.Value + "\n";
            }
        }
        private void AddChapters_Load(object sender, EventArgs e)
        {

        }
    }
}
