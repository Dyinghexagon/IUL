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
                DbProviderFactories.InitializeComboBox(this.ComboBoxNameProjects, Tables.PROJECTS);
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
                DataGridViewChapterNames.CellMouseDown += dataGridView_CellMouseDown;
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
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).Rows[e.RowIndex];
            if (row.Selected)
            {
                row.Cells[_checkCol.Index].Value = !(bool)row.Cells[_checkCol.Index].Value;
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
        private void ButtonCreateIULs_Click(object sender, EventArgs e)
        {
            try 
            {
                String dateSigning = dateTimePicker1.Value.ToShortDateString();
                String pathMainFolder = String.Empty;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                pathMainFolder = folderBrowserDialog1.SelectedPath;
                this._selectedProject.RolloutIULsForProject(dateSigning, pathMainFolder);
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
                String projectName = ComboBoxNameProjects.Items[ComboBoxNameProjects.SelectedIndex].ToString();
                this._selectedProject = new Project(projectName);
                this._selectedProject.FillingDataGridViewChapters(this.DataGridViewChapterNames);

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
