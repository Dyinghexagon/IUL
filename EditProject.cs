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
            DbProviderFactories.InitializeComboBox(ComboBoxProjectNames, Tables.PROJECTS);
            DbProviderFactories.InitializeComboBox(ComboBoxeEmployeesGIP, Tables.EMPLOYEES);
            DbProviderFactories.InitializeComboBox(ComboBoxeEmployeesNkontr, Tables.EMPLOYEES);

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
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void ButtonEdicting_Click(object sender, EventArgs e)
        {
            if(CheckBoxChangeCustomer.Checked && TextBoxNewCustomer.Text.Length != 0) 
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
            {            }
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
    }
}
