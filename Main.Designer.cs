
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
            this.ButtonCreateFolder = new System.Windows.Forms.Button();
            this.ButtonAddChapters = new System.Windows.Forms.Button();
            this.GroupBoxFunctionSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNewProject
            // 
            this.ButtonNewProject.Location = new System.Drawing.Point(6, 22);
            this.ButtonNewProject.Name = "ButtonNewProject";
            this.ButtonNewProject.Size = new System.Drawing.Size(93, 53);
            this.ButtonNewProject.TabIndex = 0;
            this.ButtonNewProject.Text = "Добавить новый проект";
            this.ButtonNewProject.UseVisualStyleBackColor = true;
            this.ButtonNewProject.Click += new System.EventHandler(this.ButtonNewProject_Click);
            // 
            // ButtonCreateIULs
            // 
            this.ButtonCreateIULs.Location = new System.Drawing.Point(6, 81);
            this.ButtonCreateIULs.Name = "ButtonCreateIULs";
            this.ButtonCreateIULs.Size = new System.Drawing.Size(93, 53);
            this.ButtonCreateIULs.TabIndex = 2;
            this.ButtonCreateIULs.Text = "Выгрузить ИУЛы";
            this.ButtonCreateIULs.UseVisualStyleBackColor = true;
            this.ButtonCreateIULs.Click += new System.EventHandler(this.ButtonCreateIULs_Click);
            // 
            // GroupBoxFunctionSelection
            // 
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonCreateFolder);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonAddChapters);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonNewProject);
            this.GroupBoxFunctionSelection.Controls.Add(this.ButtonCreateIULs);
            this.GroupBoxFunctionSelection.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFunctionSelection.Name = "GroupBoxFunctionSelection";
            this.GroupBoxFunctionSelection.Size = new System.Drawing.Size(207, 142);
            this.GroupBoxFunctionSelection.TabIndex = 4;
            this.GroupBoxFunctionSelection.TabStop = false;
            this.GroupBoxFunctionSelection.Text = "Выбор функции";
            // 
            // ButtonCreateFolder
            // 
            this.ButtonCreateFolder.Location = new System.Drawing.Point(105, 22);
            this.ButtonCreateFolder.Name = "ButtonCreateFolder";
            this.ButtonCreateFolder.Size = new System.Drawing.Size(93, 53);
            this.ButtonCreateFolder.TabIndex = 4;
            this.ButtonCreateFolder.Text = "Создать папку проекта";
            this.ButtonCreateFolder.UseVisualStyleBackColor = true;
            this.ButtonCreateFolder.Click += new System.EventHandler(this.ButtonCreateFolder_Click);
            // 
            // ButtonAddChapters
            // 
            this.ButtonAddChapters.Location = new System.Drawing.Point(105, 81);
            this.ButtonAddChapters.Name = "ButtonAddChapters";
            this.ButtonAddChapters.Size = new System.Drawing.Size(93, 53);
            this.ButtonAddChapters.TabIndex = 3;
            this.ButtonAddChapters.Text = "Добавить разделы к проекту";
            this.ButtonAddChapters.UseVisualStyleBackColor = true;
            this.ButtonAddChapters.Click += new System.EventHandler(this.ButtonAddChapters_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 159);
            this.Controls.Add(this.GroupBoxFunctionSelection);
            this.Name = "Main";
            this.Text = "Main";
            this.GroupBoxFunctionSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNewProject;
        private System.Windows.Forms.Button ButtonCreateIULs;
        private System.Windows.Forms.GroupBox GroupBoxFunctionSelection;
        private System.Windows.Forms.Button ButtonAddChapters;
        private System.Windows.Forms.Button ButtonCreateFolder;
    }
}