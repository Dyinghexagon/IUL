using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class CreateEmployee : Form
    {
        Employee _newEmployee;
        public CreateEmployee()
        {
            InitializeComponent();
            _newEmployee = new Employee();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            try 
            {
                _newEmployee.Surname = TextBoxSurname.Text;
                _newEmployee.Name = TextBoxName.Text;
                _newEmployee.Patromic = TextBoxPathomic.Text;
                _newEmployee.Insert();
                MessageBox.Show("Данные о новом сотруднике добавлены!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            _newEmployee.Sign = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
