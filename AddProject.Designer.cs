﻿
namespace IUL
{
    partial class AddProject
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
            this.buttonCreateFolderProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelectAllChapters = new System.Windows.Forms.Button();
            this.buttonSelectAllReseach = new System.Windows.Forms.Button();
            this.buttonAddAuthorsChapters = new System.Windows.Forms.Button();
            this.buttonAddSubChapters = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateFolderProject
            // 
            this.buttonCreateFolderProject.Location = new System.Drawing.Point(565, 12);
            this.buttonCreateFolderProject.Name = "buttonCreateFolderProject";
            this.buttonCreateFolderProject.Size = new System.Drawing.Size(94, 41);
            this.buttonCreateFolderProject.TabIndex = 2;
            this.buttonCreateFolderProject.Text = "Создать папку проекта";
            this.buttonCreateFolderProject.UseVisualStyleBackColor = true;
            this.buttonCreateFolderProject.Click += new System.EventHandler(this.buttonCreateFolderProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
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
            this.checkedListBox1.Location = new System.Drawing.Point(9, 27);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 112);
            this.checkedListBox1.TabIndex = 5;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(326, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 76);
            this.groupBox1.TabIndex = 11;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 12;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(9, 231);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(647, 22);
            this.checkedListBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Разделы проектной документации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Наименование проекта";
            // 
            // buttonSelectAllChapters
            // 
            this.buttonSelectAllChapters.Location = new System.Drawing.Point(565, 55);
            this.buttonSelectAllChapters.Name = "buttonSelectAllChapters";
            this.buttonSelectAllChapters.Size = new System.Drawing.Size(94, 41);
            this.buttonSelectAllChapters.TabIndex = 16;
            this.buttonSelectAllChapters.Text = "Выбрать все разделы";
            this.buttonSelectAllChapters.UseVisualStyleBackColor = true;
            this.buttonSelectAllChapters.Click += new System.EventHandler(this.buttonSelectAllChapters_Click);
            // 
            // buttonSelectAllReseach
            // 
            this.buttonSelectAllReseach.Location = new System.Drawing.Point(565, 98);
            this.buttonSelectAllReseach.Name = "buttonSelectAllReseach";
            this.buttonSelectAllReseach.Size = new System.Drawing.Size(94, 41);
            this.buttonSelectAllReseach.TabIndex = 17;
            this.buttonSelectAllReseach.Text = "Выбрать все изыскания";
            this.buttonSelectAllReseach.UseVisualStyleBackColor = true;
            this.buttonSelectAllReseach.Click += new System.EventHandler(this.buttonSelectAllReseach_Click);
            // 
            // buttonAddAuthorsChapters
            // 
            this.buttonAddAuthorsChapters.Location = new System.Drawing.Point(565, 184);
            this.buttonAddAuthorsChapters.Name = "buttonAddAuthorsChapters";
            this.buttonAddAuthorsChapters.Size = new System.Drawing.Size(94, 41);
            this.buttonAddAuthorsChapters.TabIndex = 18;
            this.buttonAddAuthorsChapters.Text = "Добавить исполнителей";
            this.buttonAddAuthorsChapters.UseVisualStyleBackColor = true;
            this.buttonAddAuthorsChapters.Click += new System.EventHandler(this.buttonAddAuthorsChapters_Click);
            // 
            // buttonAddSubChapters
            // 
            this.buttonAddSubChapters.Location = new System.Drawing.Point(565, 141);
            this.buttonAddSubChapters.Name = "buttonAddSubChapters";
            this.buttonAddSubChapters.Size = new System.Drawing.Size(94, 41);
            this.buttonAddSubChapters.TabIndex = 19;
            this.buttonAddSubChapters.Text = "Добавить подразделы";
            this.buttonAddSubChapters.UseVisualStyleBackColor = true;
            this.buttonAddSubChapters.Click += new System.EventHandler(this.buttonAddSubChapters_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Шифр проекта";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 179);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 22);
            this.textBox2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "ГИП";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 23);
            this.comboBox2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Н. контр.";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 609);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonAddSubChapters);
            this.Controls.Add(this.buttonAddAuthorsChapters);
            this.Controls.Add(this.buttonSelectAllReseach);
            this.Controls.Add(this.buttonSelectAllChapters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateFolderProject);
            this.Name = "AddProject";
            this.Text = "Добавление проекта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateFolderProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelectAllChapters;
        private System.Windows.Forms.Button buttonSelectAllReseach;
        private System.Windows.Forms.Button buttonAddAuthorsChapters;
        private System.Windows.Forms.Button buttonAddSubChapters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    }
}