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
        DataGridViewCheckBoxColumn _checkColDataGridViewChapterAuthors;
        DataGridViewTextBoxColumn _textColDataGridViewChapterAuthors;
        DataGridViewCheckBoxColumn _checkColDataGridViewAuthors;
        DataGridViewTextBoxColumn _textColDataGridViewAuthors;
        public EditChapter()
        {
            InitializeComponent();
            DbProviderFactories.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += DbProviderFactories.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += DbProviderFactories.ComboBox_MeasureItem;

            ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxChapterNames.DrawItem += DbProviderFactories.ComboBox_DrawItem;
            ComboBoxChapterNames.MeasureItem += DbProviderFactories.ComboBox_MeasureItem;

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
