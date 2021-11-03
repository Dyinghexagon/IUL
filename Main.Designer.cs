
namespace IUL
{
    partial class Main
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
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.buttonCreateIULs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddChapters = new System.Windows.Forms.Button();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.Location = new System.Drawing.Point(6, 22);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(93, 53);
            this.buttonNewProject.TabIndex = 0;
            this.buttonNewProject.Text = "Добавить новый проект";
            this.buttonNewProject.UseVisualStyleBackColor = true;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // buttonCreateIULs
            // 
            this.buttonCreateIULs.Location = new System.Drawing.Point(6, 81);
            this.buttonCreateIULs.Name = "buttonCreateIULs";
            this.buttonCreateIULs.Size = new System.Drawing.Size(93, 53);
            this.buttonCreateIULs.TabIndex = 2;
            this.buttonCreateIULs.Text = "Выгрузить ИУЛы";
            this.buttonCreateIULs.UseVisualStyleBackColor = true;
            this.buttonCreateIULs.Click += new System.EventHandler(this.buttonCreateIULs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateFolder);
            this.groupBox1.Controls.Add(this.buttonAddChapters);
            this.groupBox1.Controls.Add(this.buttonNewProject);
            this.groupBox1.Controls.Add(this.buttonCreateIULs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор функции";
            // 
            // buttonAddChapters
            // 
            this.buttonAddChapters.Location = new System.Drawing.Point(105, 81);
            this.buttonAddChapters.Name = "buttonAddChapters";
            this.buttonAddChapters.Size = new System.Drawing.Size(93, 53);
            this.buttonAddChapters.TabIndex = 3;
            this.buttonAddChapters.Text = "Добавить разделы к проекту";
            this.buttonAddChapters.UseVisualStyleBackColor = true;
            this.buttonAddChapters.Click += new System.EventHandler(this.buttonAddChapters_Click);
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.Location = new System.Drawing.Point(105, 22);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(93, 53);
            this.buttonCreateFolder.TabIndex = 4;
            this.buttonCreateFolder.Text = "Создать папку проекта";
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 159);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.Button buttonCreateIULs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddChapters;
        private System.Windows.Forms.Button buttonCreateFolder;
    }
}