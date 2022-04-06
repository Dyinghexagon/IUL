
namespace IUL
{
    partial class CreateIUL
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewChapterNames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterNames)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxNameProjects
            // 
            this.ComboBoxNameProjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
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
            this.ButtonBack.Location = new System.Drawing.Point(12, 57);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonCreateIULs
            // 
            this.ButtonCreateIULs.Location = new System.Drawing.Point(93, 57);
            this.ButtonCreateIULs.Name = "ButtonCreateIULs";
            this.ButtonCreateIULs.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateIULs.TabIndex = 3;
            this.ButtonCreateIULs.Text = "Выгрузить";
            this.ButtonCreateIULs.UseVisualStyleBackColor = true;
            this.ButtonCreateIULs.Click += new System.EventHandler(this.ButtonCreateIULs_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список доступных ИУЛов";
            // 
            // DataGridViewChapterNames
            // 
            this.DataGridViewChapterNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChapterNames.Location = new System.Drawing.Point(12, 101);
            this.DataGridViewChapterNames.Name = "DataGridViewChapterNames";
            this.DataGridViewChapterNames.RowTemplate.Height = 25;
            this.DataGridViewChapterNames.Size = new System.Drawing.Size(465, 177);
            this.DataGridViewChapterNames.TabIndex = 7;
            this.DataGridViewChapterNames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // CreateIUL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 290);
            this.Controls.Add(this.DataGridViewChapterNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ButtonCreateIULs);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelNameProjectsHint);
            this.Controls.Add(this.ComboBoxNameProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateIUL";
            this.Text = "Создание ИУЛов";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterNames)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewChapterNames;
    }
}