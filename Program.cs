using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IUL
{
    static class Program
    {
        public static Form PreviosPage;
        private static DataGridViewCheckBoxColumn _checkCol;
        private static DataGridViewTextBoxColumn _textCol;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreateIUL());
        }
        public static void InitializeComboBox(ComboBox fillingComboBox, Tables table)
        {
            try
            {
                String query = String.Empty;
                String nameTable = String.Empty;
                switch (table)
                {
                    case Tables.ROLES:
                        {
                            query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[ROLES].[ROLE_ABBREVIATED_NAME] " +
                    "FROM [IUL].[dbo].[ROLES]; ";
                            nameTable = "ROLES";
                            break;
                        }
                    case Tables.PROJECTS:
                        {
                            query = "USE IUL;" +
                    "SELECT [IUL].[dbo].[PROJECTS].[PROJECT_NAME] " +
                    "FROM [IUL].[dbo].[PROJECTS]; ";
                            nameTable = "PROJECTS";

                            break;
                        }
                    case Tables.EMPLOYEES:
                        {
                            query = "SELECT  [IUL].[dbo].[EMPLOYEES].[EMPLOYEE_SURNAME]" +
                    "FROM [IUL].[dbo].[EMPLOYEES];";
                            nameTable = "EMPLOYEES";

                            break;
                        }
                    default:
                        {
                            throw new Exception("Error selected table!");
                        }
                }
                Int32 count = DbProviderFactories.GetCountСolumns(nameTable);
                String[] valuesFromSelectedTable = new string[count];
                using (SqlConnection connection = DbProviderFactories.GetDBConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            for (Int32 i = 0; reader.Read(); i++)
                            {
                                valuesFromSelectedTable[i] = reader.GetValue(0).ToString().Trim();
                            }
                        }
                    }
                }
                fillingComboBox.Items.AddRange(valuesFromSelectedTable);
            }
            catch (Exception ex)
            {
                throw new Exception("InitializeComboBox(DbProviderFactories) " + ex.Message, ex);
            }
        }
        /// <summary>
        /// Метод возвращает "офрмленный" DataGridView:
        /// Cтолбцы представляют собой CheckBox и TextBox
        /// </summary>
        /// <param name="dataGridView">Изменяемый DataGridView</param>
        public static void GetDataGridViewCheckBoxAndTextBox(ref DataGridView dataGridView)
        {
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

            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.CellMouseDown += DataGridView_CellMouseDown;
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
        }
        private static void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).Rows[e.RowIndex];
            if (row.Selected)
            {
                row.Cells[_checkCol.Index].Value = !(bool)row.Cells[_checkCol.Index].Value;
            }
        }
        public static void GetMainMenu(ref MenuStrip mainMenu) 
        {
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
            mainMenu.Items.Add(projectItem);

            ToolStripMenuItem chapterItem = new ToolStripMenuItem("Раздел");
            ToolStripMenuItem chapterItemCreate = new ToolStripMenuItem("Добавить раздел");
            chapterItemCreate.Click += CreateChapter_Click;
            ToolStripMenuItem chapterItemEdit = new ToolStripMenuItem("Изменить раздел");
            chapterItemEdit.Click += EditChapter_Click;
            chapterItem.DropDownItems.Add(chapterItemCreate);
            chapterItem.DropDownItems.Add(chapterItemEdit);
            mainMenu.Items.Add(chapterItem);

            ToolStripMenuItem employeeItem = new ToolStripMenuItem("Сотрудник");
            ToolStripMenuItem employeeItemCreate = new ToolStripMenuItem("Добавить исполнителя к разделу");
            employeeItemCreate.Click += CreateEmployee_Click;
            ToolStripMenuItem employeeItemEdit = new ToolStripMenuItem("Изменить данные о сотруднике");
            employeeItemEdit.Click += EditEmployee_Click;
            employeeItem.DropDownItems.Add(employeeItemCreate);
            employeeItem.DropDownItems.Add(employeeItemEdit);
            mainMenu.Items.Add(employeeItem);
        }
        private static void CreateProjectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFolderProject createFolderProject = new CreateFolderProject();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                createFolderProject.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private static void CreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                CreateProject createProject = new CreateProject();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                createProject.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private static void EditProject_Click(object sender, EventArgs e)
        {
            try
            {
                EditProject editProject = new EditProject();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                editProject.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private static void CreateChapter_Click(object sender, EventArgs e)
        {
            try
            {
                CreateChapter createChapter = new CreateChapter();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                createChapter.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private static void EditChapter_Click(object sender, EventArgs e)
        {
            try
            {
                EditChapter editChapter = new EditChapter();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                editChapter.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private static void CreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                CreatePerformer createPerformer = new CreatePerformer();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                createPerformer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private static void EditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EditEmployee editEmployee = new EditEmployee();
                Program.PreviosPage = Form.ActiveForm;
                Form.ActiveForm.Hide();
                editEmployee.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        public static void ComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var text = lbox.Items[e.Index].ToString();
            var width = lbox.ClientSize.Width;
            var size = e.Graphics.MeasureString(text, lbox.Font, width);
            e.ItemHeight = (int)size.Height;
        }
        public static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lbox = (ComboBox)sender;
            var color = SystemColors.Window;
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(lbox.Items[e.Index].ToString(), e.Font, SystemBrushes.WindowText, e.Bounds);
            }
        }
    }
}
