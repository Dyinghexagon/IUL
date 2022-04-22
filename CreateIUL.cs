using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class CreateIUL : Form
    {
        Project _selectedProject;
        DataGridViewCheckBoxColumn _checkCol;
        DataGridViewTextBoxColumn _textCol;
        public CreateIUL()
        {
            try 
            {
                InitializeComponent();
                DbProviderFactories.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
                _checkCol = new DataGridViewCheckBoxColumn();
                _checkCol.Name = "CheckCol";
                _checkCol.HeaderText = "CheckCol";
                _checkCol.Resizable = DataGridViewTriState.False;
                _checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                var textColCellStyle = new DataGridViewCellStyle();
                textColCellStyle.WrapMode = DataGridViewTriState.True;

                _textCol = new DataGridViewTextBoxColumn();
                _textCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                _textCol.Name = "TextCol";
                _textCol.HeaderText = "TextCol";
                _textCol.DefaultCellStyle = textColCellStyle;
                _textCol.ReadOnly = true;

                DataGridViewChapterNames.AllowUserToAddRows = false;
                DataGridViewChapterNames.AllowUserToDeleteRows = false;
                DataGridViewChapterNames.AllowUserToResizeColumns = false;
                DataGridViewChapterNames.AllowUserToResizeRows = false;
                DataGridViewChapterNames.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DataGridViewChapterNames.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DataGridViewChapterNames.CellMouseDown += DataGridView_CellMouseDown;
                DataGridViewChapterNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                DataGridViewChapterNames.ColumnHeadersVisible = false;
                DataGridViewChapterNames.BackgroundColor = Color.White;
                DataGridViewChapterNames.MultiSelect = false;
                DataGridViewChapterNames.RowHeadersVisible = false;
                DataGridViewChapterNames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                DataGridViewChapterNames.Columns.AddRange(new DataGridViewColumn[] 
                {
                    _checkCol, _textCol 
                });
                DataGridViewChapterNames.ClearSelection();

                ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxProjectNames.DrawItem += DbProviderFactories.ComboBox_DrawItem;
                ComboBoxProjectNames.MeasureItem += DbProviderFactories.ComboBox_MeasureItem;

                ToolStripMenuItem projectItem = new ToolStripMenuItem("Проект");
                ToolStripMenuItem projectItemCreateFolder = new ToolStripMenuItem("Создать папку проекта");
                projectItemCreateFolder.Click += CreateProjectFolder_Click;
                ToolStripMenuItem projectItemCreate = new ToolStripMenuItem("Создать папку проекта");
                projectItemCreate.Click += CreateProject_Click;
                ToolStripMenuItem projectItemEdit = new ToolStripMenuItem("Изменить проект");
                projectItemEdit.Click += EditProject_Click;
                projectItem.DropDownItems.Add(projectItemCreateFolder);
                projectItem.DropDownItems.Add(projectItemCreate);
                projectItem.DropDownItems.Add(projectItemEdit);
                MenuStrip.Items.Add(projectItem);

                ToolStripMenuItem chapterItem = new ToolStripMenuItem("Раздел");
                ToolStripMenuItem chapterItemCreate = new ToolStripMenuItem("Добавить раздел");
                chapterItemCreate.Click += CreateChapter_Click;
                ToolStripMenuItem chapterItemEdit = new ToolStripMenuItem("Изменить раздел");
                chapterItemEdit.Click += EditChapter_Click;
                chapterItem.DropDownItems.Add(chapterItemCreate);
                chapterItem.DropDownItems.Add(chapterItemEdit);
                MenuStrip.Items.Add(chapterItem);

                ToolStripMenuItem employeeItem = new ToolStripMenuItem("Сотрудник");
                ToolStripMenuItem employeeItemCreate = new ToolStripMenuItem("Добавить исполнителя к разделу");
                employeeItemCreate.Click += CreateEmployee_Click;
                ToolStripMenuItem employeeItemEdit = new ToolStripMenuItem("Изменить данные о сотруднике");
                employeeItemEdit.Click += EditEmployee_Click;
                employeeItem.DropDownItems.Add(employeeItemCreate);
                employeeItem.DropDownItems.Add(employeeItemEdit);
                MenuStrip.Items.Add(employeeItem);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void CreateProjectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFolderProject createFolderProject = new CreateFolderProject();
                Program.PreviosPage = this;
                createFolderProject.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void CreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                CreateProject createProject = new CreateProject();
                Program.PreviosPage = this;
                createProject.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void EditProject_Click(object sender, EventArgs e)
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
        private void CreateChapter_Click(object sender, EventArgs e)
        {
            try
            {
                CreateChapter createChapter = new CreateChapter();
                Program.PreviosPage = this;
                createChapter.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void EditChapter_Click(object sender, EventArgs e)
        {
            try
            {
                EditChapter editChapter = new EditChapter();
                Program.PreviosPage = this;
                editChapter.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void CreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                CreatePerformer createPerformer = new CreatePerformer();
                Program.PreviosPage = this;
                createPerformer.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void EditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EditEmployee editEmployee = new EditEmployee();
                Program.PreviosPage = this;
                editEmployee.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).Rows[e.RowIndex];
            if (row.Selected)
            {
                row.Cells[_checkCol.Index].Value = !(bool)row.Cells[_checkCol.Index].Value;
            }
        }
        private void ComboBoxNameProjects_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var text = lbox.Items[e.Index].ToString();
            var width = lbox.ClientSize.Width;
            var size = e.Graphics.MeasureString(text, lbox.Font, width);
            e.ItemHeight = (int)size.Height;
        }
        private void ComboBoxNameProjects_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var color =  SystemColors.Window;
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(lbox.Items[e.Index].ToString(), e.Font, SystemBrushes.WindowText, e.Bounds);
            }
        }
        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            try 
            {
                String dateSigning = DateTimePicker.Value.ToShortDateString();
                String pathMainFolder = String.Empty;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathMainFolder = folderBrowserDialog1.SelectedPath;
                _selectedProject.RolloutIULsForProject(dateSigning, pathMainFolder);
                MessageBox.Show("ИУЛы готовы!");
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
                String projectName = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(projectName);
                _selectedProject.FillingDataGridViewChapters(DataGridViewChapterNames);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedProject.ChangeSelectedRolloutChapters(DataGridViewChapterNames[1, e.RowIndex].Value.ToString());
        }
    }
}
