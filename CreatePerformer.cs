using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class CreatePerformer : Form
    {
        private Performer _newPerformer;
        private Project _selectedProject;
        DataGridViewTextBoxColumn _textCol;
        Int32 _height = 0;
        HashSet<String> _selectedChapters;
        public CreatePerformer()
        {
            try 
            {
                InitializeComponent();
                Program.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
                Program.InitializeComboBox(ComboBoxRoles, Tables.ROLES);
                Program.InitializeComboBox(ComboBoxEmployees, Tables.EMPLOYEES);
                _newPerformer = new Performer();

                var textColCellStyle = new DataGridViewCellStyle();
                textColCellStyle.WrapMode = DataGridViewTriState.True;

                _textCol = new DataGridViewTextBoxColumn();
                _textCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                _textCol.Name = "TextCol";
                _textCol.HeaderText = "TextCol";
                _textCol.DefaultCellStyle = textColCellStyle;
                _textCol.ReadOnly = true;

                DataGridViewSelectedChapter.AllowUserToAddRows = false;
                DataGridViewSelectedChapter.AllowUserToDeleteRows = false;
                DataGridViewSelectedChapter.AllowUserToResizeColumns = false;
                DataGridViewSelectedChapter.AllowUserToResizeRows = false;
                DataGridViewSelectedChapter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DataGridViewSelectedChapter.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DataGridViewSelectedChapter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                DataGridViewSelectedChapter.ColumnHeadersVisible = false;
                DataGridViewSelectedChapter.BackgroundColor = Color.White;
                DataGridViewSelectedChapter.MultiSelect = false;
                DataGridViewSelectedChapter.RowHeadersVisible = false;
                DataGridViewSelectedChapter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                DataGridViewSelectedChapter.Columns.AddRange(_textCol);
                DataGridViewSelectedChapter.ClearSelection();

                DataGridViewSelectedChapter.Visible = false;
                LableSelectedChapter.Visible = false;

                Height -= DataGridViewSelectedChapter.Height;
                Height -= LableSelectedChapter.Height;
                _height = this.Height;
                _selectedChapters = new HashSet<String>();

                ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxProjectNames.DrawItem += Program.ComboBox_DrawItem;
                ComboBoxProjectNames.MeasureItem += Program.ComboBox_MeasureItem;

                ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxChapterNames.DrawItem += Program.ComboBox_DrawItem;
                ComboBoxChapterNames.MeasureItem += Program.ComboBox_MeasureItem;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                ComboBoxChapterNames.Items.Clear();
                String nameSelectedProject = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(nameSelectedProject);
                foreach(var chapter in _selectedProject.Chapters()) 
                {
                    ComboBoxChapterNames.Items.Add(chapter.ChapterName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonAddNewPerformer_Click(object sender, EventArgs e)
        {
            if (CheckBoxIsAddMultiple.Checked) 
            {
                try 
                {
                    Performer performer = new Performer();
                    performer.EmployeeId = _newPerformer.EmployeeId;
                    performer.RoleId = _newPerformer.RoleId;
                    foreach(var chapterName in _selectedChapters) 
                    {
                        Chapter chapter = new Chapter(_selectedProject.Id, chapterName);
                        performer.ChapterId = chapter.Id;
                        performer.InsertNewPerformer();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
            }
            else 
            {
                try 
                {
                    _newPerformer.InsertNewPerformer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
            }
            MessageBox.Show("Исполнитель добавлен!");
        }

        private void ComboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String selectedSurnameEmployee = ComboBoxEmployees.Items[ComboBoxEmployees.SelectedIndex].ToString();
                Employee selectedEmployee = new Employee(selectedSurnameEmployee);
                _newPerformer.EmployeeId = selectedEmployee.Id;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ComboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String selecteAbbreviatedNameRole = ComboBoxRoles.Items[ComboBoxRoles.SelectedIndex].ToString();
                Role selectedRole = new Role(selecteAbbreviatedNameRole);
                _newPerformer.RoleId = selectedRole.Id;

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ComboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectedNameChapter = ComboBoxChapterNames.Items[ComboBoxChapterNames.SelectedIndex].ToString();
                Chapter chapter = new Chapter(_selectedProject.Id, selectedNameChapter);
                _newPerformer.ChapterId = chapter.Id;
                if(_selectedChapters.Add(selectedNameChapter)) DataGridViewSelectedChapter.Rows.Add(selectedNameChapter);
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

        private void CheckBoxIsAddMultiple_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedChapter.Visible = !DataGridViewSelectedChapter.Visible;
            LableSelectedChapter.Visible = !LableSelectedChapter.Visible;
            if (DataGridViewSelectedChapter.Visible)
            {
                this.Height += DataGridViewSelectedChapter.Height;
                this.Height += LableSelectedChapter.Height;
            }
            else 
            {
                this.Height = _height;
            }
        }
    }
}
