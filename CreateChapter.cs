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
            try 
            {
                InitializeComponent();
                Project.InitializeComboBoxProjects(this.ComboBoxNameProjects);
                _newChapter = new Chapter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ComboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                int selectedIndex = ComboBoxChapters.SelectedIndex;
                string nameSelectedChapter = ComboBoxChapters.Items[ComboBoxChapters.SelectedIndex].ToString();
                if (this._selectedProject.CapitalOrLinear && selectedIndex >= 4 && selectedIndex <= 10)
                {
                    this._newChapter.ChapterName =
                        "Раздел 5. Сведения об инженерном оборудовании, о сетях инженерно-технического обеспечения, " +
                        "перечень инженерно-технических мероприятий, содержание технологических решений ";
                }
                this._newChapter.ChapterName = nameSelectedChapter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ButtonAddNewChapter_Click(object sender, EventArgs e)
        {
            try 
            {
                this._newChapter.ChapterId = LabelIdProject.Text;
                this._newChapter.ChapterId += "-" + TextBoxIdChapter?.Text;
                if (TextBoxIdSubChapter.Text.Length != 0)
                {
                    this._newChapter.ChapterId += "." + TextBoxIdSubChapter?.Text;
                    if (TextBoxNameSubChapter.Text.Length != 0)
                    {
                        this._newChapter.ChapterName += " Часть " + TextBoxIdSubChapter.Text + ". " + TextBoxNameSubChapter.Text;
                    }
                    else
                    {
                        MessageBox.Show("Введите наименование подраздела!");
                    }
                }

                this._newChapter.ProjectId = this.LabelIdProject.Text;
                this._newChapter.InsertNewChapter();
                MessageBox.Show("Раздел добавлен!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            finally 
            { 
                TextBoxNameSubChapter.Clear();
                TextBoxIdSubChapter.Clear();
            }
        }

        private void ButtonSelecFileChapter_Click(object sender, EventArgs e)
        {
            try 
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    this._newChapter.NameFileChapter = openFileDialog1.SafeFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonCrossCreatePerformer_Click(object sender, EventArgs e)
        {
            try 
            {
                CreatePerformer createPerformer = new CreatePerformer();
                createPerformer.Show();
                this.Hide();
                Program.PreviosPage = this;
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