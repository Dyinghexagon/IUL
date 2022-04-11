
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
            this.ButtonNewProject = new System.Windows.Forms.Button();
            this.ButtonCreateIULs = new System.Windows.Forms.Button();
            this.GroupBoxFunctionSelection = new System.Windows.Forms.GroupBox();
            this.ButtonEditingProject = new System.Windows.Forms.Button();
            this.ButtonAddPerformers = new System.Windows.Forms.Button();
            this.ButtonCreateFolder = new System.Windows.Forms.Button();
            this.ButtonAddChapters = new System.Windows.Forms.Button();
            this.GroupBoxFunctionSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNewProject
            // 
            this.ButtonNewProject.Location = new System.Drawing.Point(105, 22);
            this.ButtonNewProject.Name = "ButtonNewProject";
            this.ButtonNewProject.Size = new System.Drawing.Size(95, 55);
            this.ButtonNewProject.TabIndex = 0;
            this.ButtonNewProject.Text = "Добавить новый проект";
            this.ButtonNewProject.UseVisualStyleBackColor = true;
            this.ButtonNewProject.Click += new System.EventHandler(this.ButtonNewProject_Click);
            // 
            // ButtonCreateIULs
            // 
            this.ButtonCreateIULs.Location = new System.Drawing.Point(206, 83);
            this.ButtonCreateIULs.Name = "ButtonCreateIULs";
            this.ButtonCreateIULs.Size = new System.Drawing.Size(95, 55);
            this.ButtonCreateIULs.TabIndex = 2;
            this.ButtonCreateIULs.Text = "Выгрузить ИУЛы";
            this.ButtonCreateIULs.UseVisualStyleBackColor = true;
            this.ButtonCreateIULs.Click += new System.EventHandler(this.ButtonCreateIULs_Click);
            // 
            // GroupBoxFunctionSelection
            // 
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonEditingProject);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonAddPerformers);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonCreateFolder);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonAddChapters);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonNewProject);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonCreateIULs);
            this.GroupBoxFunctionSelection.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFunctionSelection.Name = "GroupBoxFunctionSelection";
            this.GroupBoxFunctionSelection.Size = new System.Drawing.Size(312, 151);
            this.GroupBoxFunctionSelection.TabIndex = 4;
            this.GroupBoxFunctionSelection.TabStop = false;
            this.GroupBoxFunctionSelection.Text = "Выбор функции";
            // 
            // ButtonEditingProject
            // 
            this.ButtonEditingProject.Location = new System.Drawing.Point(105, 83);
            this.ButtonEditingProject.Name = "ButtonEditingProject";
            this.ButtonEditingProject.Size = new System.Drawing.Size(95, 55);
            this.ButtonEditingProject.TabIndex = 6;
            this.ButtonEditingProject.Text = "Редактировать данные о проекте";
            this.ButtonEditingProject.UseVisualStyleBackColor = true;
            this.ButtonEditingProject.Click += new System.EventHandler(this.ButtonEditProject_Click);
            // 
            // ButtonAddPerformers
            // 
            this.ButtonAddPerformers.Location = new System.Drawing.Point(6, 83);
            this.ButtonAddPerformers.Name = "ButtonAddPerformers";
            this.ButtonAddPerformers.Size = new System.Drawing.Size(95, 55);
            this.ButtonAddPerformers.TabIndex = 5;
            this.ButtonAddPerformers.Text = "Добавить исполнителей к проекту";
            this.ButtonAddPerformers.UseVisualStyleBackColor = true;
            this.ButtonAddPerformers.Click += new System.EventHandler(this.ButtonAddPerformers_Click);
            // 
            // ButtonCreateFolder
            // 
            this.ButtonCreateFolder.Location = new System.Drawing.Point(6, 22);
            this.ButtonCreateFolder.Name = "ButtonCreateFolder";
            this.ButtonCreateFolder.Size = new System.Drawing.Size(95, 55);
            this.ButtonCreateFolder.TabIndex = 4;
            this.ButtonCreateFolder.Text = "Создать папку проекта";
            this.ButtonCreateFolder.UseVisualStyleBackColor = true;
            this.ButtonCreateFolder.Click += new System.EventHandler(this.ButtonCreateFolder_Click);
            // 
            // ButtonAddChapters
            // 
            this.ButtonAddChapters.Location = new System.Drawing.Point(206, 22);
            this.ButtonAddChapters.Name = "ButtonAddChapters";
            this.ButtonAddChapters.Size = new System.Drawing.Size(95, 55);
            this.ButtonAddChapters.TabIndex = 3;
            this.ButtonAddChapters.Text = "Добавить разделы к проекту";
            this.ButtonAddChapters.UseVisualStyleBackColor = true;
            this.ButtonAddChapters.Click += new System.EventHandler(this.ButtonAddChapters_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 165);
            this.Controls.Add(this.GroupBoxFunctionSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Выбор функции";
            this.GroupBoxFunctionSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNewProject;
        private System.Windows.Forms.Button ButtonCreateIULs;
        private System.Windows.Forms.GroupBox GroupBoxFunctionSelection;
        private System.Windows.Forms.Button ButtonAddChapters;
        private System.Windows.Forms.Button ButtonCreateFolder;
        private System.Windows.Forms.Button ButtonAddPerformers;
        private System.Windows.Forms.Button ButtonEditingProject;
    }
}