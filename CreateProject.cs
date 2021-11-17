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
        private Employee _GIP;
        private Employee _Nkontr;
        public CreateProject()
        {
            try 
            {
                InitializeComponent();
                Employee.InitializeComboBoxEmployees(this.ComboBoxChoosingGIP);
                Employee.InitializeComboBoxEmployees(this.ComboBoxChoosingNkontr);
                this._newProject = new Project();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonChoosingMainFolder_Click(object sender, EventArgs e)
        {
            try 
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                this._newProject.Path = folderBrowserDialog1.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
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
					MessageBox.Show("Новый проект добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }

        }
        private bool CheckingFieldsAreFull()
        {
            try 
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
                if (this._GIP == null)
                {
                    MessageBox.Show("Необходимо выбрать Главного Инженера Проекта проекта!");
                    return false;
                }
                if (this._Nkontr == null)
                {
                    MessageBox.Show("Необходимо выбрать Нормоконтролера проекта!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void ComboBoxChoosingGIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                string surnameGIP = this.ComboBoxChoosingGIP.Items[ComboBoxChoosingGIP.SelectedIndex].ToString();
                this._GIP = new Employee(surnameGIP);
                this._newProject.IdGIP = this._GIP.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ComboBoxChoosingNkontr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                string surnameNkont = this.ComboBoxChoosingNkontr.Items[ComboBoxChoosingGIP.SelectedIndex].ToString();
                this._Nkontr = new Employee(surnameNkont);
                this._newProject.IdNkont = this._Nkontr.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void RadioButtonLinear_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
                this._newProject.CapitalOrLinear = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void RadioButtonCapital_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
                this._newProject.CapitalOrLinear = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void ButtonCreateNewChapter_Click(object sender, EventArgs e)
        {
            try 
            {
                CreateChapter createChapter = new CreateChapter();
                createChapter.Show();
                this.Hide();
                Program.PreviosPage = this;
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
    }
}
