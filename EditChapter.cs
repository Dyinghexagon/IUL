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
            Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewAuthors);
            DataGridViewComboBoxColumn comboBoxCol;
            comboBoxCol = new DataGridViewComboBoxColumn();
            comboBoxCol.Name = "comboBoxCol";
            comboBoxCol.HeaderText = "comboBoxCol";
            List<String> roles = Role.Roles().ToList();
            comboBoxCol.DataSource = roles;
            DataGridViewAuthors.Columns.Add(comboBoxCol);
            Program.GetDataGridViewCheckBoxAndTextBox(ref DataGridViewChapterAuthors);
            DataGridViewTextBoxColumn textRoleCol;
            textRoleCol = new DataGridViewTextBoxColumn();
            textRoleCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            textRoleCol.Name = "textRoleCol";
            textRoleCol.HeaderText = "textRoleCol";
            var textColCellStyle = new DataGridViewCellStyle();
            textColCellStyle.WrapMode = DataGridViewTriState.True;
            textRoleCol.DefaultCellStyle = textColCellStyle;
            textRoleCol.ReadOnly = true;
            DataGridViewChapterAuthors.Columns.Add(textRoleCol);
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
                        Role role = new Role(DataGridViewChapterAuthors[2, i].Value.ToString());
                        Employee employee = new Employee(DataGridViewChapterAuthors[1, i].Value.ToString());
                        authors.Add(new KeyValuePair<Role, Employee>(role, employee));
                    }
                }
                for (Int32 i = 0; i < DataGridViewAuthors.RowCount; i++)
                {
                    if (Convert.ToBoolean(DataGridViewAuthors[0, i].Value))
                    {
                        Role role = new Role(DataGridViewAuthors[2, i].Value.ToString());
                        Employee employee = new Employee(DataGridViewAuthors[1, i].Value.ToString());
                        authors.Add(new KeyValuePair<Role, Employee>(role, employee));
                    }
                }
                _selectedChapter.Update();
                Performer.Update(_selectedChapter.Id, authors);
                MessageBox.Show("Изменения внесены");
                ComboBoxProjectNames.Items.Clear();
                ComboBoxChapterNames.Items.Clear();
                Program.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
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
                ComboBoxChapterNames.Items.Clear();
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
                DataGridViewChapterAuthors.Rows.Clear();
                DataGridViewChapterAuthors.Refresh();
                String nameChapter = ComboBoxChapterNames.Items[ComboBoxChapterNames.SelectedIndex].ToString();
                _selectedChapter = new Chapter(_selectedProject.Id, nameChapter);
                foreach (var autor in _selectedChapter.Authors())
                {
                    Employee employee = new Employee(autor.EmployeeId);
                    Role role = new Role(autor.RoleId);
                    DataGridViewChapterAuthors.Rows.Add(true, employee.Surname, role.AbbreviatedName);
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
    }
}
