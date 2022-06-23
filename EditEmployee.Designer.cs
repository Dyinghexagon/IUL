namespace IUL
{
    partial class EditEmployee
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
            this.ComboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.LabelEmployees = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxSelectedEmployeeSurname = new System.Windows.Forms.TextBox();
            this.LabelSelectedEmployeeSurname = new System.Windows.Forms.Label();
            this.CheckBoxEmployeeSurname = new System.Windows.Forms.CheckBox();
            this.TextBoxEditEmployeeSurname = new System.Windows.Forms.TextBox();
            this.TextBoxEditEmployeeName = new System.Windows.Forms.TextBox();
            this.CheckBoxEmployeeName = new System.Windows.Forms.CheckBox();
            this.LabelSelectedEmployeeName = new System.Windows.Forms.Label();
            this.TextBoxSelectedEmployeeName = new System.Windows.Forms.TextBox();
            this.TextBoxEditEmployeePatronymic = new System.Windows.Forms.TextBox();
            this.CheckBoxEmployeePatronymic = new System.Windows.Forms.CheckBox();
            this.LabelSelectedEmployeePatronymic = new System.Windows.Forms.Label();
            this.TextBoxSelectedEmployeePatronymic = new System.Windows.Forms.TextBox();
            this.PictureBoxSelectedEmployeeSign = new System.Windows.Forms.PictureBox();
            this.LabelSelectedEmployeeSign = new System.Windows.Forms.Label();
            this.CheckBoxEditSign = new System.Windows.Forms.CheckBox();
            this.ButtonEditEmployeeSign = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectedEmployeeSign)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxEmployees
            // 
            this.ComboBoxEmployees.FormattingEnabled = true;
            this.ComboBoxEmployees.Location = new System.Drawing.Point(10, 44);
            this.ComboBoxEmployees.Name = "ComboBoxEmployees";
            this.ComboBoxEmployees.Size = new System.Drawing.Size(406, 23);
            this.ComboBoxEmployees.TabIndex = 0;
            this.ComboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmployees_SelectedIndexChanged);
            // 
            // LabelEmployees
            // 
            this.LabelEmployees.AutoSize = true;
            this.LabelEmployees.Location = new System.Drawing.Point(12, 24);
            this.LabelEmployees.Name = "LabelEmployees";
            this.LabelEmployees.Size = new System.Drawing.Size(121, 15);
            this.LabelEmployees.TabIndex = 1;
            this.LabelEmployees.Text = "Список сотрудников";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(14, 298);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(318, 298);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(98, 23);
            this.ButtonEdit.TabIndex = 3;
            this.ButtonEdit.Text = "Редактировать";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxSelectedEmployeeSurname
            // 
            this.TextBoxSelectedEmployeeSurname.Enabled = false;
            this.TextBoxSelectedEmployeeSurname.Location = new System.Drawing.Point(10, 89);
            this.TextBoxSelectedEmployeeSurname.Name = "TextBoxSelectedEmployeeSurname";
            this.TextBoxSelectedEmployeeSurname.Size = new System.Drawing.Size(200, 23);
            this.TextBoxSelectedEmployeeSurname.TabIndex = 4;
            // 
            // LabelSelectedEmployeeSurname
            // 
            this.LabelSelectedEmployeeSurname.AutoSize = true;
            this.LabelSelectedEmployeeSurname.Location = new System.Drawing.Point(10, 71);
            this.LabelSelectedEmployeeSurname.Name = "LabelSelectedEmployeeSurname";
            this.LabelSelectedEmployeeSurname.Size = new System.Drawing.Size(195, 15);
            this.LabelSelectedEmployeeSurname.TabIndex = 5;
            this.LabelSelectedEmployeeSurname.Text = "Фамилия выбранного сотрудника";
            // 
            // CheckBoxEmployeeSurname
            // 
            this.CheckBoxEmployeeSurname.AutoSize = true;
            this.CheckBoxEmployeeSurname.Location = new System.Drawing.Point(331, 67);
            this.CheckBoxEmployeeSurname.Name = "CheckBoxEmployeeSurname";
            this.CheckBoxEmployeeSurname.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEmployeeSurname.TabIndex = 6;
            this.CheckBoxEmployeeSurname.Text = "Изменить?";
            this.CheckBoxEmployeeSurname.UseVisualStyleBackColor = true;
            this.CheckBoxEmployeeSurname.CheckedChanged += new System.EventHandler(this.CheckBoxEmployeeSurname_CheckedChanged);
            // 
            // TextBoxEditEmployeeSurname
            // 
            this.TextBoxEditEmployeeSurname.Enabled = false;
            this.TextBoxEditEmployeeSurname.Location = new System.Drawing.Point(216, 89);
            this.TextBoxEditEmployeeSurname.Name = "TextBoxEditEmployeeSurname";
            this.TextBoxEditEmployeeSurname.Size = new System.Drawing.Size(200, 23);
            this.TextBoxEditEmployeeSurname.TabIndex = 7;
            // 
            // TextBoxEditEmployeeName
            // 
            this.TextBoxEditEmployeeName.Enabled = false;
            this.TextBoxEditEmployeeName.Location = new System.Drawing.Point(216, 135);
            this.TextBoxEditEmployeeName.Name = "TextBoxEditEmployeeName";
            this.TextBoxEditEmployeeName.Size = new System.Drawing.Size(200, 23);
            this.TextBoxEditEmployeeName.TabIndex = 11;
            // 
            // CheckBoxEmployeeName
            // 
            this.CheckBoxEmployeeName.AutoSize = true;
            this.CheckBoxEmployeeName.Location = new System.Drawing.Point(331, 113);
            this.CheckBoxEmployeeName.Name = "CheckBoxEmployeeName";
            this.CheckBoxEmployeeName.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEmployeeName.TabIndex = 10;
            this.CheckBoxEmployeeName.Text = "Изменить?";
            this.CheckBoxEmployeeName.UseVisualStyleBackColor = true;
            this.CheckBoxEmployeeName.CheckedChanged += new System.EventHandler(this.CheckBoxEmployeeName_CheckedChanged);
            // 
            // LabelSelectedEmployeeName
            // 
            this.LabelSelectedEmployeeName.AutoSize = true;
            this.LabelSelectedEmployeeName.Location = new System.Drawing.Point(12, 117);
            this.LabelSelectedEmployeeName.Name = "LabelSelectedEmployeeName";
            this.LabelSelectedEmployeeName.Size = new System.Drawing.Size(168, 15);
            this.LabelSelectedEmployeeName.TabIndex = 9;
            this.LabelSelectedEmployeeName.Text = "Имя выбранного сотрудника";
            // 
            // TextBoxSelectedEmployeeName
            // 
            this.TextBoxSelectedEmployeeName.Enabled = false;
            this.TextBoxSelectedEmployeeName.Location = new System.Drawing.Point(12, 135);
            this.TextBoxSelectedEmployeeName.Name = "TextBoxSelectedEmployeeName";
            this.TextBoxSelectedEmployeeName.Size = new System.Drawing.Size(200, 23);
            this.TextBoxSelectedEmployeeName.TabIndex = 8;
            // 
            // TextBoxEditEmployeePatronymic
            // 
            this.TextBoxEditEmployeePatronymic.Enabled = false;
            this.TextBoxEditEmployeePatronymic.Location = new System.Drawing.Point(216, 184);
            this.TextBoxEditEmployeePatronymic.Name = "TextBoxEditEmployeePatronymic";
            this.TextBoxEditEmployeePatronymic.Size = new System.Drawing.Size(200, 23);
            this.TextBoxEditEmployeePatronymic.TabIndex = 15;
            // 
            // CheckBoxEmployeePatronymic
            // 
            this.CheckBoxEmployeePatronymic.AutoSize = true;
            this.CheckBoxEmployeePatronymic.Location = new System.Drawing.Point(331, 162);
            this.CheckBoxEmployeePatronymic.Name = "CheckBoxEmployeePatronymic";
            this.CheckBoxEmployeePatronymic.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEmployeePatronymic.TabIndex = 14;
            this.CheckBoxEmployeePatronymic.Text = "Изменить?";
            this.CheckBoxEmployeePatronymic.UseVisualStyleBackColor = true;
            this.CheckBoxEmployeePatronymic.CheckedChanged += new System.EventHandler(this.CheckBoxEditEmployeePatronymic_CheckedChanged);
            // 
            // LabelSelectedEmployeePatronymic
            // 
            this.LabelSelectedEmployeePatronymic.AutoSize = true;
            this.LabelSelectedEmployeePatronymic.Location = new System.Drawing.Point(14, 166);
            this.LabelSelectedEmployeePatronymic.Name = "LabelSelectedEmployeePatronymic";
            this.LabelSelectedEmployeePatronymic.Size = new System.Drawing.Size(195, 15);
            this.LabelSelectedEmployeePatronymic.TabIndex = 13;
            this.LabelSelectedEmployeePatronymic.Text = "Отчество выбранного сотрудника";
            // 
            // TextBoxSelectedEmployeePatronymic
            // 
            this.TextBoxSelectedEmployeePatronymic.Enabled = false;
            this.TextBoxSelectedEmployeePatronymic.Location = new System.Drawing.Point(14, 184);
            this.TextBoxSelectedEmployeePatronymic.Name = "TextBoxSelectedEmployeePatronymic";
            this.TextBoxSelectedEmployeePatronymic.Size = new System.Drawing.Size(200, 23);
            this.TextBoxSelectedEmployeePatronymic.TabIndex = 12;
            // 
            // PictureBoxSelectedEmployeeSign
            // 
            this.PictureBoxSelectedEmployeeSign.Location = new System.Drawing.Point(14, 227);
            this.PictureBoxSelectedEmployeeSign.Name = "PictureBoxSelectedEmployeeSign";
            this.PictureBoxSelectedEmployeeSign.Size = new System.Drawing.Size(294, 65);
            this.PictureBoxSelectedEmployeeSign.TabIndex = 16;
            this.PictureBoxSelectedEmployeeSign.TabStop = false;
            // 
            // LabelSelectedEmployeeSign
            // 
            this.LabelSelectedEmployeeSign.AutoSize = true;
            this.LabelSelectedEmployeeSign.Location = new System.Drawing.Point(14, 209);
            this.LabelSelectedEmployeeSign.Name = "LabelSelectedEmployeeSign";
            this.LabelSelectedEmployeeSign.Size = new System.Drawing.Size(192, 15);
            this.LabelSelectedEmployeeSign.TabIndex = 17;
            this.LabelSelectedEmployeeSign.Text = "Подпись выбранного сотрудника";
            // 
            // CheckBoxEditSign
            // 
            this.CheckBoxEditSign.AutoSize = true;
            this.CheckBoxEditSign.Location = new System.Drawing.Point(331, 208);
            this.CheckBoxEditSign.Name = "CheckBoxEditSign";
            this.CheckBoxEditSign.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEditSign.TabIndex = 18;
            this.CheckBoxEditSign.Text = "Изменить?";
            this.CheckBoxEditSign.UseVisualStyleBackColor = true;
            this.CheckBoxEditSign.CheckedChanged += new System.EventHandler(this.CheckBoxEditSign_CheckedChanged);
            // 
            // ButtonEditEmployeeSign
            // 
            this.ButtonEditEmployeeSign.Enabled = false;
            this.ButtonEditEmployeeSign.Location = new System.Drawing.Point(314, 227);
            this.ButtonEditEmployeeSign.Name = "ButtonEditEmployeeSign";
            this.ButtonEditEmployeeSign.Size = new System.Drawing.Size(102, 65);
            this.ButtonEditEmployeeSign.TabIndex = 19;
            this.ButtonEditEmployeeSign.Text = "Выбрать новую подпись";
            this.ButtonEditEmployeeSign.UseVisualStyleBackColor = true;
            this.ButtonEditEmployeeSign.Click += new System.EventHandler(this.ButtonEditEmployeeSign_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(419, 24);
            this.MenuStrip.TabIndex = 33;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 333);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ButtonEditEmployeeSign);
            this.Controls.Add(this.CheckBoxEditSign);
            this.Controls.Add(this.LabelSelectedEmployeeSign);
            this.Controls.Add(this.PictureBoxSelectedEmployeeSign);
            this.Controls.Add(this.TextBoxEditEmployeePatronymic);
            this.Controls.Add(this.CheckBoxEmployeePatronymic);
            this.Controls.Add(this.LabelSelectedEmployeePatronymic);
            this.Controls.Add(this.TextBoxSelectedEmployeePatronymic);
            this.Controls.Add(this.TextBoxEditEmployeeName);
            this.Controls.Add(this.CheckBoxEmployeeName);
            this.Controls.Add(this.LabelSelectedEmployeeName);
            this.Controls.Add(this.TextBoxSelectedEmployeeName);
            this.Controls.Add(this.TextBoxEditEmployeeSurname);
            this.Controls.Add(this.CheckBoxEmployeeSurname);
            this.Controls.Add(this.LabelSelectedEmployeeSurname);
            this.Controls.Add(this.TextBoxSelectedEmployeeSurname);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelEmployees);
            this.Controls.Add(this.ComboBoxEmployees);
            this.Name = "EditEmployee";
            this.Text = "Изменение данных о сотрудниках";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectedEmployeeSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxEmployees;
        private System.Windows.Forms.Label LabelEmployees;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxSelectedEmployeeSurname;
        private System.Windows.Forms.Label LabelSelectedEmployeeSurname;
        private System.Windows.Forms.CheckBox CheckBoxEmployeeSurname;
        private System.Windows.Forms.TextBox TextBoxEditEmployeeSurname;
        private System.Windows.Forms.TextBox TextBoxEditEmployeeName;
        private System.Windows.Forms.CheckBox CheckBoxEmployeeName;
        private System.Windows.Forms.Label LabelSelectedEmployeeName;
        private System.Windows.Forms.TextBox TextBoxSelectedEmployeeName;
        private System.Windows.Forms.TextBox TextBoxEditEmployeePatronymic;
        private System.Windows.Forms.CheckBox CheckBoxEmployeePatronymic;
        private System.Windows.Forms.Label LabelSelectedEmployeePatronymic;
        private System.Windows.Forms.TextBox TextBoxSelectedEmployeePatronymic;
        private System.Windows.Forms.PictureBox PictureBoxSelectedEmployeeSign;
        private System.Windows.Forms.Label LabelSelectedEmployeeSign;
        private System.Windows.Forms.CheckBox CheckBoxEditSign;
        private System.Windows.Forms.Button ButtonEditEmployeeSign;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip MenuStrip;
    }
}