﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUL
{
    public partial class EditEmployee : Form
    {
        Employee _selectedEmployee;
        public EditEmployee()
        {
            InitializeComponent();
            DbProviderFactories.InitializeComboBox(ComboBoxEmployees, Tables.EMPLOYEES);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            String surnameSelectedEmployee = ComboBoxEmployees.Items[ComboBoxEmployees.SelectedIndex].ToString();
            _selectedEmployee = new Employee(surnameSelectedEmployee);
            TextBoxSelectedEmployeeName.Text = _selectedEmployee.Name;
            TextBoxSelectedEmployeeSurname.Text = _selectedEmployee.Surname;
            TextBoxSelectedEmployeePatronymic.Text = _selectedEmployee.Patromic;
            Bitmap signSelectedEmployee = new Bitmap(_selectedEmployee.Sign, 
                new Size(PictureBoxSelectedEmployeeSign.Size.Width, PictureBoxSelectedEmployeeSign.Size.Height));
            PictureBoxSelectedEmployeeSign.Image = signSelectedEmployee;
        }

        private void CheckBoxEmployeeSurname_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxEditEmployeeSurname.Enabled = !TextBoxEditEmployeeSurname.Enabled;
        }

        private void CheckBoxEmployeeName_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxEditEmployeeName.Enabled = !TextBoxEditEmployeeName.Enabled;
        }

        private void CheckBoxEditEmployeePatronymic_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxEditEmployeePatronymic.Enabled = !TextBoxEditEmployeePatronymic.Enabled;
        }

        private void CheckBoxEditSign_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEditEmployeeSign.Enabled = !ButtonEditEmployeeSign.Enabled;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if(CheckBoxEmployeeSurname.Checked && TextBoxEditEmployeeSurname.TextLength > 0) 
            {
                _selectedEmployee.Surname = TextBoxEditEmployeeSurname.Text;
            }
            if(CheckBoxEmployeeName.Checked && TextBoxEditEmployeeName.TextLength > 0) 
            {
                _selectedEmployee.Name = TextBoxEditEmployeeName.Text;
            }
            if (CheckBoxEmployeePatronymic.Checked && TextBoxEditEmployeePatronymic.TextLength > 0)
            {
                _selectedEmployee.Patromic = TextBoxEditEmployeePatronymic.Text;
            }
            _selectedEmployee.UpdateEmployee();
            CheckBoxEmployeeSurname.Checked = false;
            CheckBoxEmployeeName.Checked = false;
            CheckBoxEmployeePatronymic.Checked = false;
            TextBoxEditEmployeeSurname.Text = String.Empty;
            TextBoxEditEmployeeName.Text = String.Empty;
            TextBoxEditEmployeePatronymic.Text = String.Empty;
            ComboBoxEmployees.Items.Clear();
            DbProviderFactories.InitializeComboBox(ComboBoxEmployees, Tables.EMPLOYEES);

        }
        private void ButtonEditEmployeeSign_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                String pathToSign = openFileDialog1.FileName;
                Image newSign = Image.FromFile(pathToSign);
                _selectedEmployee.Sign = newSign;
            }
        }
    }
}
