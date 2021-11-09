using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class CreateChapter : Form
    {
        private Project _selectedProject;
        private Chapter _newChapter;
        public CreateChapter()
        {
            InitializeComponent();
            InitializeProjects();
            _newChapter = new Chapter();
        }

        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameProject = ComboBoxNameProjects.Items[ComboBoxNameProjects.SelectedIndex].ToString();
            _selectedProject = new Project(nameProject);
            LabelIdProject.Text = _selectedProject.Id;
            if (_selectedProject.CapitalOrLinear) 
            {
                FilingComboBoxCapitalChapter();
            }
            else 
            {
                FilingComboBoxLinearChapter();
            }
        }
        private void ComboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ComboBoxChapters.SelectedIndex;
            if (this._selectedProject.CapitalOrLinear && selectedIndex >= 4 && selectedIndex <= 10)
            {
                this._newChapter.ChapterName =
                    "Раздел 5. Сведения об инженерном оборудовании, о сетях инженерно-технического обеспечения, " +
                    "перечень инженерно-технических мероприятий, содержание технологических решений ";
            }
            this._newChapter.ChapterName += ComboBoxChapters.Items[ComboBoxChapters.SelectedIndex].ToString();
        }
        private void ButtonAddNewChapter_Click(object sender, EventArgs e)
        {
            this._newChapter.ChapterId = LabelIdProject.Text;
            if (TextBoxIdChapter.Text.Length != 0 && ComboBoxChapters.SelectedIndex != -1)
            {
                this._newChapter.ChapterId += "-"+ TextBoxIdChapter?.Text;
            }
            else
            {
                MessageBox.Show("Выберите раздел и/или напишите впишите шифр!");
            }
            if (TextBoxIdSubChapter.Text.Length != 0)
            {
                this._newChapter.ChapterId += "." + TextBoxIdSubChapter?.Text;
                if (TextBoxNameSubChapter.Text.Length != 0)
                {
                    this._newChapter.ChapterName += " Часть "+ TextBoxIdSubChapter.Text + ". " + TextBoxNameSubChapter.Text;
                }
                else
                {
                    MessageBox.Show("Введите наименование подраздела!");
                }
            }

            this._newChapter.ProjectId = this.LabelIdProject.Text;
            if (this._newChapter.InsertNewChapter())
            {
                MessageBox.Show("Раздел добавлен!");
                TextBoxNameSubChapter.Clear();
                TextBoxIdSubChapter.Clear();
            }
        }

        private void ButtonSelecFileChapter_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                this._newChapter.NameFileChapter = openFileDialog1.SafeFileName;
        }
    }
}