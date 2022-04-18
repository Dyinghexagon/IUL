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
                DbProviderFactories.InitializeComboBox(ComboBoxChoosingGIP, Tables.EMPLOYEES);
                DbProviderFactories.InitializeComboBox(ComboBoxChoosingNkontr, Tables.EMPLOYEES);
                _newProject = new Project();
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
                _newProject.Path = folderBrowserDialog1.SelectedPath;
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
                    _newProject.Surveys.IsGeodetiSurveys = CheckedListBoxResearchs.GetItemChecked(0);
                    _newProject.Surveys.IsGeologicalSurveysSurveys = CheckedListBoxResearchs.GetItemChecked(1);
                    _newProject.Surveys.IsEnvironmentalSurveys = CheckedListBoxResearchs.GetItemChecked(2);
                    _newProject.Surveys.IsMeteorologicalSurveys = CheckedListBoxResearchs.GetItemChecked(3);
                    _newProject.Surveys.IsGeotechnicalSurveys = CheckedListBoxResearchs.GetItemChecked(4);
                    _newProject.Surveys.IsArchaeologicalSurveys = CheckedListBoxResearchs.GetItemChecked(5);
                    _newProject.Surveys.IsInspectionOfTechnicalCondition = CheckedListBoxResearchs.GetItemChecked(6);
                    _newProject.Id = TextBoxProjectId.Text;
                    _newProject.Name = TextBoxProjectName.Text;
                    _newProject.NameCustomer = TextBoxNameCustomer.Text;
                    _newProject.InsertNewProject();
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
                if (TextBoxProjectId.Text.Length == 0)
                {
                    MessageBox.Show("Необходимо ввести шифр нового проекта!");
                    return false;
                }

                if (TextBoxNameCustomer.Text.Length == 0)
                {
                    MessageBox.Show("Необходимо ввести наименование заказчика!");
                    return false;
                }

                if (TextBoxProjectName.Text.Length == 0)
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
                String surnameGIP = ComboBoxChoosingGIP.Items[ComboBoxChoosingGIP.SelectedIndex].ToString();
                _GIP = new Employee(surnameGIP);
                _newProject.GIP = _GIP;
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
                String surnameNkont = ComboBoxChoosingNkontr.Items[ComboBoxChoosingGIP.SelectedIndex].ToString();
                _Nkontr = new Employee(surnameNkont);
                _newProject.Nkontr = _Nkontr;
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
                _newProject.CapitalOrLinear = false;
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
                _newProject.CapitalOrLinear = true;
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
