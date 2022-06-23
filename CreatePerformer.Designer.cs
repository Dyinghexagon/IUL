
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
            this.LabelChapterNames = new System.Windows.Forms.Label();
            this.ComboBoxChapterNames = new System.Windows.Forms.ComboBox();
            this.ComboBoxProjectNames = new System.Windows.Forms.ComboBox();
            this.LabelProjectNames = new System.Windows.Forms.Label();
            this.LabelSurnameEmploeey = new System.Windows.Forms.Label();
            this.ComboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.LabelRoleEmployee = new System.Windows.Forms.Label();
            this.ComboBoxRoles = new System.Windows.Forms.ComboBox();
            this.ButtonAddNewPerformer = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.DataGridViewSelectedChapter = new System.Windows.Forms.DataGridView();
            this.LableSelectedChapter = new System.Windows.Forms.Label();
            this.CheckBoxIsAddMultiple = new System.Windows.Forms.CheckBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSelectedChapter)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelChapterNames
            // 
            this.LabelChapterNames.AutoSize = true;
            this.LabelChapterNames.Location = new System.Drawing.Point(0, 79);
            this.LabelChapterNames.Name = "LabelChapterNames";
            this.LabelChapterNames.Size = new System.Drawing.Size(114, 15);
            this.LabelChapterNames.TabIndex = 12;
            this.LabelChapterNames.Text = "Перечень разделов";
            // 
            // ComboBoxChapterNames
            // 
            this.ComboBoxChapterNames.FormattingEnabled = true;
            this.ComboBoxChapterNames.Location = new System.Drawing.Point(0, 97);
            this.ComboBoxChapterNames.Name = "ComboBoxChapterNames";
            this.ComboBoxChapterNames.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxChapterNames.TabIndex = 11;
            this.ComboBoxChapterNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChapters_SelectedIndexChanged);
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(0, 52);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxProjectNames.TabIndex = 10;
            this.ComboBoxProjectNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNameProjects_SelectedIndexChanged);
            // 
            // LabelProjectNames
            // 
            this.LabelProjectNames.AutoSize = true;
            this.LabelProjectNames.Location = new System.Drawing.Point(0, 33);
            this.LabelProjectNames.Name = "LabelProjectNames";
            this.LabelProjectNames.Size = new System.Drawing.Size(102, 15);
            this.LabelProjectNames.TabIndex = 9;
            this.LabelProjectNames.Text = "Выберите проект";
            // 
            // LabelSurnameEmploeey
            // 
            this.LabelSurnameEmploeey.AutoSize = true;
            this.LabelSurnameEmploeey.Location = new System.Drawing.Point(0, 123);
            this.LabelSurnameEmploeey.Name = "LabelSurnameEmploeey";
            this.LabelSurnameEmploeey.Size = new System.Drawing.Size(179, 15);
            this.LabelSurnameEmploeey.TabIndex = 14;
            this.LabelSurnameEmploeey.Text = "Фамилия исполнителя раздела";
            // 
            // ComboBoxEmployees
            // 
            this.ComboBoxEmployees.FormattingEnabled = true;
            this.ComboBoxEmployees.Location = new System.Drawing.Point(0, 141);
            this.ComboBoxEmployees.Name = "ComboBoxEmployees";
            this.ComboBoxEmployees.Size = new System.Drawing.Size(350, 23);
            this.ComboBoxEmployees.TabIndex = 13;
            this.ComboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmployees_SelectedIndexChanged);
            // 
            // LabelRoleEmployee
            // 
            this.LabelRoleEmployee.AutoSize = true;
            this.LabelRoleEmployee.Location = new System.Drawing.Point(349, 123);
            this.LabelRoleEmployee.Name = "LabelRoleEmployee";
            this.LabelRoleEmployee.Size = new System.Drawing.Size(109, 15);
            this.LabelRoleEmployee.TabIndex = 16;
            this.LabelRoleEmployee.Text = "Роль исполнителя";
            // 
            // ComboBoxRoles
            // 
            this.ComboBoxRoles.FormattingEnabled = true;
            this.ComboBoxRoles.Location = new System.Drawing.Point(349, 141);
            this.ComboBoxRoles.Name = "ComboBoxRoles";
            this.ComboBoxRoles.Size = new System.Drawing.Size(350, 23);
            this.ComboBoxRoles.TabIndex = 15;
            this.ComboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoles_SelectedIndexChanged);
            // 
            // ButtonAddNewPerformer
            // 
            this.ButtonAddNewPerformer.Location = new System.Drawing.Point(611, 170);
            this.ButtonAddNewPerformer.Name = "ButtonAddNewPerformer";
            this.ButtonAddNewPerformer.Size = new System.Drawing.Size(88, 44);
            this.ButtonAddNewPerformer.TabIndex = 17;
            this.ButtonAddNewPerformer.Text = "Добавить исполнителя";
            this.ButtonAddNewPerformer.UseVisualStyleBackColor = true;
            this.ButtonAddNewPerformer.Click += new System.EventHandler(this.ButtonAddNewPerformer_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(517, 170);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(88, 44);
            this.ButtonBack.TabIndex = 18;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // DataGridViewSelectedChapter
            // 
            this.DataGridViewSelectedChapter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSelectedChapter.Location = new System.Drawing.Point(0, 245);
            this.DataGridViewSelectedChapter.Name = "DataGridViewSelectedChapter";
            this.DataGridViewSelectedChapter.RowTemplate.Height = 25;
            this.DataGridViewSelectedChapter.Size = new System.Drawing.Size(699, 150);
            this.DataGridViewSelectedChapter.TabIndex = 19;
            // 
            // LableSelectedChapter
            // 
            this.LableSelectedChapter.AutoSize = true;
            this.LableSelectedChapter.Location = new System.Drawing.Point(1, 224);
            this.LableSelectedChapter.Name = "LableSelectedChapter";
            this.LableSelectedChapter.Size = new System.Drawing.Size(121, 15);
            this.LableSelectedChapter.TabIndex = 20;
            this.LableSelectedChapter.Text = "Выбранные разделы";
            // 
            // CheckBoxIsAddMultiple
            // 
            this.CheckBoxIsAddMultiple.AutoSize = true;
            this.CheckBoxIsAddMultiple.Location = new System.Drawing.Point(1, 195);
            this.CheckBoxIsAddMultiple.Name = "CheckBoxIsAddMultiple";
            this.CheckBoxIsAddMultiple.Size = new System.Drawing.Size(288, 19);
            this.CheckBoxIsAddMultiple.TabIndex = 21;
            this.CheckBoxIsAddMultiple.Text = "Добавить 1 сотрудника на несколько разделов?";
            this.CheckBoxIsAddMultiple.UseVisualStyleBackColor = true;
            this.CheckBoxIsAddMultiple.CheckedChanged += new System.EventHandler(this.CheckBoxIsAddMultiple_CheckedChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(705, 24);
            this.MenuStrip.TabIndex = 33;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // CreatePerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 403);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.CheckBoxIsAddMultiple);
            this.Controls.Add(this.LableSelectedChapter);
            this.Controls.Add(this.DataGridViewSelectedChapter);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddNewPerformer);
            this.Controls.Add(this.LabelRoleEmployee);
            this.Controls.Add(this.ComboBoxRoles);
            this.Controls.Add(this.LabelSurnameEmploeey);
            this.Controls.Add(this.ComboBoxEmployees);
            this.Controls.Add(this.LabelChapterNames);
            this.Controls.Add(this.ComboBoxChapterNames);
            this.Controls.Add(this.ComboBoxProjectNames);
            this.Controls.Add(this.LabelProjectNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreatePerformer";
            this.Text = "Добавление исполнителей для раздела";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSelectedChapter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label LabelChapterNames;
        private System.Windows.Forms.ComboBox ComboBoxChapterNames;
        private System.Windows.Forms.ComboBox ComboBoxProjectNames;
        private System.Windows.Forms.Label LabelProjectNames;
        private System.Windows.Forms.Label LabelSurnameEmploeey;
        private System.Windows.Forms.ComboBox ComboBoxEmployees;
        private System.Windows.Forms.Label LabelRoleEmployee;
        private System.Windows.Forms.ComboBox ComboBoxRoles;
        private System.Windows.Forms.Button ButtonAddNewPerformer;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DataGridView DataGridViewSelectedChapter;
        private System.Windows.Forms.Label LableSelectedChapter;
        private System.Windows.Forms.CheckBox CheckBoxIsAddMultiple;
        private System.Windows.Forms.MenuStrip MenuStrip;
    }
}