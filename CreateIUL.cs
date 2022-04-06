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
        DataGridViewComboBoxColumn _comboboxCell;
        DataGridViewTextBoxColumn _textCol;
        DataGridViewTextBoxColumn _textCol1;
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

                _comboboxCell = new DataGridViewComboBoxColumn();
                _comboboxCell.Name = "ComboboxCol";
                _comboboxCell.HeaderText = "ComboboxCol";
                _comboboxCell.Resizable = DataGridViewTriState.False;
                _comboboxCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                var textColCellStyle = new DataGridViewCellStyle();
                textColCellStyle.WrapMode = DataGridViewTriState.True;

                _textCol = new DataGridViewTextBoxColumn();
                _textCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                _textCol.Name = "TextCol";
                _textCol.HeaderText = "TextCol";
                _textCol.DefaultCellStyle = textColCellStyle;
                _textCol.ReadOnly = true;


                _textCol1 = new DataGridViewTextBoxColumn();
                _textCol1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                _textCol1.Name = "TextCol1";
                _textCol1.HeaderText = "TextCol1";
                _textCol1.DefaultCellStyle = textColCellStyle;
                _textCol1.ReadOnly = true;

                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AllowUserToResizeColumns = false;
                dataGridView.AllowUserToResizeRows = false;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView.CellMouseDown += dataGridView_CellMouseDown;
                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView.ColumnHeadersVisible = false;
                dataGridView.BackgroundColor = Color.White;
                dataGridView.MultiSelect = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                dataGridView.Columns.AddRange(new DataGridViewColumn[] 
                {
                    _checkCol, _textCol 
                });
                dataGridView.ClearSelection();
                dataGridView1.AllowUserToAddRows = false;
                //dataGridView1.AllowUserToDeleteRows = false;
                //dataGridView1.AllowUserToResizeColumns = false;
                //dataGridView1.AllowUserToResizeRows = false;
                //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView1.ColumnHeadersVisible = false;
                //dataGridView1.BackgroundColor = Color.White;
                //dataGridView1.MultiSelect = false;
                //dataGridView1.RowHeadersVisible = false;
                //dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _comboboxCell.Items.AddRange(new String[] { "1", "2", "3" });
                dataGridView1.Columns.AddRange(_comboboxCell);
                dataGridView1.ClearSelection();
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
                this._selectedProject.FillingDataGridViewChapters(this.dataGridView);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedProject.ChangeSelectedRolloutChapters(dataGridView[1, e.RowIndex].Value.ToString());
        }
    }
}
