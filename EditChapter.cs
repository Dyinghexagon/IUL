using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class EditChapter : Form
    {
        public EditChapter()
        {
            InitializeComponent();
            Program.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
            Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewChapterAuthors);
            Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewAuthors);
            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += Program.ComboBox_MeasureItem;

            ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxChapterNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxChapterNames.MeasureItem += Program.ComboBox_MeasureItem
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {

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
