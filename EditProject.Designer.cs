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
            this.SuspendLayout();
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(12, 26);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(470, 23);
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
            this.ButtonEdicting.Location = new System.Drawing.Point(381, 423);
            this.ButtonEdicting.Name = "ButtonEdicting";
            this.ButtonEdicting.Size = new System.Drawing.Size(101, 23);
            this.ButtonEdicting.TabIndex = 2;
            this.ButtonEdicting.Text = "Редактировать";
            this.ButtonEdicting.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 423);
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
            this.ComboBoxChapterNames.Size = new System.Drawing.Size(470, 23);
            this.ComboBoxChapterNames.TabIndex = 6;
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
            this.TextBoxGIP.Location = new System.Drawing.Point(175, 98);
            this.TextBoxGIP.Name = "TextBoxGIP";
            this.TextBoxGIP.Size = new System.Drawing.Size(307, 23);
            this.TextBoxGIP.TabIndex = 9;
            // 
            // TextBoxNkontr
            // 
            this.TextBoxNkontr.Enabled = false;
            this.TextBoxNkontr.Location = new System.Drawing.Point(175, 127);
            this.TextBoxNkontr.Name = "TextBoxNkontr";
            this.TextBoxNkontr.Size = new System.Drawing.Size(307, 23);
            this.TextBoxNkontr.TabIndex = 11;
            // 
            // LabelNkontr
            // 
            this.LabelNkontr.AutoSize = true;
            this.LabelNkontr.Location = new System.Drawing.Point(12, 130);
            this.LabelNkontr.Name = "LabelNkontr";
            this.LabelNkontr.Size = new System.Drawing.Size(105, 15);
            this.LabelNkontr.TabIndex = 10;
            this.LabelNkontr.Text = "Нормоконтролер";
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 451);
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
    }
}