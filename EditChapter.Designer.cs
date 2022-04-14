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
            this.CheckBoxChangeAuthors = new System.Windows.Forms.CheckBox();
            this.LabelEmployeesAuthor = new System.Windows.Forms.Label();
            this.LabelAuthors = new System.Windows.Forms.Label();
            this.LabelProjectNames = new System.Windows.Forms.Label();
            this.ComboBoxProjectNames = new System.Windows.Forms.ComboBox();
            this.LabelChapterNames = new System.Windows.Forms.Label();
            this.ComboBoxChapterNames = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewAuthors
            // 
            this.DataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAuthors.Enabled = false;
            this.DataGridViewAuthors.Location = new System.Drawing.Point(266, 128);
            this.DataGridViewAuthors.Name = "DataGridViewAuthors";
            this.DataGridViewAuthors.RowTemplate.Height = 25;
            this.DataGridViewAuthors.Size = new System.Drawing.Size(240, 200);
            this.DataGridViewAuthors.TabIndex = 41;
            // 
            // DataGridViewChapterAuthors
            // 
            this.DataGridViewChapterAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChapterAuthors.Location = new System.Drawing.Point(18, 128);
            this.DataGridViewChapterAuthors.Name = "DataGridViewChapterAuthors";
            this.DataGridViewChapterAuthors.RowTemplate.Height = 25;
            this.DataGridViewChapterAuthors.Size = new System.Drawing.Size(240, 200);
            this.DataGridViewChapterAuthors.TabIndex = 40;
            // 
            // CheckBoxChangeAuthors
            // 
            this.CheckBoxChangeAuthors.AutoSize = true;
            this.CheckBoxChangeAuthors.Location = new System.Drawing.Point(421, 107);
            this.CheckBoxChangeAuthors.Name = "CheckBoxChangeAuthors";
            this.CheckBoxChangeAuthors.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxChangeAuthors.TabIndex = 39;
            this.CheckBoxChangeAuthors.Text = "Изменить?";
            this.CheckBoxChangeAuthors.UseVisualStyleBackColor = true;
            // 
            // LabelEmployeesAuthor
            // 
            this.LabelEmployeesAuthor.AutoSize = true;
            this.LabelEmployeesAuthor.Location = new System.Drawing.Point(266, 106);
            this.LabelEmployeesAuthor.Name = "LabelEmployeesAuthor";
            this.LabelEmployeesAuthor.Size = new System.Drawing.Size(143, 15);
            this.LabelEmployeesAuthor.TabIndex = 38;
            this.LabelEmployeesAuthor.Text = "Перечень исполнителей";
            // 
            // LabelAuthors
            // 
            this.LabelAuthors.AutoSize = true;
            this.LabelAuthors.Location = new System.Drawing.Point(18, 106);
            this.LabelAuthors.Name = "LabelAuthors";
            this.LabelAuthors.Size = new System.Drawing.Size(161, 15);
            this.LabelAuthors.TabIndex = 37;
            this.LabelAuthors.Text = "Перечень авторов разделов";
            // 
            // LabelProjectNames
            // 
            this.LabelProjectNames.AutoSize = true;
            this.LabelProjectNames.Location = new System.Drawing.Point(18, 6);
            this.LabelProjectNames.Name = "LabelProjectNames";
            this.LabelProjectNames.Size = new System.Drawing.Size(115, 15);
            this.LabelProjectNames.TabIndex = 26;
            this.LabelProjectNames.Text = "Перечень проектов";
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(18, 24);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(488, 23);
            this.ComboBoxProjectNames.TabIndex = 25;
            // 
            // LabelChapterNames
            // 
            this.LabelChapterNames.AutoSize = true;
            this.LabelChapterNames.Location = new System.Drawing.Point(18, 52);
            this.LabelChapterNames.Name = "LabelChapterNames";
            this.LabelChapterNames.Size = new System.Drawing.Size(115, 15);
            this.LabelChapterNames.TabIndex = 43;
            this.LabelChapterNames.Text = "Перечень проектов";
            // 
            // ComboBoxChapterNames
            // 
            this.ComboBoxChapterNames.FormattingEnabled = true;
            this.ComboBoxChapterNames.Location = new System.Drawing.Point(18, 70);
            this.ComboBoxChapterNames.Name = "ComboBoxChapterNames";
            this.ComboBoxChapterNames.Size = new System.Drawing.Size(488, 23);
            this.ComboBoxChapterNames.TabIndex = 42;
            // 
            // EditChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelChapterNames);
            this.Controls.Add(this.ComboBoxChapterNames);
            this.Controls.Add(this.DataGridViewAuthors);
            this.Controls.Add(this.DataGridViewChapterAuthors);
            this.Controls.Add(this.CheckBoxChangeAuthors);
            this.Controls.Add(this.LabelEmployeesAuthor);
            this.Controls.Add(this.LabelAuthors);
            this.Controls.Add(this.LabelProjectNames);
            this.Controls.Add(this.ComboBoxProjectNames);
            this.Name = "EditChapter";
            this.Text = "EditChapter";
            this.Load += new System.EventHandler(this.EditChapter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewAuthors;
        private System.Windows.Forms.DataGridView DataGridViewChapterAuthors;
        private System.Windows.Forms.CheckBox CheckBoxChangeAuthors;
        private System.Windows.Forms.Label LabelEmployeesAuthor;
        private System.Windows.Forms.Label LabelAuthors;
        private System.Windows.Forms.Label LabelProjectNames;
        private System.Windows.Forms.ComboBox ComboBoxProjectNames;
        private System.Windows.Forms.Label LabelChapterNames;
        private System.Windows.Forms.ComboBox ComboBoxChapterNames;
    }
}