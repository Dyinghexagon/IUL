
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
            this.ComboBoxProjectNames = new System.Windows.Forms.ComboBox();
            this.LabelProjectNames = new System.Windows.Forms.Label();
            this.ButtonCreateIULs = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LabelAvailableIULs = new System.Windows.Forms.Label();
            this.DataGridViewChapterNames = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterNames)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxProjectNames
            // 
            this.ComboBoxProjectNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxProjectNames.FormattingEnabled = true;
            this.ComboBoxProjectNames.Location = new System.Drawing.Point(8, 46);
            this.ComboBoxProjectNames.Name = "ComboBoxProjectNames";
            this.ComboBoxProjectNames.Size = new System.Drawing.Size(470, 23);
            this.ComboBoxProjectNames.TabIndex = 0;
            this.ComboBoxProjectNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNameProjects_SelectedIndexChanged);
            // 
            // LabelProjectNames
            // 
            this.LabelProjectNames.AutoSize = true;
            this.LabelProjectNames.Location = new System.Drawing.Point(8, 28);
            this.LabelProjectNames.Name = "LabelProjectNames";
            this.LabelProjectNames.Size = new System.Drawing.Size(115, 15);
            this.LabelProjectNames.TabIndex = 1;
            this.LabelProjectNames.Text = "Перечень проектов";
            // 
            // ButtonCreateIULs
            // 
            this.ButtonCreateIULs.Location = new System.Drawing.Point(8, 77);
            this.ButtonCreateIULs.Name = "ButtonCreateIULs";
            this.ButtonCreateIULs.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateIULs.TabIndex = 3;
            this.ButtonCreateIULs.Text = "Выгрузить";
            this.ButtonCreateIULs.UseVisualStyleBackColor = true;
            this.ButtonCreateIULs.Click += new System.EventHandler(this.ButtonCreateIULs_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(278, 77);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker.TabIndex = 4;
            // 
            // LabelAvailableIULs
            // 
            this.LabelAvailableIULs.AutoSize = true;
            this.LabelAvailableIULs.Location = new System.Drawing.Point(8, 103);
            this.LabelAvailableIULs.Name = "LabelAvailableIULs";
            this.LabelAvailableIULs.Size = new System.Drawing.Size(150, 15);
            this.LabelAvailableIULs.TabIndex = 6;
            this.LabelAvailableIULs.Text = "Список доступных ИУЛов";
            // 
            // DataGridViewChapterNames
            // 
            this.DataGridViewChapterNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChapterNames.Location = new System.Drawing.Point(8, 121);
            this.DataGridViewChapterNames.Name = "DataGridViewChapterNames";
            this.DataGridViewChapterNames.RowTemplate.Height = 25;
            this.DataGridViewChapterNames.Size = new System.Drawing.Size(470, 177);
            this.DataGridViewChapterNames.TabIndex = 7;
            this.DataGridViewChapterNames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(490, 24);
            this.MenuStrip.TabIndex = 8;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // CreateIUL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 306);
            this.Controls.Add(this.DataGridViewChapterNames);
            this.Controls.Add(this.LabelAvailableIULs);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.ButtonCreateIULs);
            this.Controls.Add(this.LabelProjectNames);
            this.Controls.Add(this.ComboBoxProjectNames);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "CreateIUL";
            this.Text = "Создание ИУЛов";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxProjectNames;
        private System.Windows.Forms.Label LabelProjectNames;
        private System.Windows.Forms.Button ButtonCreateIULs;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label LabelAvailableIULs;
        private System.Windows.Forms.DataGridView DataGridViewChapterNames;
        private System.Windows.Forms.MenuStrip MenuStrip;
    }
}