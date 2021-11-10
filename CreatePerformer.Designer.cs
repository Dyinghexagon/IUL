
namespace IUL
{
    partial class CreatePerformer
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
            this.LabelNameChapters = new System.Windows.Forms.Label();
            this.ComboBoxChapters = new System.Windows.Forms.ComboBox();
            this.ComboBoxNameProjects = new System.Windows.Forms.ComboBox();
            this.LabelNameProjects = new System.Windows.Forms.Label();
            this.LabelSurnameEmploeey = new System.Windows.Forms.Label();
            this.ComboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.LabelRoleEmployee = new System.Windows.Forms.Label();
            this.ComboBoxRoles = new System.Windows.Forms.ComboBox();
            this.ButtonAddNewPerformer = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNameChapters
            // 
            this.LabelNameChapters.AutoSize = true;
            this.LabelNameChapters.Location = new System.Drawing.Point(12, 55);
            this.LabelNameChapters.Name = "LabelNameChapters";
            this.LabelNameChapters.Size = new System.Drawing.Size(114, 15);
            this.LabelNameChapters.TabIndex = 12;
            this.LabelNameChapters.Text = "Перечень разделов";
            // 
            // ComboBoxChapters
            // 
            this.ComboBoxChapters.FormattingEnabled = true;
            this.ComboBoxChapters.Location = new System.Drawing.Point(12, 73);
            this.ComboBoxChapters.Name = "ComboBoxChapters";
            this.ComboBoxChapters.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxChapters.TabIndex = 11;
            this.ComboBoxChapters.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChapters_SelectedIndexChanged);
            // 
            // ComboBoxNameProjects
            // 
            this.ComboBoxNameProjects.FormattingEnabled = true;
            this.ComboBoxNameProjects.Location = new System.Drawing.Point(12, 28);
            this.ComboBoxNameProjects.Name = "ComboBoxNameProjects";
            this.ComboBoxNameProjects.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxNameProjects.TabIndex = 10;
            this.ComboBoxNameProjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNameProjects_SelectedIndexChanged);
            // 
            // LabelNameProjects
            // 
            this.LabelNameProjects.AutoSize = true;
            this.LabelNameProjects.Location = new System.Drawing.Point(12, 9);
            this.LabelNameProjects.Name = "LabelNameProjects";
            this.LabelNameProjects.Size = new System.Drawing.Size(102, 15);
            this.LabelNameProjects.TabIndex = 9;
            this.LabelNameProjects.Text = "Выберите проект";
            // 
            // LabelSurnameEmploeey
            // 
            this.LabelSurnameEmploeey.AutoSize = true;
            this.LabelSurnameEmploeey.Location = new System.Drawing.Point(12, 99);
            this.LabelSurnameEmploeey.Name = "LabelSurnameEmploeey";
            this.LabelSurnameEmploeey.Size = new System.Drawing.Size(179, 15);
            this.LabelSurnameEmploeey.TabIndex = 14;
            this.LabelSurnameEmploeey.Text = "Фамилия исполнителя раздела";
            // 
            // ComboBoxEmployees
            // 
            this.ComboBoxEmployees.FormattingEnabled = true;
            this.ComboBoxEmployees.Location = new System.Drawing.Point(12, 117);
            this.ComboBoxEmployees.Name = "ComboBoxEmployees";
            this.ComboBoxEmployees.Size = new System.Drawing.Size(350, 23);
            this.ComboBoxEmployees.TabIndex = 13;
            this.ComboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmployees_SelectedIndexChanged);
            // 
            // LabelRoleEmployee
            // 
            this.LabelRoleEmployee.AutoSize = true;
            this.LabelRoleEmployee.Location = new System.Drawing.Point(361, 99);
            this.LabelRoleEmployee.Name = "LabelRoleEmployee";
            this.LabelRoleEmployee.Size = new System.Drawing.Size(109, 15);
            this.LabelRoleEmployee.TabIndex = 16;
            this.LabelRoleEmployee.Text = "Роль исполнителя";
            // 
            // ComboBoxRoles
            // 
            this.ComboBoxRoles.FormattingEnabled = true;
            this.ComboBoxRoles.Location = new System.Drawing.Point(361, 117);
            this.ComboBoxRoles.Name = "ComboBoxRoles";
            this.ComboBoxRoles.Size = new System.Drawing.Size(350, 23);
            this.ComboBoxRoles.TabIndex = 15;
            this.ComboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoles_SelectedIndexChanged);
            // 
            // ButtonAddNewPerformer
            // 
            this.ButtonAddNewPerformer.Location = new System.Drawing.Point(623, 146);
            this.ButtonAddNewPerformer.Name = "ButtonAddNewPerformer";
            this.ButtonAddNewPerformer.Size = new System.Drawing.Size(88, 44);
            this.ButtonAddNewPerformer.TabIndex = 17;
            this.ButtonAddNewPerformer.Text = "Добавить исполнителя";
            this.ButtonAddNewPerformer.UseVisualStyleBackColor = true;
            this.ButtonAddNewPerformer.Click += new System.EventHandler(this.ButtonAddNewPerformer_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(529, 146);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(88, 44);
            this.ButtonBack.TabIndex = 18;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CreatePerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 198);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddNewPerformer);
            this.Controls.Add(this.LabelRoleEmployee);
            this.Controls.Add(this.ComboBoxRoles);
            this.Controls.Add(this.LabelSurnameEmploeey);
            this.Controls.Add(this.ComboBoxEmployees);
            this.Controls.Add(this.LabelNameChapters);
            this.Controls.Add(this.ComboBoxChapters);
            this.Controls.Add(this.ComboBoxNameProjects);
            this.Controls.Add(this.LabelNameProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreatePerformer";
            this.Text = "Добавление исполнителей для раздела";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label LabelNameChapters;
        private System.Windows.Forms.ComboBox ComboBoxChapters;
        private System.Windows.Forms.ComboBox ComboBoxNameProjects;
        private System.Windows.Forms.Label LabelNameProjects;
        private System.Windows.Forms.Label LabelSurnameEmploeey;
        private System.Windows.Forms.ComboBox ComboBoxEmployees;
        private System.Windows.Forms.Label LabelRoleEmployee;
        private System.Windows.Forms.ComboBox ComboBoxRoles;
        private System.Windows.Forms.Button ButtonAddNewPerformer;
        private System.Windows.Forms.Button ButtonBack;
    }
}