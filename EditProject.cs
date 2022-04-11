using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    /// <summary>
    /// To-do list:
    /// 1. Зафиксировать выбранный раздел
    /// 2. Зафиксировать все изменения
    /// 3. Добавить в класс Chapter метод Update
    /// </summary>
    public partial class EditProject : Form
    {
        Project _selectedProject;
        DataGridViewCheckBoxColumn _checkColDataGridViewChapterAuthors;
        DataGridViewTextBoxColumn _textColDataGridViewChapterAuthors;
        DataGridViewCheckBoxColumn _checkColDataGridViewAuthors;
        DataGridViewTextBoxColumn _textColDataGridViewAuthors;
        public EditProject()
        {
            InitializeComponent();
            DbProviderFactories.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += Main.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += Main.ComboBox_MeasureItem;
            ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxChapterNames.DrawItem += Main.ComboBox_DrawItem;
            ComboBoxChapterNames.MeasureItem += Main.ComboBox_MeasureItem;
            DbProviderFactories.InitializeComboBox(ComboBoxeEmployeesGIP, Tables.EMPLOYEES);
            DbProviderFactories.InitializeComboBox(ComboBoxeEmployeesNkontr, Tables.EMPLOYEES);

            _checkColDataGridViewChapterAuthors = new DataGridViewCheckBoxColumn();
            _checkColDataGridViewChapterAuthors.Name = "CheckColDataGridViewChapterAuthors";
            _checkColDataGridViewChapterAuthors.HeaderText = "CheckColDataGridViewChapterAuthors";
            _checkColDataGridViewChapterAuthors.Resizable = DataGridViewTriState.False;
            _checkColDataGridViewChapterAuthors.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            var textColCellStyle = new DataGridViewCellStyle();
            textColCellStyle.WrapMode = DataGridViewTriState.True;

            _textColDataGridViewChapterAuthors = new DataGridViewTextBoxColumn();
            _textColDataGridViewChapterAuthors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _textColDataGridViewChapterAuthors.Name = "TextColDataGridViewChapterAuthors";
            _textColDataGridViewChapterAuthors.HeaderText = "TextColDataGridViewChapterAuthors";
            _textColDataGridViewChapterAuthors.DefaultCellStyle = textColCellStyle;
            _textColDataGridViewChapterAuthors.ReadOnly = true;

            DataGridViewChapterAuthors.AllowUserToAddRows = false;
            DataGridViewChapterAuthors.AllowUserToDeleteRows = false;
            DataGridViewChapterAuthors.AllowUserToResizeColumns = false;
            DataGridViewChapterAuthors.AllowUserToResizeRows = false;
            DataGridViewChapterAuthors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewChapterAuthors.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridViewChapterAuthors.CellMouseDown += DataGridView_CellMouseDown;
            DataGridViewChapterAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewChapterAuthors.ColumnHeadersVisible = false;
            DataGridViewChapterAuthors.BackgroundColor = Color.White;
            DataGridViewChapterAuthors.MultiSelect = false;
            DataGridViewChapterAuthors.RowHeadersVisible = false;
            DataGridViewChapterAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            DataGridViewChapterAuthors.Columns.AddRange(new DataGridViewColumn[]
            {
                    _checkColDataGridViewChapterAuthors, _textColDataGridViewChapterAuthors
            });
            DataGridViewChapterAuthors.ClearSelection();

            _checkColDataGridViewAuthors = new DataGridViewCheckBoxColumn();
            _checkColDataGridViewAuthors.Name = "CheckColDataGridViewAuthors";
            _checkColDataGridViewAuthors.HeaderText = "CheckColDataGridViewAuthors";
            _checkColDataGridViewAuthors.Resizable = DataGridViewTriState.False;
            _checkColDataGridViewAuthors.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _textColDataGridViewAuthors = new DataGridViewTextBoxColumn();
            _textColDataGridViewAuthors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _textColDataGridViewAuthors.Name = "TextColDataGridViewAuthors";
            _textColDataGridViewAuthors.HeaderText = "TextColDataGridViewAuthors";
            _textColDataGridViewAuthors.DefaultCellStyle = textColCellStyle;
            _textColDataGridViewAuthors.ReadOnly = true;

            DataGridViewAuthors.AllowUserToAddRows = false;
            DataGridViewAuthors.AllowUserToDeleteRows = false;
            DataGridViewAuthors.AllowUserToResizeColumns = false;
            DataGridViewAuthors.AllowUserToResizeRows = false;
            DataGridViewAuthors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewAuthors.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridViewAuthors.CellMouseDown += DataGridView_CellMouseDown;
            DataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAuthors.ColumnHeadersVisible = false;
            DataGridViewAuthors.BackgroundColor = Color.White;
            DataGridViewAuthors.MultiSelect = false;
            DataGridViewAuthors.RowHeadersVisible = false;
            DataGridViewAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            DataGridViewAuthors.Columns.AddRange(new DataGridViewColumn[]
            {
                    _checkColDataGridViewAuthors, _textColDataGridViewAuthors
            });
            DataGridViewAuthors.ClearSelection();
            
        }
        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).Rows[e.RowIndex];
            if (row.Selected)
            {
                row.Cells[_checkColDataGridViewChapterAuthors.Index].Value = !(bool)row.Cells[_checkColDataGridViewChapterAuthors.Index].Value;
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
        private void ComboBoxProjectNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                ComboBoxChapterNames.Items.Clear();
                String projectName = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(projectName);
                foreach (var chapter in _selectedProject.Chapters())
                {
                    ComboBoxChapterNames.Items.Add(chapter.ChapterName);
                }
                Employee GIP = new Employee(_selectedProject.IdGIP);
                Employee Nkontr = new Employee(_selectedProject.IdNkont);
                TextBoxGIP.Text = GIP.Surname;
                TextBoxNkontr.Text = Nkontr.Surname;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void ComboBoxChapterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewChapterAuthors.Rows.Clear();
                String chapterName = ComboBoxChapterNames.Items[ComboBoxChapterNames.SelectedIndex].ToString();
                Chapter selectedChapter = new Chapter(_selectedProject.Id, chapterName);
                foreach (var author in selectedChapter.Authors())
                {
                    DataGridViewChapterAuthors.Rows.Add(true, author);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void ButtonEdicting_Click(object sender, EventArgs e)
        {

        }
        private void CheckBoxChangeGIP_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxeEmployeesGIP.Enabled = !ComboBoxeEmployeesGIP.Enabled;
        }
        private void CheckBoxChangeNkontr_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxeEmployeesNkontr.Enabled = !ComboBoxeEmployeesNkontr.Enabled;

        }
        private void CheckBoxChangeAuthors_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewAuthors.Enabled = !DataGridViewAuthors.Enabled;
            try 
            {
                DataGridViewAuthors.Rows.Clear();
                foreach(String employee in ComboBoxeEmployeesGIP.Items) 
                {
                    DataGridViewAuthors.Rows.Add(false, employee.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }

        }
    }
}
