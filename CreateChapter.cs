using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
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
                DbProviderFactories.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
                _newChapter = new Chapter();

                ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxProjectNames.DrawItem += Main.ComboBox_DrawItem;
                ComboBoxProjectNames.MeasureItem += Main.ComboBox_MeasureItem;

                ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxChapterNames.DrawItem += Main.ComboBox_DrawItem;
                ComboBoxChapterNames.MeasureItem += Main.ComboBox_MeasureItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var text = lbox.Items[e.Index].ToString();
            var width = lbox.ClientSize.Width;
            var size = e.Graphics.MeasureString(text, lbox.Font, width);
            e.ItemHeight = (int)size.Height;
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var color = SystemColors.Window;
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(lbox.Items[e.Index].ToString(), e.Font, SystemBrushes.WindowText, e.Bounds);
            }
        }
        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String nameProject = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
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
                this.ComboBoxChapterNames.Items.AddRange(this._selectedProject.Surveys.GetSurveys());
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
                String nameSelectedChapter = ComboBoxChapterNames.Items[ComboBoxChapterNames.SelectedIndex].ToString();
                this._newChapter.NumberChapter = ComboBoxChapterNames.SelectedIndex++;
                MessageBox.Show(this._newChapter.NumberChapter.ToString());
                if (this._selectedProject.CapitalOrLinear && (this._newChapter.NumberChapter >= 4 && this._newChapter.NumberChapter <= 10))
                {
                    this._newChapter.ChapterName =
                        "Раздел 5. Сведения об инженерном оборудовании, о сетях инженерно-технического обеспечения, " +
                        "перечень инженерно-технических мероприятий, содержание технологических решений ";
                }
                this._newChapter.ChapterName += nameSelectedChapter;
                
                this._newChapter.Id = (this.CheckBoxUniqueIdChapter.Checked)? this.TextBoxIdChapter.Text : LabelIdProject.Text + "-" + TextBoxIdChapter?.Text;
                this._newChapter.ChapterName += " " + TextBoxNameSubChapter?.Text;
                this._newChapter.ProjectId = this.LabelIdProject.Text;
                this._newChapter.InsertNewChapter();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            finally 
            { 
                TextBoxNameSubChapter.Clear();
                this._newChapter.ChapterName = String.Empty;
            }
            MessageBox.Show("Раздел добавлен!");

        }

        private void ButtonSelecFileChapter_Click(object sender, EventArgs e)
        {
            try 
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    this._newChapter.PathToFileChapter = openFileDialog1.FileName;
                    this._newChapter.NameFileChapter = this._newChapter.PathToFileChapter.Split("\\").Last();
                }
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