using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace IUL
{
    public partial class CreateProject : Form
    {
        private Project _newProject;
        public CreateProject()
        {
            InitializeComponent();
            Employee.InitializeComboBoxEmployees(this.ComboBoxChoosingGIP);
            Employee.InitializeComboBoxEmployees(this.ComboBoxChoosingNkontr);
            this._newProject = new Project();

        }

        private void ButtonChoosingMainFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this._newProject.Path = folderBrowserDialog1.SelectedPath;
        }

        private void ButtonAddProject_Click(object sender, EventArgs e)
        {
            try 
            {
                if (CheckingFieldsAreFull())
                {
                    this._newProject.IsGeodetiSurveys = this.CheckedListBoxResearchs.GetItemChecked(0);
                    this._newProject.IsGeologicalSurveysSurveys = this.CheckedListBoxResearchs.GetItemChecked(1);
                    this._newProject.IsEnvironmentalSurveys = this.CheckedListBoxResearchs.GetItemChecked(2);
                    this._newProject.IsMeteorologicalSurveys = this.CheckedListBoxResearchs.GetItemChecked(3);
                    this._newProject.IsGeotechnicalSurveys = this.CheckedListBoxResearchs.GetItemChecked(4);
                    this._newProject.IsArchaeologicalSurveys = this.CheckedListBoxResearchs.GetItemChecked(5);
                    this._newProject.IsInspectionOfTechnicalCondition = this.CheckedListBoxResearchs.GetItemChecked(6);
                    this._newProject.Id = TextBoxCodeProject.Text;
                    this._newProject.Name = TextBoxNameProject.Text;
                    this._newProject.NameCustomer = TextBoxNameCustomer.Text;
                    this._newProject.InsertNewProject();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            finally
            {
                MessageBox.Show("Новый проект добавлен!");
            }

        }
        private bool CheckingFieldsAreFull()
        {
            if (TextBoxCodeProject.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести шифр нового проекта!");
                return false;
            }

            if (TextBoxNameCustomer.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести наименование заказчика!");
                return false;
            }

            if (TextBoxNameProject.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести наименование проекта!");
                return false;
            }

            if (RadioButtonCapital.Checked == false && RadioButtonLinear.Checked == false)
            {
                MessageBox.Show("Необходимо выбрать тип проекта!");
                return false;
            }

            if (String.IsNullOrEmpty(this._newProject.Path))
            {
                MessageBox.Show("Необходимо выбрать папку проекта!");
                return false;
            }
            if (this._newProject.IdGIP == 0)
            {
                MessageBox.Show("Необходимо выбрать Главного Инженера Проекта проекта!");
                return false;
            }
            if (this._newProject.IdNkont == 0)
            {
                MessageBox.Show("Необходимо выбрать Нормоконтролера проекта!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ComboBoxChoosingGIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._newProject.IdGIP = ComboBoxChoosingGIP.SelectedIndex;
        }

        private void ComboBoxChoosingNkontr_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._newProject.IdNkont = ComboBoxChoosingNkontr.SelectedIndex;
        }

        private void RadioButtonLinear_CheckedChanged(object sender, EventArgs e)
        {
            this._newProject.CapitalOrLinear = false;
        }

        private void RadioButtonCapital_CheckedChanged(object sender, EventArgs e)
        {
            this._newProject.CapitalOrLinear = true;
        }

        private void ButtonCreateNewChapter_Click(object sender, EventArgs e)
        {
            CreateChapter createChapter = new CreateChapter();
            createChapter.Show();
            this.Hide();
            Program.PreviosPage = this;

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.PreviosPage.Show();
            this.Hide();
            Program.PreviosPage = this;
        }
    }
}
