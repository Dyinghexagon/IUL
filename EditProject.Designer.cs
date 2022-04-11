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
            this.LabelChapterNames = new System.Windows.Forms.Label();
            this.ComboBoxChapterNames = new System.Windows.Forms.ComboBox();
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
            this.LabelAuthors = new System.Windows.Forms.Label();
            this.CheckBoxChangeAuthors = new System.Windows.Forms.CheckBox();
            this.LabelEmployeesAuthor = new System.Windows.Forms.Label();
            this.DataGridViewChapterAuthors = new System.Windows.Forms.DataGridView();
            this.DataGridViewAuthors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(12, 26);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(488, 23);
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
            this.ButtonEdicting.Location = new System.Drawing.Point(399, 416);
            this.ButtonEdicting.Name = "ButtonEdicting";
            this.ButtonEdicting.Size = new System.Drawing.Size(101, 23);
            this.ButtonEdicting.TabIndex = 2;
            this.ButtonEdicting.Text = "Редактировать";
            this.ButtonEdicting.UseVisualStyleBackColor = true;
            this.ButtonEdicting.Click += new System.EventHandler(this.ButtonEdicting_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 416);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelChapterNames
            // 
            this.LabelChapterNames.AutoSize = true;
            this.LabelChapterNames.Location = new System.Drawing.Point(12, 51);
            this.LabelChapterNames.Name = "LabelChapterNames";
            this.LabelChapterNames.Size = new System.Drawing.Size(114, 15);
            this.LabelChapterNames.TabIndex = 7;
            this.LabelChapterNames.Text = "Перечень разделов";
            // 
            // ComboBoxChapterNames
            // 
            this.ComboBoxChapterNames.FormattingEnabled = true;
            this.ComboBoxChapterNames.Location = new System.Drawing.Point(12, 69);
            this.ComboBoxChapterNames.Name = "ComboBoxChapterNames";
            this.ComboBoxChapterNames.Size = new System.Drawing.Size(488, 23);
            this.ComboBoxChapterNames.TabIndex = 6;
            this.ComboBoxChapterNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChapterNames_SelectedIndexChanged);
            // 
            // LabelGIP
            // 
            this.LabelGIP.AutoSize = true;
            this.LabelGIP.Location = new System.Drawing.Point(12, 101);
            this.LabelGIP.Name = "LabelGIP";
            this.LabelGIP.Size = new System.Drawing.Size(158, 15);
            this.LabelGIP.TabIndex = 8;
            this.LabelGIP.Text = "Главный Инженер Проекта";
            // 
            // TextBoxGIP
            // 
            this.TextBoxGIP.Enabled = false;
            this.TextBoxGIP.Location = new System.Drawing.Point(12, 119);
            this.TextBoxGIP.Name = "TextBoxGIP";
            this.TextBoxGIP.Size = new System.Drawing.Size(201, 23);
            this.TextBoxGIP.TabIndex = 9;
            // 
            // TextBoxNkontr
            // 
            this.TextBoxNkontr.Enabled = false;
            this.TextBoxNkontr.Location = new System.Drawing.Point(12, 162);
            this.TextBoxNkontr.Name = "TextBoxNkontr";
            this.TextBoxNkontr.Size = new System.Drawing.Size(201, 23);
            this.TextBoxNkontr.TabIndex = 11;
            // 
            // LabelNkontr
            // 
            this.LabelNkontr.AutoSize = true;
            this.LabelNkontr.Location = new System.Drawing.Point(12, 144);
            this.LabelNkontr.Name = "LabelNkontr";
            this.LabelNkontr.Size = new System.Drawing.Size(105, 15);
            this.LabelNkontr.TabIndex = 10;
            this.LabelNkontr.Text = "Нормоконтролер";
            // 
            // CheckBoxChangeGIP
            // 
            this.CheckBoxChangeGIP.AutoSize = true;
            this.CheckBoxChangeGIP.Location = new System.Drawing.Point(415, 123);
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
            this.LabelEmployeesGIP.Location = new System.Drawing.Point(219, 101);
            this.LabelEmployeesGIP.Name = "LabelEmployeesGIP";
            this.LabelEmployeesGIP.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesGIP.TabIndex = 14;
            this.LabelEmployeesGIP.Text = "Перечень исполнителей";
            // 
            // ComboBoxeEmployeesGIP
            // 
            this.ComboBoxeEmployeesGIP.Enabled = false;
            this.ComboBoxeEmployeesGIP.FormattingEnabled = true;
            this.ComboBoxeEmployeesGIP.Location = new System.Drawing.Point(219, 119);
            this.ComboBoxeEmployeesGIP.Name = "ComboBoxeEmployeesGIP";
            this.ComboBoxeEmployeesGIP.Size = new System.Drawing.Size(190, 23);
            this.ComboBoxeEmployeesGIP.TabIndex = 13;
            // 
            // LabelEmployeesNkontr
            // 
            this.LabelEmployeesNkontr.AutoSize = true;
            this.LabelEmployeesNkontr.Location = new System.Drawing.Point(219, 144);
            this.LabelEmployeesNkontr.Name = "LabelEmployeesNkontr";
            this.LabelEmployeesNkontr.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesNkontr.TabIndex = 16;
            this.LabelEmployeesNkontr.Text = "Перечень исполнителей";
            // 
            // ComboBoxeEmployeesNkontr
            // 
            this.ComboBoxeEmployeesNkontr.Enabled = false;
            this.ComboBoxeEmployeesNkontr.FormattingEnabled = true;
            this.ComboBoxeEmployeesNkontr.Location = new System.Drawing.Point(219, 162);
            this.ComboBoxeEmployeesNkontr.Name = "ComboBoxeEmployeesNkontr";
            this.ComboBoxeEmployeesNkontr.Size = new System.Drawing.Size(190, 23);
            this.ComboBoxeEmployeesNkontr.TabIndex = 15;
            // 
            // CheckBoxChangeNkontr
            // 
            this.CheckBoxChangeNkontr.AutoSize = true;
            this.CheckBoxChangeNkontr.Location = new System.Drawing.Point(415, 166);
            this.CheckBoxChangeNkontr.Name = "CheckBoxChangeNkontr";
            this.CheckBoxChangeNkontr.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeNkontr.TabIndex = 17;
            this.CheckBoxChangeNkontr.Text = "Изменить?";
            this.CheckBoxChangeNkontr.UseVisualStyleBackColor = true;
            this.CheckBoxChangeNkontr.CheckedChanged += new System.EventHandler(this.CheckBoxChangeNkontr_CheckedChanged);
            // 
            // LabelAuthors
            // 
            this.LabelAuthors.AutoSize = true;
            this.LabelAuthors.Location = new System.Drawing.Point(12, 190);
            this.LabelAuthors.Name = "LabelAuthors";
            this.LabelAuthors.Size = new System.Drawing.Size(161, 15);
            this.LabelAuthors.TabIndex = 19;
            this.LabelAuthors.Text = "Перечень авторов разделов";
            // 
            // CheckBoxChangeAuthors
            // 
            this.CheckBoxChangeAuthors.AutoSize = true;
            this.CheckBoxChangeAuthors.Location = new System.Drawing.Point(415, 191);
            this.CheckBoxChangeAuthors.Name = "CheckBoxChangeAuthors";
            this.CheckBoxChangeAuthors.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeAuthors.TabIndex = 22;
            this.CheckBoxChangeAuthors.Text = "Изменить?";
            this.CheckBoxChangeAuthors.UseVisualStyleBackColor = true;
            this.CheckBoxChangeAuthors.CheckedChanged += new System.EventHandler(this.CheckBoxChangeAuthors_CheckedChanged);
            // 
            // LabelEmployeesAuthor
            // 
            this.LabelEmployeesAuthor.AutoSize = true;
            this.LabelEmployeesAuthor.Location = new System.Drawing.Point(260, 190);
            this.LabelEmployeesAuthor.Name = "LabelEmployeesAuthor";
            this.LabelEmployeesAuthor.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesAuthor.TabIndex = 21;
            this.LabelEmployeesAuthor.Text = "Перечень исполнителей";
            // 
            // DataGridViewChapterAuthors
            // 
            this.DataGridViewChapterAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChapterAuthors.Location = new System.Drawing.Point(12, 212);
            this.DataGridViewChapterAuthors.Name = "DataGridViewChapterAuthors";
            this.DataGridViewChapterAuthors.RowTemplate.Height = 25;
            this.DataGridViewChapterAuthors.Size = new System.Drawing.Size(240, 200);
            this.DataGridViewChapterAuthors.TabIndex = 23;
            // 
            // DataGridViewAuthors
            // 
            this.DataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAuthors.Enabled = false;
            this.DataGridViewAuthors.Location = new System.Drawing.Point(260, 212);
            this.DataGridViewAuthors.Name = "DataGridViewAuthors";
            this.DataGridViewAuthors.RowTemplate.Height = 25;
            this.DataGridViewAuthors.Size = new System.Drawing.Size(240, 200);
            this.DataGridViewAuthors.TabIndex = 24;
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 451);
            this.Controls.Add(this.DataGridViewAuthors);
            this.Controls.Add(this.DataGridViewChapterAuthors);
            this.Controls.Add(this.CheckBoxChangeAuthors);
            this.Controls.Add(this.LabelEmployeesAuthor);
            this.Controls.Add(this.LabelAuthors);
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
            this.Controls.Add(this.LabelChapterNames);
            this.Controls.Add(this.ComboBoxChapterNames);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonEdicting);
            this.Controls.Add(this.LabelProjectNames);
            this.Controls.Add(this.ComboBoxProjectNames);
            this.Name = "EditProject";
            this.Text = "Редактирование информации о проекте";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxProjectNames;
        private System.Windows.Forms.Label LabelProjectNames;
        private System.Windows.Forms.Button ButtonEdicting;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelChapterNames;
        private System.Windows.Forms.ComboBox ComboBoxChapterNames;
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
        private System.Windows.Forms.Label LabelAuthors;
        private System.Windows.Forms.CheckBox CheckBoxChangeAuthors;
        private System.Windows.Forms.Label LabelEmployeesAuthor;
        private System.Windows.Forms.DataGridView DataGridViewChapterAuthors;
        private System.Windows.Forms.DataGridView DataGridViewAuthors;
    }
}