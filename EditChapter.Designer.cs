namespace IUL
{
    partial class EditChapter
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
            this.DataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.DataGridViewChapterAuthors = new System.Windows.Forms.DataGridView();
            this.CheckBoxEditAuthors = new System.Windows.Forms.CheckBox();
            this.LabelEmployeesAuthor = new System.Windows.Forms.Label();
            this.LabelAuthors = new System.Windows.Forms.Label();
            this.LabelProjectNames = new System.Windows.Forms.Label();
            this.ComboBoxProjectNames = new System.Windows.Forms.ComboBox();
            this.LabelChapterNames = new System.Windows.Forms.Label();
            this.ComboBoxChapterNames = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxEditName = new System.Windows.Forms.TextBox();
            this.LabelEditName = new System.Windows.Forms.Label();
            this.CheckBoxEditNameChapter = new System.Windows.Forms.CheckBox();
            this.ButtonEditPath = new System.Windows.Forms.Button();
            this.CheckBoxEditPath = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewAuthors
            // 
            this.DataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAuthors.Enabled = false;
            this.DataGridViewAuthors.Location = new System.Drawing.Point(316, 230);
            this.DataGridViewAuthors.Name = "DataGridViewAuthors";
            this.DataGridViewAuthors.RowTemplate.Height = 25;
            this.DataGridViewAuthors.Size = new System.Drawing.Size(300, 200);
            this.DataGridViewAuthors.TabIndex = 41;
            // 
            // DataGridViewChapterAuthors
            // 
            this.DataGridViewChapterAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChapterAuthors.Location = new System.Drawing.Point(10, 230);
            this.DataGridViewChapterAuthors.Name = "DataGridViewChapterAuthors";
            this.DataGridViewChapterAuthors.RowTemplate.Height = 25;
            this.DataGridViewChapterAuthors.Size = new System.Drawing.Size(300, 200);
            this.DataGridViewChapterAuthors.TabIndex = 40;
            // 
            // CheckBoxEditAuthors
            // 
            this.CheckBoxEditAuthors.AutoSize = true;
            this.CheckBoxEditAuthors.Location = new System.Drawing.Point(531, 211);
            this.CheckBoxEditAuthors.Name = "CheckBoxEditAuthors";
            this.CheckBoxEditAuthors.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEditAuthors.TabIndex = 39;
            this.CheckBoxEditAuthors.Text = "Изменить?";
            this.CheckBoxEditAuthors.UseVisualStyleBackColor = true;
            this.CheckBoxEditAuthors.CheckedChanged += new System.EventHandler(this.CheckBoxEditAuthors_CheckedChanged);
            // 
            // LabelEmployeesAuthor
            // 
            this.LabelEmployeesAuthor.AutoSize = true;
            this.LabelEmployeesAuthor.Location = new System.Drawing.Point(316, 212);
            this.LabelEmployeesAuthor.Name = "LabelEmployeesAuthor";
            this.LabelEmployeesAuthor.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesAuthor.TabIndex = 38;
            this.LabelEmployeesAuthor.Text = "Перечень исполнителей";
            // 
            // LabelAuthors
            // 
            this.LabelAuthors.AutoSize = true;
            this.LabelAuthors.Location = new System.Drawing.Point(10, 212);
            this.LabelAuthors.Name = "LabelAuthors";
            this.LabelAuthors.Size = new System.Drawing.Size(161, 15);
            this.LabelAuthors.TabIndex = 37;
            this.LabelAuthors.Text = "Перечень авторов разделов";
            // 
            // LabelProjectNames
            // 
            this.LabelProjectNames.AutoSize = true;
            this.LabelProjectNames.Location = new System.Drawing.Point(10, 6);
            this.LabelProjectNames.Name = "LabelProjectNames";
            this.LabelProjectNames.Size = new System.Drawing.Size(115, 15);
            this.LabelProjectNames.TabIndex = 26;
            this.LabelProjectNames.Text = "Перечень проектов";
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(10, 24);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(606, 23);
            this.ComboBoxProjectNames.TabIndex = 25;
            this.ComboBoxProjectNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProjectNames_SelectedIndexChanged);
            // 
            // LabelChapterNames
            // 
            this.LabelChapterNames.AutoSize = true;
            this.LabelChapterNames.Location = new System.Drawing.Point(10, 52);
            this.LabelChapterNames.Name = "LabelChapterNames";
            this.LabelChapterNames.Size = new System.Drawing.Size(115, 15);
            this.LabelChapterNames.TabIndex = 43;
            this.LabelChapterNames.Text = "Перечень проектов";
            // 
            // ComboBoxChapterNames
            // 
            this.ComboBoxChapterNames.FormattingEnabled = true;
            this.ComboBoxChapterNames.Location = new System.Drawing.Point(10, 70);
            this.ComboBoxChapterNames.Name = "ComboBoxChapterNames";
            this.ComboBoxChapterNames.Size = new System.Drawing.Size(606, 23);
            this.ComboBoxChapterNames.TabIndex = 42;
            this.ComboBoxChapterNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChapterNames_SelectedIndexChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(10, 436);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 44;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(541, 436);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 45;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxEditName
            // 
            this.TextBoxEditName.Enabled = false;
            this.TextBoxEditName.Location = new System.Drawing.Point(10, 116);
            this.TextBoxEditName.Multiline = true;
            this.TextBoxEditName.Name = "TextBoxEditName";
            this.TextBoxEditName.Size = new System.Drawing.Size(493, 87);
            this.TextBoxEditName.TabIndex = 46;
            // 
            // LabelEditName
            // 
            this.LabelEditName.AutoSize = true;
            this.LabelEditName.Location = new System.Drawing.Point(10, 98);
            this.LabelEditName.Name = "LabelEditName";
            this.LabelEditName.Size = new System.Drawing.Size(207, 15);
            this.LabelEditName.TabIndex = 47;
            this.LabelEditName.Text = "Наименование выбранного раздела";
            // 
            // CheckBoxEditNameChapter
            // 
            this.CheckBoxEditNameChapter.AutoSize = true;
            this.CheckBoxEditNameChapter.Location = new System.Drawing.Point(418, 94);
            this.CheckBoxEditNameChapter.Name = "CheckBoxEditNameChapter";
            this.CheckBoxEditNameChapter.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEditNameChapter.TabIndex = 48;
            this.CheckBoxEditNameChapter.Text = "Изменить?";
            this.CheckBoxEditNameChapter.UseVisualStyleBackColor = true;
            this.CheckBoxEditNameChapter.CheckedChanged += new System.EventHandler(this.CheckBoxEditNameChapter_CheckedChanged);
            // 
            // ButtonEditPath
            // 
            this.ButtonEditPath.Enabled = false;
            this.ButtonEditPath.Location = new System.Drawing.Point(509, 116);
            this.ButtonEditPath.Name = "ButtonEditPath";
            this.ButtonEditPath.Size = new System.Drawing.Size(107, 87);
            this.ButtonEditPath.TabIndex = 49;
            this.ButtonEditPath.Text = "Изменить путь к файлу раздела";
            this.ButtonEditPath.UseVisualStyleBackColor = true;
            this.ButtonEditPath.Click += new System.EventHandler(this.ButtonEditPath_Click);
            // 
            // CheckBoxEditPath
            // 
            this.CheckBoxEditPath.AutoSize = true;
            this.CheckBoxEditPath.Location = new System.Drawing.Point(531, 94);
            this.CheckBoxEditPath.Name = "CheckBoxEditPath";
            this.CheckBoxEditPath.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxEditPath.TabIndex = 50;
            this.CheckBoxEditPath.Text = "Изменить?";
            this.CheckBoxEditPath.UseVisualStyleBackColor = true;
            this.CheckBoxEditPath.CheckedChanged += new System.EventHandler(this.CheckBoxEditPath_CheckedChanged);
            // 
            // EditChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 468);
            this.Controls.Add(this.CheckBoxEditPath);
            this.Controls.Add(this.ButtonEditPath);
            this.Controls.Add(this.CheckBoxEditNameChapter);
            this.Controls.Add(this.LabelEditName);
            this.Controls.Add(this.TextBoxEditName);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelChapterNames);
            this.Controls.Add(this.ComboBoxChapterNames);
            this.Controls.Add(this.DataGridViewAuthors);
            this.Controls.Add(this.DataGridViewChapterAuthors);
            this.Controls.Add(this.CheckBoxEditAuthors);
            this.Controls.Add(this.LabelEmployeesAuthor);
            this.Controls.Add(this.LabelAuthors);
            this.Controls.Add(this.LabelProjectNames);
            this.Controls.Add(this.ComboBoxProjectNames);
            this.Name = "EditChapter";
            this.Text = "Изменить данные о разделе";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewAuthors;
        private System.Windows.Forms.DataGridView DataGridViewChapterAuthors;
        private System.Windows.Forms.CheckBox CheckBoxEditAuthors;
        private System.Windows.Forms.Label LabelEmployeesAuthor;
        private System.Windows.Forms.Label LabelAuthors;
        private System.Windows.Forms.Label LabelProjectNames;
        private System.Windows.Forms.ComboBox ComboBoxProjectNames;
        private System.Windows.Forms.Label LabelChapterNames;
        private System.Windows.Forms.ComboBox ComboBoxChapterNames;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxEditName;
        private System.Windows.Forms.Label LabelEditName;
        private System.Windows.Forms.CheckBox CheckBoxEditNameChapter;
        private System.Windows.Forms.Button ButtonEditPath;
        private System.Windows.Forms.CheckBox CheckBoxEditPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}