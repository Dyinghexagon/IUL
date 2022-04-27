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
    public partial class EditChapter : Form
    {
        Project _selectedProject;
        Chapter _selectedChapter;
        public EditChapter()
        {
            InitializeComponent();
            Program.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
            InitializationDataGridViewAuthors(ref DataGridViewAuthors);
            InitializationDataGridViewChapterAuthors(ref DataGridViewChapterAuthors);
            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += Program.ComboBox_MeasureItem;

            ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxChapterNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxChapterNames.MeasureItem += Program.ComboBox_MeasureItem;

            foreach (var employee in Employee.Employees())
            {
                DataGridViewAuthors.Rows.Add(false, employee);
            }
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try 
            {
                _selectedChapter.ChapterName = (CheckBoxEditNameChapter.Checked && TextBoxEditName.TextLength >0)? TextBoxEditName.Text: _selectedChapter.ChapterName;
                List<KeyValuePair<Role, Employee>> authors = new List<KeyValuePair<Role, Employee>>();
                for (Int32 i = 0; i < DataGridViewChapterAuthors.RowCount; i++)
                {
                    if (Convert.ToBoolean(DataGridViewChapterAuthors[0, i].Value)) 
                    {
                        Role role = new Role(DataGridViewChapterAuthors[1, i].Value.ToString());
                        Employee employee = new Employee(DataGridViewChapterAuthors[2, i].Value.ToString());
                        authors.Add(new KeyValuePair<Role, Employee>(role, employee));
                    }
                }
                for (Int32 i = 0; i < DataGridViewAuthors.RowCount; i++)
                {
                    if (Convert.ToBoolean(DataGridViewAuthors[0, i].Value))
                    {
                        Role role = new Role(DataGridViewAuthors[1, i].Value.ToString());
                        Employee employee = new Employee(DataGridViewAuthors[2, i].Value.ToString());
                        authors.Add(new KeyValuePair<Role, Employee>(role, employee));
                    }
                }
                _selectedChapter.UpdateAuthors(authors);
                _selectedChapter.Update();
                Performer.Update(_selectedChapter.ChapterName, authors);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Exception editing chapter", ex.GetType().Name);
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
                MessageBox.Show("Exception button back", ex.GetType().Name);
            }
        }

        private void CheckBoxEditNameChapter_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxEditName.Enabled = !TextBoxEditName.Enabled;
        }

        private void CheckBoxEditPath_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEditPath.Enabled = !ButtonEditPath.Enabled;
        }

        private void CheckBoxEditAuthors_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewAuthors.Enabled = !DataGridViewAuthors.Enabled;
        }

        private void ComboBoxProjectNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String nameProject = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(nameProject);
                foreach (var chapter in _selectedProject.Chapters())
                {
                    ComboBoxChapterNames.Items.Add(chapter.Key.ChapterName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception selected project", ex.GetType().Name);
            }
        }

        private void ComboBoxChapterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String nameChapter = ComboBoxChapterNames.Items[ComboBoxChapterNames.SelectedIndex].ToString();
                _selectedChapter = new Chapter(_selectedProject.Id, nameChapter);
                foreach(var autor in _selectedChapter.Authors()) 
                {
                    DataGridViewChapterAuthors.Rows.Add(true, autor.Value.Surname, autor.Key.AbbreviatedName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception selected chapter", ex.GetType().Name);
            }
        }

        private void ButtonEditPath_Click(object sender, EventArgs e)
        {
            try 
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                _selectedChapter.PathToFileChapter = openFileDialog1.FileName;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Exception selected new path", ex.GetType().Name);
            }
        }

        private void InitializationDataGridViewAuthors(ref DataGridView dataGridView)
        {
            try 
            {
                DataGridViewCheckBoxColumn checkCol;
                DataGridViewTextBoxColumn textCol;
                DataGridViewComboBoxColumn comboBoxCol;

                checkCol = new DataGridViewCheckBoxColumn();
                checkCol.Name = "CheckCol";
                checkCol.HeaderText = "CheckCol";
                checkCol.Resizable = DataGridViewTriState.False;
                checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                var textColCellStyle = new DataGridViewCellStyle();
                textColCellStyle.WrapMode = DataGridViewTriState.True;

                textCol = new DataGridViewTextBoxColumn();
                textCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                textCol.Name = "TextCol";
                textCol.HeaderText = "TextCol";
                textCol.DefaultCellStyle = textColCellStyle;
                textCol.ReadOnly = true;

                comboBoxCol = new DataGridViewComboBoxColumn();
                comboBoxCol.Name = "comboBoxCol";
                comboBoxCol.HeaderText = "comboBoxCol";
                List<String> roles = Role.Roles().ToList();
                comboBoxCol.DataSource = roles;

                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AllowUserToResizeColumns = false;
                dataGridView.AllowUserToResizeRows = false;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView.CellMouseDown += Program.DataGridView_CellMouseDown;
                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView.ColumnHeadersVisible = false;
                dataGridView.BackgroundColor = Color.White;
                dataGridView.MultiSelect = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                dataGridView.Columns.AddRange(new DataGridViewColumn[]
                {
                    checkCol,comboBoxCol, textCol
                });
                dataGridView.ClearSelection();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Exception InitializationDataGridViewAuthors", ex.GetType().ToString());
            }
        }
        private void InitializationDataGridViewChapterAuthors(ref DataGridView dataGridView)
        {
            try 
            {
                DataGridViewCheckBoxColumn checkCol;
                DataGridViewTextBoxColumn textSurnameCol;
                DataGridViewTextBoxColumn textRoleCol;

                checkCol = new DataGridViewCheckBoxColumn();
                checkCol.Name = "CheckCol";
                checkCol.HeaderText = "CheckCol";
                checkCol.Resizable = DataGridViewTriState.False;
                checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                var textColCellStyle = new DataGridViewCellStyle();
                textColCellStyle.WrapMode = DataGridViewTriState.True;

                textSurnameCol = new DataGridViewTextBoxColumn();
                textSurnameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                textSurnameCol.Name = "textSurnameCol";
                textSurnameCol.HeaderText = "textSurnameCol";
                textSurnameCol.DefaultCellStyle = textColCellStyle;
                textSurnameCol.ReadOnly = true;


                textRoleCol = new DataGridViewTextBoxColumn();
                textRoleCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                textRoleCol.Name = "textRoleCol";
                textRoleCol.HeaderText = "textRoleCol";
                textRoleCol.DefaultCellStyle = textColCellStyle;
                textRoleCol.ReadOnly = true;


                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AllowUserToResizeColumns = false;
                dataGridView.AllowUserToResizeRows = false;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView.CellMouseDown += Program.DataGridView_CellMouseDown;
                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView.ColumnHeadersVisible = false;
                dataGridView.BackgroundColor = Color.White;
                dataGridView.MultiSelect = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                dataGridView.Columns.AddRange(new DataGridViewColumn[]
                {
                    checkCol,textRoleCol, textSurnameCol
                });
                dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception InitializationDataGridViewChapterAuthors", ex.GetType().ToString());
            }
        }
    }
}
