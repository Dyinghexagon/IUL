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
        public EditProject()
        {
            InitializeComponent();
            Program.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
            Program.InitializeComboBox(ComboBoxeEmployeesGIP, Tables.EMPLOYEES);
            Program.InitializeComboBox(ComboBoxeEmployeesNkontr, Tables.EMPLOYEES);
            Program.GetMainMenu(ref MenuStrip);

            ComboBoxProjectNames.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProjectNames.DrawItem += Program.ComboBox_DrawItem;
            ComboBoxProjectNames.MeasureItem += Program.ComboBox_MeasureItem;
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
                String projectName = ComboBoxProjectNames.Items[ComboBoxProjectNames.SelectedIndex].ToString();
                _selectedProject = new Project(projectName);
                TextBoxGIP.Text = _selectedProject.GIP.Surname;
                TextBoxNkontr.Text = _selectedProject.Nkontr.Surname;
                TextBoxCustomer.Text = _selectedProject.NameCustomer;
                TextBoxProjectName.Text = _selectedProject.Name;
                CheckedListBoxResearchs.SetItemChecked(0, _selectedProject.Surveys.IsGeodetiSurveys);
                CheckedListBoxResearchs.SetItemChecked(1, _selectedProject.Surveys.IsGeologicalSurveysSurveys);
                CheckedListBoxResearchs.SetItemChecked(2, _selectedProject.Surveys.IsEnvironmentalSurveys);
                CheckedListBoxResearchs.SetItemChecked(3, _selectedProject.Surveys.IsMeteorologicalSurveys);
                CheckedListBoxResearchs.SetItemChecked(4, _selectedProject.Surveys.IsGeotechnicalSurveys);
                CheckedListBoxResearchs.SetItemChecked(5, _selectedProject.Surveys.IsArchaeologicalSurveys);
                CheckedListBoxResearchs.SetItemChecked(6, _selectedProject.Surveys.IsInspectionOfTechnicalCondition);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void ButtonEdicting_Click(object sender, EventArgs e)
        {
            try 
            {
                if (CheckBoxChangeCustomer.Checked && TextBoxNewCustomer.Text.Length != 0)
                {
                    _selectedProject.NameCustomer = TextBoxNewCustomer.Text;
                }
                if (CheckBoxChangeProjectName.Checked && TextBoxNewProjectName.Text.Length != 0)
                {
                    _selectedProject.Name = TextBoxNewProjectName.Text;
                }
                if (CheckBoxChangeGIP.Checked)
                {
                    String selectedEmployee = ComboBoxeEmployeesGIP.Items[ComboBoxeEmployeesGIP.SelectedIndex].ToString();
                    Employee employee = new Employee(selectedEmployee);
                    _selectedProject.GIP = employee;
                }
                if (CheckBoxChangeNkontr.Checked)
                {
                    String selectedEmployee = ComboBoxeEmployeesNkontr.Items[ComboBoxeEmployeesNkontr.SelectedIndex].ToString();
                    Employee employee = new Employee(selectedEmployee);
                    _selectedProject.Nkontr = employee;
                }
                if (СheckBoxChangeResearchs.Checked)
                {
                    _selectedProject.Surveys.IsGeodetiSurveys = CheckedListBoxResearchs.GetItemChecked(0);
                    _selectedProject.Surveys.IsGeologicalSurveysSurveys = CheckedListBoxResearchs.GetItemChecked(1);
                    _selectedProject.Surveys.IsEnvironmentalSurveys = CheckedListBoxResearchs.GetItemChecked(2);
                    _selectedProject.Surveys.IsMeteorologicalSurveys = CheckedListBoxResearchs.GetItemChecked(3);
                    _selectedProject.Surveys.IsGeotechnicalSurveys = CheckedListBoxResearchs.GetItemChecked(4);
                    _selectedProject.Surveys.IsArchaeologicalSurveys = CheckedListBoxResearchs.GetItemChecked(5);
                    _selectedProject.Surveys.IsInspectionOfTechnicalCondition = CheckedListBoxResearchs.GetItemChecked(6);
                }
                _selectedProject.Update();
                MessageBox.Show("Изменения внесенны!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CheckBoxChangeGIP_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxeEmployeesGIP.Enabled = !ComboBoxeEmployeesGIP.Enabled;
        }
        private void CheckBoxChangeNkontr_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxeEmployeesNkontr.Enabled = !ComboBoxeEmployeesNkontr.Enabled;

        }
        private void CheckBoxChangeCustomer_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxCustomer.Enabled = !TextBoxCustomer.Enabled;
            TextBoxNewCustomer.Enabled = !TextBoxNewCustomer.Enabled;
        }
        private void CheckBoxChangeProjectName_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxProjectName.Enabled = !TextBoxProjectName.Enabled;
            TextBoxNewProjectName.Enabled = !TextBoxNewProjectName.Enabled;
        }
        private void СheckBoxChangeResearchs_CheckedChanged(object sender, EventArgs e)
        {
            CheckedListBoxResearchs.Enabled = !CheckedListBoxResearchs.Enabled;
        }
    }
}
