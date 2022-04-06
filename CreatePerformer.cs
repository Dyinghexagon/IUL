﻿using System;
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
        public CreatePerformer()
        {
            try 
            {
                InitializeComponent();
                DbProviderFactories.InitializeComboBox(this.ComboBoxProjectNames, Tables.PROJECTS);
                DbProviderFactories.InitializeComboBox(this.ComboBoxRoles, Tables.ROLES);
                DbProviderFactories.InitializeComboBox(this.ComboBoxEmployees, Tables.EMPLOYEES);
                this._newPerformer = new Performer();

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

                this.Height -= DataGridViewSelectedChapter.Height;
                this.Height -= LableSelectedChapter.Height;


                ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxProjectNames.DrawItem += Main.ComboBox_DrawItem;
                ComboBoxProjectNames.MeasureItem += Main.ComboBox_MeasureItem;

                ComboBoxChapterNames.DrawMode = DrawMode.OwnerDrawVariable;
                ComboBoxChapterNames.DrawItem += Main.ComboBox_DrawItem;
                ComboBoxChapterNames.MeasureItem += Main.ComboBox_MeasureItem;
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
                String nameSelectedProject = this.ComboBoxProjectNames.Items[this.ComboBoxProjectNames.SelectedIndex].ToString();
                this._selectedProject = new Project(nameSelectedProject);
                Chapter.InitializeComboBoxChapters(this.ComboBoxChapterNames, this._selectedProject.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonAddNewPerformer_Click(object sender, EventArgs e)
        {
            try 
            {
                this._newPerformer.InsertNewPerformer();
                MessageBox.Show("Исполнитель добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ComboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                String selectedSurnameEmployee = this.ComboBoxEmployees.Items[this.ComboBoxEmployees.SelectedIndex].ToString();
                Employee selectedEmployee = new Employee(selectedSurnameEmployee);
                this._newPerformer.EmployeeId = selectedEmployee.Id;
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
                String selecteAbbreviatedNameRole = this.ComboBoxRoles.Items[this.ComboBoxRoles.SelectedIndex].ToString();
                Role selectedRole = new Role(selecteAbbreviatedNameRole);
                this._newPerformer.RoleId = selectedRole.Id;

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
                String selectedNameChapter = this.ComboBoxChapterNames.Items[this.ComboBoxChapterNames.SelectedIndex].ToString();
                Chapter chapter = new Chapter(this._selectedProject.Id, selectedNameChapter);
                this._newPerformer.ChapterId = chapter.Id;
                if (!CheckBoxIsAddMultiple.Checked) 
                {

                }
                DataGridViewSelectedChapter.Rows.Add(selectedNameChapter);
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

                this.Height += DataGridViewSelectedChapter.Height;
                this.Height += LableSelectedChapter.Height;
        }
    }
}
