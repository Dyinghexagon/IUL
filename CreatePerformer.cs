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
        private Chapter _selectedChapter;
        public CreatePerformer()
        {
            InitializeComponent();
            Project.InitializeComboBoxProjects(this.ComboBoxNameProjects);
            Employee.InitializeComboBoxEmployees(this.ComboBoxEmployees);
            Role.InitializeComboBoxRoles(this.ComboBoxRoles);
            this._newPerformer = new Performer();
        }

        private void ComboBoxNameProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameSelectedProject = this.ComboBoxNameProjects.Items[this.ComboBoxNameProjects.SelectedIndex].ToString();
            this._selectedProject = new Project(nameSelectedProject);
            this._selectedChapter = new Chapter();
            this._selectedChapter.ProjectId = this._selectedProject.Id;
            this.ComboBoxChapters.Items.AddRange(this._selectedChapter.GetChaptersArray());
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
                string selectedSurnameEmployee = this.ComboBoxEmployees.Items[this.ComboBoxEmployees.SelectedIndex].ToString();
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
                string selecteAbbreviatedNameRole = this.ComboBoxRoles.Items[this.ComboBoxRoles.SelectedIndex].ToString();
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
                string selectedNameChapter = this.ComboBoxChapters.Items[this.ComboBoxChapters.SelectedIndex].ToString();
                this._selectedChapter.ChapterName = selectedNameChapter;
                this._selectedChapter.InitializeChapter();
                this._newPerformer.ChapterId = this._selectedChapter.ChapterId;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.PreviosPage.Show();
            this.Hide();
            Program.PreviosPage = this;
        }
    }
}
