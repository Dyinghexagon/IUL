namespace IUL
{
    partial class EditProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxProjectNames = new System.Windows.Forms.ComboBox();
            this.LabelProjectNames = new System.Windows.Forms.Label();
            this.ButtonEdicting = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelGIP = new System.Windows.Forms.Label();
            this.TextBoxGIP = new System.Windows.Forms.TextBox();
            this.TextBoxNkontr = new System.Windows.Forms.TextBox();
            this.LabelNkontr = new System.Windows.Forms.Label();
            this.CheckBoxChangeGIP = new System.Windows.Forms.CheckBox();
            this.LabelEmployeesGIP = new System.Windows.Forms.Label();
            this.ComboBoxeEmployeesGIP = new System.Windows.Forms.ComboBox();
            this.LabelEmployeesNkontr = new System.Windows.Forms.Label();
            this.ComboBoxeEmployeesNkontr = new System.Windows.Forms.ComboBox();
            this.CheckBoxChangeNkontr = new System.Windows.Forms.CheckBox();
            this.TextBoxCustomer = new System.Windows.Forms.TextBox();
            this.LabelCustomer = new System.Windows.Forms.Label();
            this.CheckBoxChangeCustomer = new System.Windows.Forms.CheckBox();
            this.TextBoxNewCustomer = new System.Windows.Forms.TextBox();
            this.LabelNewCustomer = new System.Windows.Forms.Label();
            this.CheckedListBoxResearchs = new System.Windows.Forms.CheckedListBox();
            this.LabelResearch = new System.Windows.Forms.Label();
            this.СheckBoxChangeResearchs = new System.Windows.Forms.CheckBox();
            this.TextBoxNewProjectName = new System.Windows.Forms.TextBox();
            this.LabelNewProjectName = new System.Windows.Forms.Label();
            this.CheckBoxChangeProjectName = new System.Windows.Forms.CheckBox();
            this.TextBoxProjectName = new System.Windows.Forms.TextBox();
            this.LabelProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(12, 26);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(806, 23);
            this.ComboBoxProjectNames.TabIndex = 0;
            this.ComboBoxProjectNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProjectNames_SelectedIndexChanged);
            // 
            // LabelProjectNames
            // 
            this.LabelProjectNames.AutoSize = true;
            this.LabelProjectNames.Location = new System.Drawing.Point(12, 8);
            this.LabelProjectNames.Name = "LabelProjectNames";
            this.LabelProjectNames.Size = new System.Drawing.Size(115, 15);
            this.LabelProjectNames.TabIndex = 1;
            this.LabelProjectNames.Text = "Перечень проектов";
            // 
            // ButtonEdicting
            // 
            this.ButtonEdicting.Location = new System.Drawing.Point(717, 406);
            this.ButtonEdicting.Name = "ButtonEdicting";
            this.ButtonEdicting.Size = new System.Drawing.Size(101, 23);
            this.ButtonEdicting.TabIndex = 2;
            this.ButtonEdicting.Text = "Редактировать";
            this.ButtonEdicting.UseVisualStyleBackColor = true;
            this.ButtonEdicting.Click += new System.EventHandler(this.ButtonEdicting_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(418, 406);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelGIP
            // 
            this.LabelGIP.AutoSize = true;
            this.LabelGIP.Location = new System.Drawing.Point(12, 248);
            this.LabelGIP.Name = "LabelGIP";
            this.LabelGIP.Size = new System.Drawing.Size(158, 15);
            this.LabelGIP.TabIndex = 8;
            this.LabelGIP.Text = "Главный Инженер Проекта";
            // 
            // TextBoxGIP
            // 
            this.TextBoxGIP.Enabled = false;
            this.TextBoxGIP.Location = new System.Drawing.Point(12, 266);
            this.TextBoxGIP.Name = "TextBoxGIP";
            this.TextBoxGIP.Size = new System.Drawing.Size(400, 23);
            this.TextBoxGIP.TabIndex = 9;
            // 
            // TextBoxNkontr
            // 
            this.TextBoxNkontr.Enabled = false;
            this.TextBoxNkontr.Location = new System.Drawing.Point(11, 361);
            this.TextBoxNkontr.Name = "TextBoxNkontr";
            this.TextBoxNkontr.Size = new System.Drawing.Size(401, 23);
            this.TextBoxNkontr.TabIndex = 11;
            // 
            // LabelNkontr
            // 
            this.LabelNkontr.AutoSize = true;
            this.LabelNkontr.Location = new System.Drawing.Point(11, 343);
            this.LabelNkontr.Name = "LabelNkontr";
            this.LabelNkontr.Size = new System.Drawing.Size(105, 15);
            this.LabelNkontr.TabIndex = 10;
            this.LabelNkontr.Text = "Нормоконтролер";
            // 
            // CheckBoxChangeGIP
            // 
            this.CheckBoxChangeGIP.AutoSize = true;
            this.CheckBoxChangeGIP.Location = new System.Drawing.Point(327, 247);
            this.CheckBoxChangeGIP.Name = "CheckBoxChangeGIP";
            this.CheckBoxChangeGIP.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeGIP.TabIndex = 12;
            this.CheckBoxChangeGIP.Text = "Изменить?";
            this.CheckBoxChangeGIP.UseVisualStyleBackColor = true;
            this.CheckBoxChangeGIP.CheckedChanged += new System.EventHandler(this.CheckBoxChangeGIP_CheckedChanged);
            // 
            // LabelEmployeesGIP
            // 
            this.LabelEmployeesGIP.AutoSize = true;
            this.LabelEmployeesGIP.Location = new System.Drawing.Point(11, 292);
            this.LabelEmployeesGIP.Name = "LabelEmployeesGIP";
            this.LabelEmployeesGIP.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesGIP.TabIndex = 14;
            this.LabelEmployeesGIP.Text = "Перечень исполнителей";
            // 
            // ComboBoxeEmployeesGIP
            // 
            this.ComboBoxeEmployeesGIP.Enabled = false;
            this.ComboBoxeEmployeesGIP.FormattingEnabled = true;
            this.ComboBoxeEmployeesGIP.Location = new System.Drawing.Point(11, 310);
            this.ComboBoxeEmployeesGIP.Name = "ComboBoxeEmployeesGIP";
            this.ComboBoxeEmployeesGIP.Size = new System.Drawing.Size(401, 23);
            this.ComboBoxeEmployeesGIP.TabIndex = 13;
            // 
            // LabelEmployeesNkontr
            // 
            this.LabelEmployeesNkontr.AutoSize = true;
            this.LabelEmployeesNkontr.Location = new System.Drawing.Point(11, 387);
            this.LabelEmployeesNkontr.Name = "LabelEmployeesNkontr";
            this.LabelEmployeesNkontr.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesNkontr.TabIndex = 16;
            this.LabelEmployeesNkontr.Text = "Перечень исполнителей";
            // 
            // ComboBoxeEmployeesNkontr
            // 
            this.ComboBoxeEmployeesNkontr.Enabled = false;
            this.ComboBoxeEmployeesNkontr.FormattingEnabled = true;
            this.ComboBoxeEmployeesNkontr.Location = new System.Drawing.Point(12, 406);
            this.ComboBoxeEmployeesNkontr.Name = "ComboBoxeEmployeesNkontr";
            this.ComboBoxeEmployeesNkontr.Size = new System.Drawing.Size(400, 23);
            this.ComboBoxeEmployeesNkontr.TabIndex = 15;
            // 
            // CheckBoxChangeNkontr
            // 
            this.CheckBoxChangeNkontr.AutoSize = true;
            this.CheckBoxChangeNkontr.Location = new System.Drawing.Point(326, 339);
            this.CheckBoxChangeNkontr.Name = "CheckBoxChangeNkontr";
            this.CheckBoxChangeNkontr.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeNkontr.TabIndex = 17;
            this.CheckBoxChangeNkontr.Text = "Изменить?";
            this.CheckBoxChangeNkontr.UseVisualStyleBackColor = true;
            this.CheckBoxChangeNkontr.CheckedChanged += new System.EventHandler(this.CheckBoxChangeNkontr_CheckedChanged);
            // 
            // TextBoxCustomer
            // 
            this.TextBoxCustomer.Enabled = false;
            this.TextBoxCustomer.Location = new System.Drawing.Point(11, 73);
            this.TextBoxCustomer.Multiline = true;
            this.TextBoxCustomer.Name = "TextBoxCustomer";
            this.TextBoxCustomer.Size = new System.Drawing.Size(400, 75);
            this.TextBoxCustomer.TabIndex = 19;
            // 
            // LabelCustomer
            // 
            this.LabelCustomer.AutoSize = true;
            this.LabelCustomer.Location = new System.Drawing.Point(11, 51);
            this.LabelCustomer.Name = "LabelCustomer";
            this.LabelCustomer.Size = new System.Drawing.Size(147, 15);
            this.LabelCustomer.TabIndex = 18;
            this.LabelCustomer.Text = "Наименование заказчика";
            // 
            // CheckBoxChangeCustomer
            // 
            this.CheckBoxChangeCustomer.AutoSize = true;
            this.CheckBoxChangeCustomer.Location = new System.Drawing.Point(326, 51);
            this.CheckBoxChangeCustomer.Name = "CheckBoxChangeCustomer";
            this.CheckBoxChangeCustomer.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeCustomer.TabIndex = 20;
            this.CheckBoxChangeCustomer.Text = "Изменить?";
            this.CheckBoxChangeCustomer.UseVisualStyleBackColor = true;
            this.CheckBoxChangeCustomer.CheckedChanged += new System.EventHandler(this.CheckBoxChangeCustomer_CheckedChanged);
            // 
            // TextBoxNewCustomer
            // 
            this.TextBoxNewCustomer.Enabled = false;
            this.TextBoxNewCustomer.Location = new System.Drawing.Point(12, 166);
            this.TextBoxNewCustomer.Multiline = true;
            this.TextBoxNewCustomer.Name = "TextBoxNewCustomer";
            this.TextBoxNewCustomer.Size = new System.Drawing.Size(400, 75);
            this.TextBoxNewCustomer.TabIndex = 22;
            // 
            // LabelNewCustomer
            // 
            this.LabelNewCustomer.AutoSize = true;
            this.LabelNewCustomer.Location = new System.Drawing.Point(12, 151);
            this.LabelNewCustomer.Name = "LabelNewCustomer";
            this.LabelNewCustomer.Size = new System.Drawing.Size(183, 15);
            this.LabelNewCustomer.TabIndex = 21;
            this.LabelNewCustomer.Text = "Новое наименование заказчика";
            // 
            // CheckedListBoxResearchs
            // 
            this.CheckedListBoxResearchs.Enabled = false;
            this.CheckedListBoxResearchs.FormattingEnabled = true;
            this.CheckedListBoxResearchs.Items.AddRange(new object[] {
            "Инженерно-геодезические изыскания",
            "Инженерно-геологические изыскания",
            "Инженерно-экологические изыскания",
            "Инженерно-гидрометеорологические изыскания",
            "Инженерно-геотехнические изыскания",
            "Археологические изыскания",
            "Техническое обсследование здания"});
            this.CheckedListBoxResearchs.Location = new System.Drawing.Point(418, 266);
            this.CheckedListBoxResearchs.Name = "CheckedListBoxResearchs";
            this.CheckedListBoxResearchs.Size = new System.Drawing.Size(400, 130);
            this.CheckedListBoxResearchs.TabIndex = 24;
            // 
            // LabelResearch
            // 
            this.LabelResearch.AutoSize = true;
            this.LabelResearch.Location = new System.Drawing.Point(418, 248);
            this.LabelResearch.Name = "LabelResearch";
            this.LabelResearch.Size = new System.Drawing.Size(68, 15);
            this.LabelResearch.TabIndex = 23;
            this.LabelResearch.Text = "Изыскания";
            // 
            // СheckBoxChangeResearchs
            // 
            this.СheckBoxChangeResearchs.AutoSize = true;
            this.СheckBoxChangeResearchs.Location = new System.Drawing.Point(730, 247);
            this.СheckBoxChangeResearchs.Name = "СheckBoxChangeResearchs";
            this.СheckBoxChangeResearchs.Size = new System.Drawing.Size(85, 19);
            this.СheckBoxChangeResearchs.TabIndex = 25;
            this.СheckBoxChangeResearchs.Text = "Изменить?";
            this.СheckBoxChangeResearchs.UseVisualStyleBackColor = true;
            this.СheckBoxChangeResearchs.CheckedChanged += new System.EventHandler(this.СheckBoxChangeResearchs_CheckedChanged);
            // 
            // TextBoxNewProjectName
            // 
            this.TextBoxNewProjectName.Enabled = false;
            this.TextBoxNewProjectName.Location = new System.Drawing.Point(418, 166);
            this.TextBoxNewProjectName.Multiline = true;
            this.TextBoxNewProjectName.Name = "TextBoxNewProjectName";
            this.TextBoxNewProjectName.Size = new System.Drawing.Size(400, 75);
            this.TextBoxNewProjectName.TabIndex = 36;
            // 
            // LabelNewProjectName
            // 
            this.LabelNewProjectName.AutoSize = true;
            this.LabelNewProjectName.Location = new System.Drawing.Point(418, 148);
            this.LabelNewProjectName.Name = "LabelNewProjectName";
            this.LabelNewProjectName.Size = new System.Drawing.Size(183, 15);
            this.LabelNewProjectName.TabIndex = 35;
            this.LabelNewProjectName.Text = "Новое наименование заказчика";
            // 
            // CheckBoxChangeProjectName
            // 
            this.CheckBoxChangeProjectName.AutoSize = true;
            this.CheckBoxChangeProjectName.Location = new System.Drawing.Point(730, 51);
            this.CheckBoxChangeProjectName.Name = "CheckBoxChangeProjectName";
            this.CheckBoxChangeProjectName.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeProjectName.TabIndex = 34;
            this.CheckBoxChangeProjectName.Text = "Изменить?";
            this.CheckBoxChangeProjectName.UseVisualStyleBackColor = true;
            this.CheckBoxChangeProjectName.CheckedChanged += new System.EventHandler(this.CheckBoxChangeProjectName_CheckedChanged);
            // 
            // TextBoxProjectName
            // 
            this.TextBoxProjectName.Enabled = false;
            this.TextBoxProjectName.Location = new System.Drawing.Point(418, 73);
            this.TextBoxProjectName.Multiline = true;
            this.TextBoxProjectName.Name = "TextBoxProjectName";
            this.TextBoxProjectName.Size = new System.Drawing.Size(400, 75);
            this.TextBoxProjectName.TabIndex = 33;
            // 
            // LabelProjectName
            // 
            this.LabelProjectName.AutoSize = true;
            this.LabelProjectName.Location = new System.Drawing.Point(418, 55);
            this.LabelProjectName.Name = "LabelProjectName";
            this.LabelProjectName.Size = new System.Drawing.Size(137, 15);
            this.LabelProjectName.TabIndex = 32;
            this.LabelProjectName.Text = "Наименование проекта";
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 431);
            this.Controls.Add(this.TextBoxNewProjectName);
            this.Controls.Add(this.LabelNewProjectName);
            this.Controls.Add(this.CheckBoxChangeProjectName);
            this.Controls.Add(this.TextBoxProjectName);
            this.Controls.Add(this.LabelProjectName);
            this.Controls.Add(this.СheckBoxChangeResearchs);
            this.Controls.Add(this.CheckedListBoxResearchs);
            this.Controls.Add(this.LabelResearch);
            this.Controls.Add(this.TextBoxNewCustomer);
            this.Controls.Add(this.LabelNewCustomer);
            this.Controls.Add(this.CheckBoxChangeCustomer);
            this.Controls.Add(this.TextBoxCustomer);
            this.Controls.Add(this.LabelCustomer);
            this.Controls.Add(this.CheckBoxChangeNkontr);
            this.Controls.Add(this.LabelEmployeesNkontr);
            this.Controls.Add(this.ComboBoxeEmployeesNkontr);
            this.Controls.Add(this.LabelEmployeesGIP);
            this.Controls.Add(this.ComboBoxeEmployeesGIP);
            this.Controls.Add(this.CheckBoxChangeGIP);
            this.Controls.Add(this.TextBoxNkontr);
            this.Controls.Add(this.LabelNkontr);
            this.Controls.Add(this.TextBoxGIP);
            this.Controls.Add(this.LabelGIP);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonEdicting);
            this.Controls.Add(this.LabelProjectNames);
            this.Controls.Add(this.ComboBoxProjectNames);
            this.Name = "EditProject";
            this.Text = "Редактирование информации о проекте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxProjectNames;
        private System.Windows.Forms.Label LabelProjectNames;
        private System.Windows.Forms.Button ButtonEdicting;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelGIP;
        private System.Windows.Forms.TextBox TextBoxGIP;
        private System.Windows.Forms.TextBox TextBoxNkontr;
        private System.Windows.Forms.Label LabelNkontr;
        private System.Windows.Forms.CheckBox CheckBoxChangeGIP;
        private System.Windows.Forms.Label LabelEmployeesGIP;
        private System.Windows.Forms.ComboBox ComboBoxeEmployeesGIP;
        private System.Windows.Forms.Label LabelEmployeesNkontr;
        private System.Windows.Forms.ComboBox ComboBoxeEmployeesNkontr;
        private System.Windows.Forms.CheckBox CheckBoxChangeNkontr;
        private System.Windows.Forms.TextBox TextBoxCustomer;
        private System.Windows.Forms.Label LabelCustomer;
        private System.Windows.Forms.CheckBox CheckBoxChangeCustomer;
        private System.Windows.Forms.TextBox TextBoxNewCustomer;
        private System.Windows.Forms.Label LabelNewCustomer;
        private System.Windows.Forms.CheckedListBox CheckedListBoxResearchs;
        private System.Windows.Forms.Label LabelResearch;
        private System.Windows.Forms.CheckBox СheckBoxChangeResearchs;
        private System.Windows.Forms.TextBox TextBoxNewProjectName;
        private System.Windows.Forms.Label LabelNewProjectName;
        private System.Windows.Forms.CheckBox CheckBoxChangeProjectName;
        private System.Windows.Forms.TextBox TextBoxProjectName;
        private System.Windows.Forms.Label LabelProjectName;
    }
}