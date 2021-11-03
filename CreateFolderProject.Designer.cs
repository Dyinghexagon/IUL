
namespace IUL
{
    partial class CreateFolderProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.buttonSelectAllReseach = new System.Windows.Forms.Button();
            this.buttonSelectAllChapters = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Изыскания";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Инженерно-геодезические изыскания",
            "Инженерно-геологические изыскания",
            "Инженерно-экологические изыскания",
            "Инженерно-гидрометеорологические изыскания",
            "Инженерно-геотехнические изыскания",
            "Техническое обсследование здания"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 112);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Разделы проектной документации";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(12, 153);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(640, 22);
            this.checkedListBox2.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(320, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 76);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проектная документация";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(226, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Объект капитального строительства";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "Объект линейного строительства";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Наименование папки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 16;
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.Location = new System.Drawing.Point(559, 12);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(94, 41);
            this.buttonCreateFolder.TabIndex = 18;
            this.buttonCreateFolder.Text = "Создать папку проекта";
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // buttonSelectAllReseach
            // 
            this.buttonSelectAllReseach.Location = new System.Drawing.Point(558, 106);
            this.buttonSelectAllReseach.Name = "buttonSelectAllReseach";
            this.buttonSelectAllReseach.Size = new System.Drawing.Size(94, 41);
            this.buttonSelectAllReseach.TabIndex = 20;
            this.buttonSelectAllReseach.Text = "Выбрать все изыскания";
            this.buttonSelectAllReseach.UseVisualStyleBackColor = true;
            this.buttonSelectAllReseach.Click += new System.EventHandler(this.buttonSelectAllReseach_Click);
            // 
            // buttonSelectAllChapters
            // 
            this.buttonSelectAllChapters.Location = new System.Drawing.Point(558, 59);
            this.buttonSelectAllChapters.Name = "buttonSelectAllChapters";
            this.buttonSelectAllChapters.Size = new System.Drawing.Size(94, 41);
            this.buttonSelectAllChapters.TabIndex = 19;
            this.buttonSelectAllChapters.Text = "Выбрать все разделы";
            this.buttonSelectAllChapters.UseVisualStyleBackColor = true;
            this.buttonSelectAllChapters.Click += new System.EventHandler(this.buttonSelectAllChapters_Click);
            // 
            // CreateFolderProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.buttonSelectAllReseach);
            this.Controls.Add(this.buttonSelectAllChapters);
            this.Controls.Add(this.buttonCreateFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateFolderProject";
            this.Text = "AddFolderProject";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.Button buttonSelectAllReseach;
        private System.Windows.Forms.Button buttonSelectAllChapters;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}