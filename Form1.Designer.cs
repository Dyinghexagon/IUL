
namespace IUL
{
    partial class Form1
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
            this.ComboBoxNameProjects = new System.Windows.Forms.ComboBox();
            this.LabelNameProjectsHint = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonCreateIULs = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ComboBoxNameProjects
            // 
            this.ComboBoxNameProjects.FormattingEnabled = true;
            this.ComboBoxNameProjects.Location = new System.Drawing.Point(12, 26);
            this.ComboBoxNameProjects.Name = "ComboBoxNameProjects";
            this.ComboBoxNameProjects.Size = new System.Drawing.Size(465, 23);
            this.ComboBoxNameProjects.TabIndex = 0;
            this.ComboBoxNameProjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNameProjects_SelectedIndexChanged);
            // 
            // LabelNameProjectsHint
            // 
            this.LabelNameProjectsHint.AutoSize = true;
            this.LabelNameProjectsHint.Location = new System.Drawing.Point(12, 8);
            this.LabelNameProjectsHint.Name = "LabelNameProjectsHint";
            this.LabelNameProjectsHint.Size = new System.Drawing.Size(114, 15);
            this.LabelNameProjectsHint.TabIndex = 1;
            this.LabelNameProjectsHint.Text = "Перечень разделов";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 55);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonCreateIULs
            // 
            this.ButtonCreateIULs.Location = new System.Drawing.Point(93, 55);
            this.ButtonCreateIULs.Name = "ButtonCreateIULs";
            this.ButtonCreateIULs.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateIULs.TabIndex = 3;
            this.ButtonCreateIULs.Text = "Выгрузить";
            this.ButtonCreateIULs.UseVisualStyleBackColor = true;
            this.ButtonCreateIULs.Click += new System.EventHandler(this.ButtonCreateIULs_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 86);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ButtonCreateIULs);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelNameProjectsHint);
            this.Controls.Add(this.ComboBoxNameProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Создание ИУЛов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxNameProjects;
        private System.Windows.Forms.Label LabelNameProjectsHint;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonCreateIULs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}